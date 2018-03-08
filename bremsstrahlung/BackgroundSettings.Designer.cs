namespace bremsstrahlung
{
    partial class BackgroundSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackgroundListBox = new System.Windows.Forms.ListBox();
            this.SetBackground = new System.Windows.Forms.Button();
            this.DeleteBackground = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultBackgroundLabel = new System.Windows.Forms.Label();
            this.AddBackground = new System.Windows.Forms.Button();
            this.ResetBackgroundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackgroundListBox
            // 
            this.BackgroundListBox.FormattingEnabled = true;
            this.BackgroundListBox.Location = new System.Drawing.Point(12, 25);
            this.BackgroundListBox.Name = "BackgroundListBox";
            this.BackgroundListBox.Size = new System.Drawing.Size(350, 82);
            this.BackgroundListBox.TabIndex = 0;
            // 
            // SetBackground
            // 
            this.SetBackground.Location = new System.Drawing.Point(12, 113);
            this.SetBackground.Name = "SetBackground";
            this.SetBackground.Size = new System.Drawing.Size(75, 23);
            this.SetBackground.TabIndex = 1;
            this.SetBackground.Text = "Установить";
            this.SetBackground.UseVisualStyleBackColor = true;
            this.SetBackground.Click += new System.EventHandler(this.SetBackground_Click);
            // 
            // DeleteBackground
            // 
            this.DeleteBackground.Location = new System.Drawing.Point(174, 113);
            this.DeleteBackground.Name = "DeleteBackground";
            this.DeleteBackground.Size = new System.Drawing.Size(75, 23);
            this.DeleteBackground.TabIndex = 2;
            this.DeleteBackground.Text = "Удалить";
            this.DeleteBackground.UseVisualStyleBackColor = true;
            this.DeleteBackground.Click += new System.EventHandler(this.DeleteBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущий фон:";
            // 
            // DefaultBackgroundLabel
            // 
            this.DefaultBackgroundLabel.AutoSize = true;
            this.DefaultBackgroundLabel.Location = new System.Drawing.Point(96, 9);
            this.DefaultBackgroundLabel.Name = "DefaultBackgroundLabel";
            this.DefaultBackgroundLabel.Size = new System.Drawing.Size(99, 13);
            this.DefaultBackgroundLabel.TabIndex = 4;
            this.DefaultBackgroundLabel.Text = "Background_Name";
            // 
            // AddBackground
            // 
            this.AddBackground.Location = new System.Drawing.Point(93, 113);
            this.AddBackground.Name = "AddBackground";
            this.AddBackground.Size = new System.Drawing.Size(75, 23);
            this.AddBackground.TabIndex = 5;
            this.AddBackground.Text = "Добавить...";
            this.AddBackground.UseVisualStyleBackColor = true;
            this.AddBackground.Click += new System.EventHandler(this.AddBackground_Click);
            // 
            // ResetBackgroundButton
            // 
            this.ResetBackgroundButton.Location = new System.Drawing.Point(255, 113);
            this.ResetBackgroundButton.Name = "ResetBackgroundButton";
            this.ResetBackgroundButton.Size = new System.Drawing.Size(107, 23);
            this.ResetBackgroundButton.TabIndex = 6;
            this.ResetBackgroundButton.Text = "По умолчанию";
            this.ResetBackgroundButton.UseVisualStyleBackColor = true;
            this.ResetBackgroundButton.Click += new System.EventHandler(this.ResetBackgroundButton_Click);
            // 
            // BackgroundSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 143);
            this.Controls.Add(this.ResetBackgroundButton);
            this.Controls.Add(this.AddBackground);
            this.Controls.Add(this.DefaultBackgroundLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBackground);
            this.Controls.Add(this.SetBackground);
            this.Controls.Add(this.BackgroundListBox);
            this.Name = "BackgroundSettings";
            this.Text = "Фон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BackgroundListBox;
        private System.Windows.Forms.Button SetBackground;
        private System.Windows.Forms.Button DeleteBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DefaultBackgroundLabel;
        private System.Windows.Forms.Button AddBackground;
        private System.Windows.Forms.Button ResetBackgroundButton;
    }
}