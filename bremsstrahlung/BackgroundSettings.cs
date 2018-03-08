﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bremsstrahlung
{
    public partial class BackgroundSettings : Form
    {
        public BackgroundSettings()
        {
            InitializeComponent();
            RefreshBackgroundList();
            //Properties.BackgroundSettings.Default.Reset();
        }

        void RefreshBackgroundList()
        {
            BackgroundListBox.Items.Clear();
            for (int counterI = 0; counterI < (int)Properties.BackgroundSettings.Default.BackgroundNames.Count; counterI++)
            {
                BackgroundListBox.Items.Add(Properties.BackgroundSettings.Default.BackgroundNames[counterI]);
            }
            DefaultBackgroundLabel.Text = Properties.BackgroundSettings.Default.DefaultBackgroundName;
        }

        private void SetBackground_Click(object sender, EventArgs e)
        {
            if (BackgroundListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Фон не выбран");
            }
            else
            {
                Properties.BackgroundSettings.Default.DefaultBackgroundName = Properties.BackgroundSettings.Default.BackgroundNames[BackgroundListBox.SelectedIndex];
                Properties.BackgroundSettings.Default.DefaultBackgroundPath = Properties.BackgroundSettings.Default.BackgroundPaths[BackgroundListBox.SelectedIndex];
                Properties.BackgroundSettings.Default.Save();
            }
            Form1 mainForm = this.Owner as Form1;
            mainForm.SetBackgroundProcedure();
            RefreshBackgroundList();            
        }

        private void AddBackground_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "АТОМТЕХ Спектр (*.ats)|*.ats";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.BackgroundSettings.Default.BackgroundPaths.Add(openFileDialog.FileName);
                    Properties.BackgroundSettings.Default.BackgroundNames.Add(openFileDialog.SafeFileName);
                    Properties.BackgroundSettings.Default.Save();
                    RefreshBackgroundList();
                }
            }
        }

        private void DeleteBackground_Click(object sender, EventArgs e)
        {
            if (Properties.BackgroundSettings.Default.DefaultBackgroundName.ToString() == BackgroundListBox.SelectedItem.ToString())
            {
                MessageBox.Show("Невозможно удалить фон по умолчанию");
            }
            else
            {
                Properties.BackgroundSettings.Default.BackgroundPaths.Remove(BackgroundListBox.SelectedItem.ToString());
                Properties.BackgroundSettings.Default.BackgroundNames.Remove(BackgroundListBox.SelectedItem.ToString());
                Properties.BackgroundSettings.Default.Save();
                RefreshBackgroundList();
            }
        }

        private void ResetBackgroundButton_Click(object sender, EventArgs e)
        {
            Properties.BackgroundSettings.Default.Reset();
            Properties.BackgroundSettings.Default.Save();
            RefreshBackgroundList();
        }
    }
}