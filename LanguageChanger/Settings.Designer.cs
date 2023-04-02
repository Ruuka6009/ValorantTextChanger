namespace LanguageChanger
{
    partial class Settings
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
            this.theme1 = new System.Windows.Forms.RadioButton();
            this.theme2 = new System.Windows.Forms.RadioButton();
            this.theme3 = new System.Windows.Forms.RadioButton();
            this.theme4 = new System.Windows.Forms.RadioButton();
            this.colorprev1 = new System.Windows.Forms.Panel();
            this.colorprev2 = new System.Windows.Forms.Panel();
            this.colorprev3 = new System.Windows.Forms.Panel();
            this.colorprev4 = new System.Windows.Forms.Panel();
            this.apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // theme1
            // 
            this.theme1.AutoSize = true;
            this.theme1.Location = new System.Drawing.Point(12, 12);
            this.theme1.Name = "theme1";
            this.theme1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.theme1.Size = new System.Drawing.Size(114, 19);
            this.theme1.TabIndex = 0;
            this.theme1.TabStop = true;
            this.theme1.Text = "Grayish magenta";
            this.theme1.UseVisualStyleBackColor = true;
            this.theme1.CheckedChanged += new System.EventHandler(this.theme1_CheckedChanged);
            // 
            // theme2
            // 
            this.theme2.AutoSize = true;
            this.theme2.Location = new System.Drawing.Point(12, 37);
            this.theme2.Name = "theme2";
            this.theme2.Size = new System.Drawing.Size(90, 19);
            this.theme2.TabIndex = 1;
            this.theme2.TabStop = true;
            this.theme2.Text = "Grayish blue";
            this.theme2.UseVisualStyleBackColor = true;
            this.theme2.CheckedChanged += new System.EventHandler(this.theme2_CheckedChanged);
            // 
            // theme3
            // 
            this.theme3.AutoSize = true;
            this.theme3.Location = new System.Drawing.Point(12, 62);
            this.theme3.Name = "theme3";
            this.theme3.Size = new System.Drawing.Size(101, 19);
            this.theme3.TabIndex = 2;
            this.theme3.TabStop = true;
            this.theme3.Text = "Grayish yellow";
            this.theme3.UseVisualStyleBackColor = true;
            this.theme3.CheckedChanged += new System.EventHandler(this.theme3_CheckedChanged);
            // 
            // theme4
            // 
            this.theme4.AutoSize = true;
            this.theme4.Location = new System.Drawing.Point(12, 87);
            this.theme4.Name = "theme4";
            this.theme4.Size = new System.Drawing.Size(123, 19);
            this.theme4.TabIndex = 3;
            this.theme4.TabStop = true;
            this.theme4.Text = "Grayish lime green";
            this.theme4.UseVisualStyleBackColor = true;
            this.theme4.CheckedChanged += new System.EventHandler(this.theme4_CheckedChanged);
            // 
            // colorprev1
            // 
            this.colorprev1.Location = new System.Drawing.Point(145, 6);
            this.colorprev1.Name = "colorprev1";
            this.colorprev1.Size = new System.Drawing.Size(50, 50);
            this.colorprev1.TabIndex = 4;
            // 
            // colorprev2
            // 
            this.colorprev2.Location = new System.Drawing.Point(201, 6);
            this.colorprev2.Name = "colorprev2";
            this.colorprev2.Size = new System.Drawing.Size(50, 50);
            this.colorprev2.TabIndex = 5;
            // 
            // colorprev3
            // 
            this.colorprev3.Location = new System.Drawing.Point(145, 62);
            this.colorprev3.Name = "colorprev3";
            this.colorprev3.Size = new System.Drawing.Size(50, 50);
            this.colorprev3.TabIndex = 5;
            // 
            // colorprev4
            // 
            this.colorprev4.Location = new System.Drawing.Point(201, 62);
            this.colorprev4.Name = "colorprev4";
            this.colorprev4.Size = new System.Drawing.Size(50, 50);
            this.colorprev4.TabIndex = 6;
            // 
            // apply
            // 
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Location = new System.Drawing.Point(12, 117);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(239, 29);
            this.apply.TabIndex = 7;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.colorprev4);
            this.Controls.Add(this.colorprev3);
            this.Controls.Add(this.colorprev2);
            this.Controls.Add(this.colorprev1);
            this.Controls.Add(this.theme4);
            this.Controls.Add(this.theme3);
            this.Controls.Add(this.theme2);
            this.Controls.Add(this.theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language changer - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton theme1;
        private RadioButton theme2;
        private RadioButton theme3;
        private RadioButton theme4;
        private Panel colorprev1;
        private Panel colorprev2;
        private Panel colorprev3;
        private Panel colorprev4;
        private Button apply;
    }
}