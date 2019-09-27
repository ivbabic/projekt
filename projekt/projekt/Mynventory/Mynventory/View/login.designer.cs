namespace Mynventory.View
{
    partial class Login
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
            this.clear = new MetroFramework.Controls.MetroButton();
            this.intro = new MetroFramework.Controls.MetroLabel();
            this.b_login = new MetroFramework.Controls.MetroButton();
            this.Pass_txt = new MetroFramework.Controls.MetroTextBox();
            this.User_txt = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.Username = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.ForeColor = System.Drawing.Color.LawnGreen;
            this.clear.Location = new System.Drawing.Point(259, 409);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 40);
            this.clear.Style = MetroFramework.MetroColorStyle.Green;
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.clear.UseCustomForeColor = true;
            this.clear.UseSelectable = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // intro
            // 
            this.intro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intro.AutoSize = true;
            this.intro.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.intro.ForeColor = System.Drawing.Color.LawnGreen;
            this.intro.Location = new System.Drawing.Point(46, 183);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(212, 25);
            this.intro.TabIndex = 19;
            this.intro.Text = "Unesite podatke za prijavu";
            this.intro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.intro.UseCustomForeColor = true;
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.Transparent;
            this.b_login.ForeColor = System.Drawing.Color.LawnGreen;
            this.b_login.Location = new System.Drawing.Point(123, 409);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(94, 40);
            this.b_login.Style = MetroFramework.MetroColorStyle.Green;
            this.b_login.TabIndex = 18;
            this.b_login.Text = "Login";
            this.b_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_login.UseCustomForeColor = true;
            this.b_login.UseSelectable = true;
            this.b_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // Pass_txt
            // 
            // 
            // 
            // 
            this.Pass_txt.CustomButton.Image = null;
            this.Pass_txt.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.Pass_txt.CustomButton.Name = "";
            this.Pass_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Pass_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Pass_txt.CustomButton.TabIndex = 1;
            this.Pass_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Pass_txt.CustomButton.UseSelectable = true;
            this.Pass_txt.CustomButton.Visible = false;
            this.Pass_txt.ForeColor = System.Drawing.Color.LawnGreen;
            this.Pass_txt.Lines = new string[] {
        "admin"};
            this.Pass_txt.Location = new System.Drawing.Point(182, 297);
            this.Pass_txt.MaxLength = 32767;
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '#';
            this.Pass_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pass_txt.SelectedText = "";
            this.Pass_txt.SelectionLength = 0;
            this.Pass_txt.SelectionStart = 0;
            this.Pass_txt.ShortcutsEnabled = true;
            this.Pass_txt.Size = new System.Drawing.Size(171, 23);
            this.Pass_txt.Style = MetroFramework.MetroColorStyle.Green;
            this.Pass_txt.TabIndex = 17;
            this.Pass_txt.Text = "admin";
            this.Pass_txt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Pass_txt.UseCustomForeColor = true;
            this.Pass_txt.UseSelectable = true;
            this.Pass_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Pass_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Pass_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pass_txt_KeyUp);
            // 
            // User_txt
            // 
            // 
            // 
            // 
            this.User_txt.CustomButton.Image = null;
            this.User_txt.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.User_txt.CustomButton.Name = "";
            this.User_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.User_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.User_txt.CustomButton.TabIndex = 1;
            this.User_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.User_txt.CustomButton.UseSelectable = true;
            this.User_txt.CustomButton.Visible = false;
            this.User_txt.ForeColor = System.Drawing.Color.LawnGreen;
            this.User_txt.Lines = new string[] {
        "Kristian"};
            this.User_txt.Location = new System.Drawing.Point(182, 258);
            this.User_txt.MaxLength = 32767;
            this.User_txt.Name = "User_txt";
            this.User_txt.PasswordChar = '\0';
            this.User_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_txt.SelectedText = "";
            this.User_txt.SelectionLength = 0;
            this.User_txt.SelectionStart = 0;
            this.User_txt.ShortcutsEnabled = true;
            this.User_txt.Size = new System.Drawing.Size(171, 23);
            this.User_txt.Style = MetroFramework.MetroColorStyle.Green;
            this.User_txt.TabIndex = 16;
            this.User_txt.Text = "Kristian";
            this.User_txt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.User_txt.UseCustomForeColor = true;
            this.User_txt.UseSelectable = true;
            this.User_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.User_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.User_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.User_txt_KeyUp);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Password.ForeColor = System.Drawing.Color.LawnGreen;
            this.Password.Location = new System.Drawing.Point(46, 295);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 25);
            this.Password.TabIndex = 15;
            this.Password.Text = "Password";
            this.Password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Password.UseCustomForeColor = true;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Username.ForeColor = System.Drawing.Color.LawnGreen;
            this.Username.Location = new System.Drawing.Point(46, 256);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(89, 25);
            this.Username.TabIndex = 14;
            this.Username.Text = "Username";
            this.Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Username.UseCustomForeColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 542);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login - MyNventory";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton clear;
        private MetroFramework.Controls.MetroLabel intro;
        private MetroFramework.Controls.MetroButton b_login;
        public MetroFramework.Controls.MetroTextBox Pass_txt;
        public MetroFramework.Controls.MetroTextBox User_txt;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroLabel Username;
    }
}