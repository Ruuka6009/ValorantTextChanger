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
            this.components = new System.ComponentModel.Container();
            this.changeBtn = new System.Windows.Forms.Button();
            this.nameHey = new System.Windows.Forms.Label();
            this.currentLang = new System.Windows.Forms.Label();
            this.allLanguage = new System.Windows.Forms.ComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.settingsbtn = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.anim1 = new System.Windows.Forms.Timer(this.components);
            this.anim2 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(149, 79);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(70, 23);
            this.changeBtn.TabIndex = 0;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // nameHey
            // 
            this.nameHey.AutoSize = true;
            this.nameHey.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameHey.ForeColor = System.Drawing.Color.White;
            this.nameHey.Location = new System.Drawing.Point(172, 52);
            this.nameHey.Name = "nameHey";
            this.nameHey.Size = new System.Drawing.Size(40, 30);
            this.nameHey.TabIndex = 2;
            this.nameHey.Text = "???";
            // 
            // currentLang
            // 
            this.currentLang.AutoSize = true;
            this.currentLang.ForeColor = System.Drawing.Color.White;
            this.currentLang.Location = new System.Drawing.Point(225, 83);
            this.currentLang.Name = "currentLang";
            this.currentLang.Size = new System.Drawing.Size(22, 15);
            this.currentLang.TabIndex = 3;
            this.currentLang.Text = "???";
            this.currentLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allLanguage
            // 
            this.allLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allLanguage.FormattingEnabled = true;
            this.allLanguage.Location = new System.Drawing.Point(17, 79);
            this.allLanguage.Name = "allLanguage";
            this.allLanguage.Size = new System.Drawing.Size(126, 23);
            this.allLanguage.TabIndex = 4;
            this.allLanguage.SelectedIndexChanged += new System.EventHandler(this.allLanguage_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.titlePanel);
            this.topPanel.Controls.Add(this.allLanguage);
            this.topPanel.Controls.Add(this.changeBtn);
            this.topPanel.Controls.Add(this.nameHey);
            this.topPanel.Controls.Add(this.currentLang);
            this.topPanel.Location = new System.Drawing.Point(12, 12);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(381, 111);
            this.topPanel.TabIndex = 5;
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSize = true;
            this.titlePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlePanel.Font = new System.Drawing.Font("Panic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlePanel.ForeColor = System.Drawing.Color.Thistle;
            this.titlePanel.Location = new System.Drawing.Point(11, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(349, 29);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Text = "LanguageChanger";
            // 
            // settingsbtn
            // 
            this.settingsbtn.Image = global::LanguageChanger.Properties.Resources.settings;
            this.settingsbtn.Location = new System.Drawing.Point(373, 29);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(25, 25);
            this.settingsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsbtn.TabIndex = 2;
            this.settingsbtn.TabStop = false;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Image = global::LanguageChanger.Properties.Resources.close;
            this.closebtn.Location = new System.Drawing.Point(373, 4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(25, 25);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebtn.TabIndex = 1;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // anim1
            // 
            this.anim1.Tick += new System.EventHandler(this.anim1_Tick);
            // 
            // anim2
            // 
            this.anim2.Tick += new System.EventHandler(this.anim2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(403, 135);
            this.Controls.Add(this.settingsbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button changeBtn;
        private Label nameHey;
        private Label currentLang;
        private ComboBox allLanguage;
        private Panel topPanel;
        private System.Windows.Forms.Timer anim1;
        private System.Windows.Forms.Timer anim2;
        private Label titlePanel;
        private PictureBox closebtn;
        private PictureBox settingsbtn;
    }
}