namespace Mynventory.View
{
    partial class Dobavljaci_dodaj
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
            this.m_cancel_dob = new MetroFramework.Controls.MetroButton();
            this.m_ok_dob = new MetroFramework.Controls.MetroButton();
            this.m_info = new MetroFramework.Controls.MetroLabel();
            this.m_obavezno = new MetroFramework.Controls.MetroLabel();
            this.m_oibd = new MetroFramework.Controls.MetroTextBox();
            this.m_adresad = new MetroFramework.Controls.MetroTextBox();
            this.m_teld = new MetroFramework.Controls.MetroTextBox();
            this.l_oibd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.l_tel = new MetroFramework.Controls.MetroLabel();
            this.m_nazivd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.m_emaild = new MetroFramework.Controls.MetroTextBox();
            this.l_email = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // m_cancel_dob
            // 
            this.m_cancel_dob.BackColor = System.Drawing.Color.LimeGreen;
            this.m_cancel_dob.Location = new System.Drawing.Point(885, 349);
            this.m_cancel_dob.Name = "m_cancel_dob";
            this.m_cancel_dob.Size = new System.Drawing.Size(125, 49);
            this.m_cancel_dob.Style = MetroFramework.MetroColorStyle.Green;
            this.m_cancel_dob.TabIndex = 65;
            this.m_cancel_dob.Text = "Natrag/Otkaži";
            this.m_cancel_dob.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cancel_dob.UseCustomBackColor = true;
            this.m_cancel_dob.UseCustomForeColor = true;
            this.m_cancel_dob.UseSelectable = true;
            this.m_cancel_dob.Click += new System.EventHandler(this.m_cancel_dob_Click);
            // 
            // m_ok_dob
            // 
            this.m_ok_dob.BackColor = System.Drawing.Color.LimeGreen;
            this.m_ok_dob.Location = new System.Drawing.Point(885, 257);
            this.m_ok_dob.Name = "m_ok_dob";
            this.m_ok_dob.Size = new System.Drawing.Size(125, 48);
            this.m_ok_dob.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ok_dob.TabIndex = 64;
            this.m_ok_dob.Text = "Potvrdi";
            this.m_ok_dob.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ok_dob.UseCustomBackColor = true;
            this.m_ok_dob.UseCustomForeColor = true;
            this.m_ok_dob.UseSelectable = true;
            this.m_ok_dob.Click += new System.EventHandler(this.m_ok_dob_Click);
            // 
            // m_info
            // 
            this.m_info.AutoSize = true;
            this.m_info.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_info.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_info.Location = new System.Drawing.Point(213, 120);
            this.m_info.Name = "m_info";
            this.m_info.Size = new System.Drawing.Size(262, 25);
            this.m_info.Style = MetroFramework.MetroColorStyle.Green;
            this.m_info.TabIndex = 54;
            this.m_info.Text = "Unesite detalje novog dobavljača";
            this.m_info.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_info.UseCustomForeColor = true;
            // 
            // m_obavezno
            // 
            this.m_obavezno.AutoSize = true;
            this.m_obavezno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_obavezno.ForeColor = System.Drawing.Color.Red;
            this.m_obavezno.Location = new System.Drawing.Point(245, 576);
            this.m_obavezno.Name = "m_obavezno";
            this.m_obavezno.Size = new System.Drawing.Size(139, 25);
            this.m_obavezno.Style = MetroFramework.MetroColorStyle.Green;
            this.m_obavezno.TabIndex = 53;
            this.m_obavezno.Text = "* obavezna polja";
            this.m_obavezno.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_obavezno.UseCustomForeColor = true;
            // 
            // m_oibd
            // 
            // 
            // 
            // 
            this.m_oibd.CustomButton.Image = null;
            this.m_oibd.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_oibd.CustomButton.Name = "";
            this.m_oibd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_oibd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_oibd.CustomButton.TabIndex = 1;
            this.m_oibd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_oibd.CustomButton.UseSelectable = true;
            this.m_oibd.CustomButton.Visible = false;
            this.m_oibd.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_oibd.Lines = new string[0];
            this.m_oibd.Location = new System.Drawing.Point(418, 501);
            this.m_oibd.MaxLength = 32767;
            this.m_oibd.Name = "m_oibd";
            this.m_oibd.PasswordChar = '\0';
            this.m_oibd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_oibd.SelectedText = "";
            this.m_oibd.SelectionLength = 0;
            this.m_oibd.SelectionStart = 0;
            this.m_oibd.ShortcutsEnabled = true;
            this.m_oibd.Size = new System.Drawing.Size(268, 23);
            this.m_oibd.Style = MetroFramework.MetroColorStyle.Green;
            this.m_oibd.TabIndex = 95;
            this.m_oibd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_oibd.UseCustomForeColor = true;
            this.m_oibd.UseSelectable = true;
            this.m_oibd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_oibd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_adresad
            // 
            // 
            // 
            // 
            this.m_adresad.CustomButton.Image = null;
            this.m_adresad.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_adresad.CustomButton.Name = "";
            this.m_adresad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_adresad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_adresad.CustomButton.TabIndex = 1;
            this.m_adresad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_adresad.CustomButton.UseSelectable = true;
            this.m_adresad.CustomButton.Visible = false;
            this.m_adresad.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_adresad.Lines = new string[0];
            this.m_adresad.Location = new System.Drawing.Point(418, 440);
            this.m_adresad.MaxLength = 32767;
            this.m_adresad.Name = "m_adresad";
            this.m_adresad.PasswordChar = '\0';
            this.m_adresad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_adresad.SelectedText = "";
            this.m_adresad.SelectionLength = 0;
            this.m_adresad.SelectionStart = 0;
            this.m_adresad.ShortcutsEnabled = true;
            this.m_adresad.Size = new System.Drawing.Size(268, 23);
            this.m_adresad.Style = MetroFramework.MetroColorStyle.Green;
            this.m_adresad.TabIndex = 94;
            this.m_adresad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_adresad.UseCustomForeColor = true;
            this.m_adresad.UseSelectable = true;
            this.m_adresad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_adresad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_teld
            // 
            // 
            // 
            // 
            this.m_teld.CustomButton.Image = null;
            this.m_teld.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_teld.CustomButton.Name = "";
            this.m_teld.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_teld.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_teld.CustomButton.TabIndex = 1;
            this.m_teld.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_teld.CustomButton.UseSelectable = true;
            this.m_teld.CustomButton.Visible = false;
            this.m_teld.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_teld.Lines = new string[0];
            this.m_teld.Location = new System.Drawing.Point(418, 318);
            this.m_teld.MaxLength = 32767;
            this.m_teld.Name = "m_teld";
            this.m_teld.PasswordChar = '\0';
            this.m_teld.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_teld.SelectedText = "";
            this.m_teld.SelectionLength = 0;
            this.m_teld.SelectionStart = 0;
            this.m_teld.ShortcutsEnabled = true;
            this.m_teld.Size = new System.Drawing.Size(268, 23);
            this.m_teld.Style = MetroFramework.MetroColorStyle.Green;
            this.m_teld.TabIndex = 93;
            this.m_teld.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_teld.UseCustomForeColor = true;
            this.m_teld.UseSelectable = true;
            this.m_teld.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_teld.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // l_oibd
            // 
            this.l_oibd.AutoSize = true;
            this.l_oibd.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_oibd.Location = new System.Drawing.Point(245, 505);
            this.l_oibd.Name = "l_oibd";
            this.l_oibd.Size = new System.Drawing.Size(34, 19);
            this.l_oibd.Style = MetroFramework.MetroColorStyle.Green;
            this.l_oibd.TabIndex = 92;
            this.l_oibd.Text = "OIB:";
            this.l_oibd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_oibd.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel8.Location = new System.Drawing.Point(245, 444);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel8.TabIndex = 91;
            this.metroLabel8.Text = "Adresa:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // l_tel
            // 
            this.l_tel.AutoSize = true;
            this.l_tel.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_tel.Location = new System.Drawing.Point(245, 322);
            this.l_tel.Name = "l_tel";
            this.l_tel.Size = new System.Drawing.Size(53, 19);
            this.l_tel.Style = MetroFramework.MetroColorStyle.Green;
            this.l_tel.TabIndex = 90;
            this.l_tel.Text = "Telefon:";
            this.l_tel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_tel.UseCustomForeColor = true;
            // 
            // m_nazivd
            // 
            // 
            // 
            // 
            this.m_nazivd.CustomButton.Image = null;
            this.m_nazivd.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_nazivd.CustomButton.Name = "";
            this.m_nazivd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_nazivd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_nazivd.CustomButton.TabIndex = 1;
            this.m_nazivd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_nazivd.CustomButton.UseSelectable = true;
            this.m_nazivd.CustomButton.Visible = false;
            this.m_nazivd.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_nazivd.Lines = new string[0];
            this.m_nazivd.Location = new System.Drawing.Point(418, 257);
            this.m_nazivd.MaxLength = 32767;
            this.m_nazivd.Name = "m_nazivd";
            this.m_nazivd.PasswordChar = '\0';
            this.m_nazivd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_nazivd.SelectedText = "";
            this.m_nazivd.SelectionLength = 0;
            this.m_nazivd.SelectionStart = 0;
            this.m_nazivd.ShortcutsEnabled = true;
            this.m_nazivd.Size = new System.Drawing.Size(268, 23);
            this.m_nazivd.Style = MetroFramework.MetroColorStyle.Green;
            this.m_nazivd.TabIndex = 89;
            this.m_nazivd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_nazivd.UseCustomForeColor = true;
            this.m_nazivd.UseSelectable = true;
            this.m_nazivd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_nazivd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel10.Location = new System.Drawing.Point(245, 261);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(44, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel10.TabIndex = 88;
            this.metroLabel10.Text = "Naziv:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Red;
            this.metroLabel11.Location = new System.Drawing.Point(386, 440);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(15, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel11.TabIndex = 96;
            this.metroLabel11.Text = "*";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(386, 501);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(15, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 97;
            this.metroLabel1.Text = "*";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(386, 318);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 98;
            this.metroLabel2.Text = "*";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(386, 257);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(15, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 99;
            this.metroLabel3.Text = "*";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(386, 379);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(15, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 102;
            this.metroLabel4.Text = "*";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // m_emaild
            // 
            // 
            // 
            // 
            this.m_emaild.CustomButton.Image = null;
            this.m_emaild.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_emaild.CustomButton.Name = "";
            this.m_emaild.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_emaild.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_emaild.CustomButton.TabIndex = 1;
            this.m_emaild.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_emaild.CustomButton.UseSelectable = true;
            this.m_emaild.CustomButton.Visible = false;
            this.m_emaild.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_emaild.Lines = new string[0];
            this.m_emaild.Location = new System.Drawing.Point(418, 379);
            this.m_emaild.MaxLength = 32767;
            this.m_emaild.Name = "m_emaild";
            this.m_emaild.PasswordChar = '\0';
            this.m_emaild.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_emaild.SelectedText = "";
            this.m_emaild.SelectionLength = 0;
            this.m_emaild.SelectionStart = 0;
            this.m_emaild.ShortcutsEnabled = true;
            this.m_emaild.Size = new System.Drawing.Size(268, 23);
            this.m_emaild.Style = MetroFramework.MetroColorStyle.Green;
            this.m_emaild.TabIndex = 101;
            this.m_emaild.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_emaild.UseCustomForeColor = true;
            this.m_emaild.UseSelectable = true;
            this.m_emaild.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_emaild.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_email.Location = new System.Drawing.Point(245, 383);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(44, 19);
            this.l_email.Style = MetroFramework.MetroColorStyle.Green;
            this.l_email.TabIndex = 100;
            this.l_email.Text = "Email:";
            this.l_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_email.UseCustomForeColor = true;
            // 
            // Dobavljaci_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.m_emaild);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.m_oibd);
            this.Controls.Add(this.m_adresad);
            this.Controls.Add(this.m_teld);
            this.Controls.Add(this.l_oibd);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.l_tel);
            this.Controls.Add(this.m_nazivd);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.m_cancel_dob);
            this.Controls.Add(this.m_ok_dob);
            this.Controls.Add(this.m_info);
            this.Controls.Add(this.m_obavezno);
            this.Name = "Dobavljaci_dodaj";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory : Dodaj dobavljača";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Dobavljaci_dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton m_cancel_dob;
        private MetroFramework.Controls.MetroButton m_ok_dob;
        private MetroFramework.Controls.MetroLabel m_info;
        private MetroFramework.Controls.MetroLabel m_obavezno;
        public MetroFramework.Controls.MetroTextBox m_oibd;
        public MetroFramework.Controls.MetroTextBox m_adresad;
        public MetroFramework.Controls.MetroTextBox m_teld;
        private MetroFramework.Controls.MetroLabel l_oibd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel l_tel;
        public MetroFramework.Controls.MetroTextBox m_nazivd;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox m_emaild;
        private MetroFramework.Controls.MetroLabel l_email;
    }
}