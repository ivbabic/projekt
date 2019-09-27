namespace Mynventory.View
{
    partial class Useri_dodaj
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
            this.l_ime = new MetroFramework.Controls.MetroLabel();
            this.l_prezime = new MetroFramework.Controls.MetroLabel();
            this.l_rola = new MetroFramework.Controls.MetroLabel();
            this.l_tel = new MetroFramework.Controls.MetroLabel();
            this.l_email = new MetroFramework.Controls.MetroLabel();
            this.l_pas = new MetroFramework.Controls.MetroLabel();
            this.l_pass2 = new MetroFramework.Controls.MetroLabel();
            this.m_ime = new MetroFramework.Controls.MetroTextBox();
            this.m_prezime = new MetroFramework.Controls.MetroTextBox();
            this.m_rola = new MetroFramework.Controls.MetroComboBox();
            this.m_tel = new MetroFramework.Controls.MetroTextBox();
            this.m_email = new MetroFramework.Controls.MetroTextBox();
            this.m_pass2 = new MetroFramework.Controls.MetroTextBox();
            this.m_info = new MetroFramework.Controls.MetroLabel();
            this.m_obavezno = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.m_ok = new MetroFramework.Controls.MetroButton();
            this.m_cancel = new MetroFramework.Controls.MetroButton();
            this.m_pass = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // l_ime
            // 
            this.l_ime.AutoSize = true;
            this.l_ime.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_ime.Location = new System.Drawing.Point(83, 191);
            this.l_ime.Name = "l_ime";
            this.l_ime.Size = new System.Drawing.Size(34, 19);
            this.l_ime.Style = MetroFramework.MetroColorStyle.Green;
            this.l_ime.TabIndex = 0;
            this.l_ime.Text = "Ime:";
            this.l_ime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_ime.UseCustomForeColor = true;
            // 
            // l_prezime
            // 
            this.l_prezime.AutoSize = true;
            this.l_prezime.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_prezime.Location = new System.Drawing.Point(83, 236);
            this.l_prezime.Name = "l_prezime";
            this.l_prezime.Size = new System.Drawing.Size(60, 19);
            this.l_prezime.Style = MetroFramework.MetroColorStyle.Green;
            this.l_prezime.TabIndex = 1;
            this.l_prezime.Text = "Prezime:";
            this.l_prezime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_prezime.UseCustomForeColor = true;
            // 
            // l_rola
            // 
            this.l_rola.AutoSize = true;
            this.l_rola.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_rola.Location = new System.Drawing.Point(83, 281);
            this.l_rola.Name = "l_rola";
            this.l_rola.Size = new System.Drawing.Size(55, 19);
            this.l_rola.Style = MetroFramework.MetroColorStyle.Green;
            this.l_rola.TabIndex = 2;
            this.l_rola.Text = "Pozicija:";
            this.l_rola.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_rola.UseCustomForeColor = true;
            this.l_rola.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // l_tel
            // 
            this.l_tel.AutoSize = true;
            this.l_tel.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_tel.Location = new System.Drawing.Point(83, 326);
            this.l_tel.Name = "l_tel";
            this.l_tel.Size = new System.Drawing.Size(53, 19);
            this.l_tel.Style = MetroFramework.MetroColorStyle.Green;
            this.l_tel.TabIndex = 3;
            this.l_tel.Text = "Telefon:";
            this.l_tel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_tel.UseCustomForeColor = true;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_email.Location = new System.Drawing.Point(83, 371);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(57, 19);
            this.l_email.Style = MetroFramework.MetroColorStyle.Green;
            this.l_email.TabIndex = 4;
            this.l_email.Text = "E-pošta:";
            this.l_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_email.UseCustomForeColor = true;
            // 
            // l_pas
            // 
            this.l_pas.AutoSize = true;
            this.l_pas.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_pas.Location = new System.Drawing.Point(83, 416);
            this.l_pas.Name = "l_pas";
            this.l_pas.Size = new System.Drawing.Size(55, 19);
            this.l_pas.Style = MetroFramework.MetroColorStyle.Green;
            this.l_pas.TabIndex = 5;
            this.l_pas.Text = "Lozinka:";
            this.l_pas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_pas.UseCustomForeColor = true;
            // 
            // l_pass2
            // 
            this.l_pass2.AutoSize = true;
            this.l_pass2.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_pass2.Location = new System.Drawing.Point(83, 461);
            this.l_pass2.Name = "l_pass2";
            this.l_pass2.Size = new System.Drawing.Size(97, 19);
            this.l_pass2.Style = MetroFramework.MetroColorStyle.Green;
            this.l_pass2.TabIndex = 6;
            this.l_pass2.Text = "Potvrdi lozinku:";
            this.l_pass2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_pass2.UseCustomForeColor = true;
            // 
            // m_ime
            // 
            // 
            // 
            // 
            this.m_ime.CustomButton.Image = null;
            this.m_ime.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_ime.CustomButton.Name = "";
            this.m_ime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_ime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_ime.CustomButton.TabIndex = 1;
            this.m_ime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_ime.CustomButton.UseSelectable = true;
            this.m_ime.CustomButton.Visible = false;
            this.m_ime.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_ime.Lines = new string[0];
            this.m_ime.Location = new System.Drawing.Point(256, 186);
            this.m_ime.MaxLength = 32767;
            this.m_ime.Name = "m_ime";
            this.m_ime.PasswordChar = '\0';
            this.m_ime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_ime.SelectedText = "";
            this.m_ime.SelectionLength = 0;
            this.m_ime.SelectionStart = 0;
            this.m_ime.ShortcutsEnabled = true;
            this.m_ime.Size = new System.Drawing.Size(268, 23);
            this.m_ime.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ime.TabIndex = 7;
            this.m_ime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ime.UseCustomForeColor = true;
            this.m_ime.UseSelectable = true;
            this.m_ime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_ime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_prezime
            // 
            // 
            // 
            // 
            this.m_prezime.CustomButton.Image = null;
            this.m_prezime.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_prezime.CustomButton.Name = "";
            this.m_prezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_prezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_prezime.CustomButton.TabIndex = 1;
            this.m_prezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_prezime.CustomButton.UseSelectable = true;
            this.m_prezime.CustomButton.Visible = false;
            this.m_prezime.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_prezime.Lines = new string[0];
            this.m_prezime.Location = new System.Drawing.Point(256, 232);
            this.m_prezime.MaxLength = 32767;
            this.m_prezime.Name = "m_prezime";
            this.m_prezime.PasswordChar = '\0';
            this.m_prezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_prezime.SelectedText = "";
            this.m_prezime.SelectionLength = 0;
            this.m_prezime.SelectionStart = 0;
            this.m_prezime.ShortcutsEnabled = true;
            this.m_prezime.Size = new System.Drawing.Size(268, 23);
            this.m_prezime.Style = MetroFramework.MetroColorStyle.Green;
            this.m_prezime.TabIndex = 8;
            this.m_prezime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_prezime.UseCustomForeColor = true;
            this.m_prezime.UseSelectable = true;
            this.m_prezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_prezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_rola
            // 
            this.m_rola.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_rola.FormattingEnabled = true;
            this.m_rola.ItemHeight = 23;
            this.m_rola.Items.AddRange(new object[] {
            "Administrator",
            "Blagajna",
            "Skladište"});
            this.m_rola.Location = new System.Drawing.Point(256, 278);
            this.m_rola.Name = "m_rola";
            this.m_rola.Size = new System.Drawing.Size(268, 29);
            this.m_rola.Style = MetroFramework.MetroColorStyle.Green;
            this.m_rola.TabIndex = 9;
            this.m_rola.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_rola.UseCustomForeColor = true;
            this.m_rola.UseSelectable = true;
            // 
            // m_tel
            // 
            // 
            // 
            // 
            this.m_tel.CustomButton.Image = null;
            this.m_tel.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_tel.CustomButton.Name = "";
            this.m_tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_tel.CustomButton.TabIndex = 1;
            this.m_tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_tel.CustomButton.UseSelectable = true;
            this.m_tel.CustomButton.Visible = false;
            this.m_tel.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_tel.Lines = new string[0];
            this.m_tel.Location = new System.Drawing.Point(256, 322);
            this.m_tel.MaxLength = 32767;
            this.m_tel.Name = "m_tel";
            this.m_tel.PasswordChar = '\0';
            this.m_tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_tel.SelectedText = "";
            this.m_tel.SelectionLength = 0;
            this.m_tel.SelectionStart = 0;
            this.m_tel.ShortcutsEnabled = true;
            this.m_tel.Size = new System.Drawing.Size(268, 23);
            this.m_tel.Style = MetroFramework.MetroColorStyle.Green;
            this.m_tel.TabIndex = 10;
            this.m_tel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_tel.UseCustomForeColor = true;
            this.m_tel.UseSelectable = true;
            this.m_tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_email
            // 
            // 
            // 
            // 
            this.m_email.CustomButton.Image = null;
            this.m_email.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_email.CustomButton.Name = "";
            this.m_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_email.CustomButton.TabIndex = 1;
            this.m_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_email.CustomButton.UseSelectable = true;
            this.m_email.CustomButton.Visible = false;
            this.m_email.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_email.Lines = new string[0];
            this.m_email.Location = new System.Drawing.Point(256, 367);
            this.m_email.MaxLength = 32767;
            this.m_email.Name = "m_email";
            this.m_email.PasswordChar = '\0';
            this.m_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_email.SelectedText = "";
            this.m_email.SelectionLength = 0;
            this.m_email.SelectionStart = 0;
            this.m_email.ShortcutsEnabled = true;
            this.m_email.Size = new System.Drawing.Size(268, 23);
            this.m_email.Style = MetroFramework.MetroColorStyle.Green;
            this.m_email.TabIndex = 11;
            this.m_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_email.UseCustomForeColor = true;
            this.m_email.UseSelectable = true;
            this.m_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_pass2
            // 
            // 
            // 
            // 
            this.m_pass2.CustomButton.Image = null;
            this.m_pass2.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_pass2.CustomButton.Name = "";
            this.m_pass2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_pass2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_pass2.CustomButton.TabIndex = 1;
            this.m_pass2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_pass2.CustomButton.UseSelectable = true;
            this.m_pass2.CustomButton.Visible = false;
            this.m_pass2.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_pass2.Lines = new string[0];
            this.m_pass2.Location = new System.Drawing.Point(256, 457);
            this.m_pass2.MaxLength = 32767;
            this.m_pass2.Name = "m_pass2";
            this.m_pass2.PasswordChar = '\0';
            this.m_pass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_pass2.SelectedText = "";
            this.m_pass2.SelectionLength = 0;
            this.m_pass2.SelectionStart = 0;
            this.m_pass2.ShortcutsEnabled = true;
            this.m_pass2.Size = new System.Drawing.Size(268, 23);
            this.m_pass2.Style = MetroFramework.MetroColorStyle.Green;
            this.m_pass2.TabIndex = 13;
            this.m_pass2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_pass2.UseCustomForeColor = true;
            this.m_pass2.UseSelectable = true;
            this.m_pass2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_pass2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_info
            // 
            this.m_info.AutoSize = true;
            this.m_info.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_info.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_info.Location = new System.Drawing.Point(83, 97);
            this.m_info.Name = "m_info";
            this.m_info.Size = new System.Drawing.Size(258, 25);
            this.m_info.Style = MetroFramework.MetroColorStyle.Green;
            this.m_info.TabIndex = 14;
            this.m_info.Text = "Unesite podatke novog korisnika";
            this.m_info.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_info.UseCustomForeColor = true;
            // 
            // m_obavezno
            // 
            this.m_obavezno.AutoSize = true;
            this.m_obavezno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_obavezno.ForeColor = System.Drawing.Color.Red;
            this.m_obavezno.Location = new System.Drawing.Point(83, 520);
            this.m_obavezno.Name = "m_obavezno";
            this.m_obavezno.Size = new System.Drawing.Size(139, 25);
            this.m_obavezno.Style = MetroFramework.MetroColorStyle.Green;
            this.m_obavezno.TabIndex = 15;
            this.m_obavezno.Text = "* obavezna polja";
            this.m_obavezno.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_obavezno.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(235, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "*";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(235, 232);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(15, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "*";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(235, 278);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(15, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "*";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(235, 412);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(15, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "*";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(235, 457);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(15, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "*";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // m_ok
            // 
            this.m_ok.BackColor = System.Drawing.Color.LimeGreen;
            this.m_ok.Location = new System.Drawing.Point(764, 249);
            this.m_ok.Name = "m_ok";
            this.m_ok.Size = new System.Drawing.Size(125, 48);
            this.m_ok.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ok.TabIndex = 21;
            this.m_ok.Text = "Potvrdi";
            this.m_ok.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ok.UseCustomBackColor = true;
            this.m_ok.UseCustomForeColor = true;
            this.m_ok.UseSelectable = true;
            this.m_ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // m_cancel
            // 
            this.m_cancel.BackColor = System.Drawing.Color.LimeGreen;
            this.m_cancel.Location = new System.Drawing.Point(764, 341);
            this.m_cancel.Name = "m_cancel";
            this.m_cancel.Size = new System.Drawing.Size(125, 49);
            this.m_cancel.Style = MetroFramework.MetroColorStyle.Green;
            this.m_cancel.TabIndex = 22;
            this.m_cancel.Text = "Natrag/Otkaži";
            this.m_cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cancel.UseCustomBackColor = true;
            this.m_cancel.UseCustomForeColor = true;
            this.m_cancel.UseSelectable = true;
            this.m_cancel.Click += new System.EventHandler(this.m_cancel_Click);
            // 
            // m_pass
            // 
            // 
            // 
            // 
            this.m_pass.CustomButton.Image = null;
            this.m_pass.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_pass.CustomButton.Name = "";
            this.m_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_pass.CustomButton.TabIndex = 1;
            this.m_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_pass.CustomButton.UseSelectable = true;
            this.m_pass.CustomButton.Visible = false;
            this.m_pass.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_pass.Lines = new string[0];
            this.m_pass.Location = new System.Drawing.Point(256, 412);
            this.m_pass.MaxLength = 32767;
            this.m_pass.Name = "m_pass";
            this.m_pass.PasswordChar = '\0';
            this.m_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_pass.SelectedText = "";
            this.m_pass.SelectionLength = 0;
            this.m_pass.SelectionStart = 0;
            this.m_pass.ShortcutsEnabled = true;
            this.m_pass.Size = new System.Drawing.Size(268, 23);
            this.m_pass.Style = MetroFramework.MetroColorStyle.Green;
            this.m_pass.TabIndex = 12;
            this.m_pass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_pass.UseCustomForeColor = true;
            this.m_pass.UseSelectable = true;
            this.m_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Useri_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.m_cancel);
            this.Controls.Add(this.m_ok);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.m_obavezno);
            this.Controls.Add(this.m_info);
            this.Controls.Add(this.m_pass2);
            this.Controls.Add(this.m_pass);
            this.Controls.Add(this.m_email);
            this.Controls.Add(this.m_tel);
            this.Controls.Add(this.m_rola);
            this.Controls.Add(this.m_prezime);
            this.Controls.Add(this.m_ime);
            this.Controls.Add(this.l_pass2);
            this.Controls.Add(this.l_pas);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_tel);
            this.Controls.Add(this.l_rola);
            this.Controls.Add(this.l_prezime);
            this.Controls.Add(this.l_ime);
            this.Name = "Useri_dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Dodaj korisnika";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Useri_dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel l_ime;
        private MetroFramework.Controls.MetroLabel l_prezime;
        private MetroFramework.Controls.MetroLabel l_rola;
        private MetroFramework.Controls.MetroLabel l_tel;
        private MetroFramework.Controls.MetroLabel l_email;
        private MetroFramework.Controls.MetroLabel l_pas;
        private MetroFramework.Controls.MetroLabel l_pass2;
        private MetroFramework.Controls.MetroLabel m_info;
        private MetroFramework.Controls.MetroLabel m_obavezno;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton m_ok;
        private MetroFramework.Controls.MetroButton m_cancel;
        public MetroFramework.Controls.MetroTextBox m_ime;
        public MetroFramework.Controls.MetroTextBox m_prezime;
        public MetroFramework.Controls.MetroComboBox m_rola;
        public MetroFramework.Controls.MetroTextBox m_tel;
        public MetroFramework.Controls.MetroTextBox m_email;
        public MetroFramework.Controls.MetroTextBox m_pass2;
        public MetroFramework.Controls.MetroTextBox m_pass;
    }
}