namespace LanguageChanger
{
    partial class Main
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
            this.changeBtn = new System.Windows.Forms.Button();
            this.nameHey = new System.Windows.Forms.Label();
            this.currentLang = new System.Windows.Forms.Label();
            this.allLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(144, 42);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(245, 23);
            this.changeBtn.TabIndex = 0;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // nameHey
            // 
            this.nameHey.AutoSize = true;
            this.nameHey.Location = new System.Drawing.Point(12, 9);
            this.nameHey.Name = "nameHey";
            this.nameHey.Size = new System.Drawing.Size(22, 15);
            this.nameHey.TabIndex = 2;
            this.nameHey.Text = "???";
            // 
            // currentLang
            // 
            this.currentLang.AutoSize = true;
            this.currentLang.Location = new System.Drawing.Point(12, 24);
            this.currentLang.Name = "currentLang";
            this.currentLang.Size = new System.Drawing.Size(22, 15);
            this.currentLang.TabIndex = 3;
            this.currentLang.Text = "???";
            // 
            // allLanguage
            // 
            this.allLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allLanguage.FormattingEnabled = true;
            this.allLanguage.Location = new System.Drawing.Point(12, 42);
            this.allLanguage.Name = "allLanguage";
            this.allLanguage.Size = new System.Drawing.Size(126, 23);
            this.allLanguage.TabIndex = 4;
            this.allLanguage.SelectedIndexChanged += new System.EventHandler(this.allLanguage_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 77);
            this.Controls.Add(this.allLanguage);
            this.Controls.Add(this.currentLang);
            this.Controls.Add(this.nameHey);
            this.Controls.Add(this.changeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button changeBtn;
        private Label nameHey;
        private Label currentLang;
        private ComboBox allLanguage;
    }
}