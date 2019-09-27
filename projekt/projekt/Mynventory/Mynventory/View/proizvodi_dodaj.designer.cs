namespace Mynventory.View
{
    partial class Proizvodi_dodaj
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.m_naziv = new MetroFramework.Controls.MetroTextBox();
            this.l_naziv = new MetroFramework.Controls.MetroLabel();
            this.l_mjerna = new MetroFramework.Controls.MetroLabel();
            this.l_cijena = new MetroFramework.Controls.MetroLabel();
            this.l_kolicina = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.l_dobavljac = new MetroFramework.Controls.MetroLabel();
            this.m_obavezno = new MetroFramework.Controls.MetroLabel();
            this.m_info = new MetroFramework.Controls.MetroLabel();
            this.m_cijena = new MetroFramework.Controls.MetroTextBox();
            this.m_kolicina = new MetroFramework.Controls.MetroTextBox();
            this.m_ps = new MetroFramework.Controls.MetroTextBox();
            this.m_dobavljac = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.m_cancel_pro = new MetroFramework.Controls.MetroButton();
            this.m_ok = new MetroFramework.Controls.MetroButton();
            this.c_mj = new MetroFramework.Controls.MetroComboBox();
            this.datum_info = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.m_dzp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(262, 239);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(15, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "*";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // m_naziv
            // 
            // 
            // 
            // 
            this.m_naziv.CustomButton.Image = null;
            this.m_naziv.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_naziv.CustomButton.Name = "";
            this.m_naziv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_naziv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_naziv.CustomButton.TabIndex = 1;
            this.m_naziv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_naziv.CustomButton.UseSelectable = true;
            this.m_naziv.CustomButton.Visible = false;
            this.m_naziv.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_naziv.Lines = new string[0];
            this.m_naziv.Location = new System.Drawing.Point(283, 235);
            this.m_naziv.MaxLength = 32767;
            this.m_naziv.Name = "m_naziv";
            this.m_naziv.PasswordChar = '\0';
            this.m_naziv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_naziv.SelectedText = "";
            this.m_naziv.SelectionLength = 0;
            this.m_naziv.SelectionStart = 0;
            this.m_naziv.ShortcutsEnabled = true;
            this.m_naziv.Size = new System.Drawing.Size(268, 23);
            this.m_naziv.Style = MetroFramework.MetroColorStyle.Green;
            this.m_naziv.TabIndex = 18;
            this.m_naziv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_naziv.UseCustomForeColor = true;
            this.m_naziv.UseSelectable = true;
            this.m_naziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_naziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.m_naziv.Click += new System.EventHandler(this.m_ime_Click);
            // 
            // l_naziv
            // 
            this.l_naziv.AutoSize = true;
            this.l_naziv.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_naziv.Location = new System.Drawing.Point(75, 239);
            this.l_naziv.Name = "l_naziv";
            this.l_naziv.Size = new System.Drawing.Size(44, 19);
            this.l_naziv.Style = MetroFramework.MetroColorStyle.Green;
            this.l_naziv.TabIndex = 17;
            this.l_naziv.Text = "Naziv:";
            this.l_naziv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_naziv.UseCustomForeColor = true;
            this.l_naziv.Click += new System.EventHandler(this.l_ime_Click);
            // 
            // l_mjerna
            // 
            this.l_mjerna.AutoSize = true;
            this.l_mjerna.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_mjerna.Location = new System.Drawing.Point(75, 278);
            this.l_mjerna.Name = "l_mjerna";
            this.l_mjerna.Size = new System.Drawing.Size(101, 19);
            this.l_mjerna.Style = MetroFramework.MetroColorStyle.Green;
            this.l_mjerna.TabIndex = 20;
            this.l_mjerna.Text = "Mjerna jedinica:";
            this.l_mjerna.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_mjerna.UseCustomForeColor = true;
            // 
            // l_cijena
            // 
            this.l_cijena.AutoSize = true;
            this.l_cijena.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_cijena.Location = new System.Drawing.Point(75, 317);
            this.l_cijena.Name = "l_cijena";
            this.l_cijena.Size = new System.Drawing.Size(48, 19);
            this.l_cijena.Style = MetroFramework.MetroColorStyle.Green;
            this.l_cijena.TabIndex = 21;
            this.l_cijena.Text = "Cijena:";
            this.l_cijena.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_cijena.UseCustomForeColor = true;
            // 
            // l_kolicina
            // 
            this.l_kolicina.AutoSize = true;
            this.l_kolicina.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_kolicina.Location = new System.Drawing.Point(75, 356);
            this.l_kolicina.Name = "l_kolicina";
            this.l_kolicina.Size = new System.Drawing.Size(56, 19);
            this.l_kolicina.Style = MetroFramework.MetroColorStyle.Green;
            this.l_kolicina.TabIndex = 22;
            this.l_kolicina.Text = "Količina:";
            this.l_kolicina.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_kolicina.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel1.Location = new System.Drawing.Point(75, 395);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Porezna stopa:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // l_dobavljac
            // 
            this.l_dobavljac.AutoSize = true;
            this.l_dobavljac.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_dobavljac.Location = new System.Drawing.Point(75, 473);
            this.l_dobavljac.Name = "l_dobavljac";
            this.l_dobavljac.Size = new System.Drawing.Size(66, 19);
            this.l_dobavljac.Style = MetroFramework.MetroColorStyle.Green;
            this.l_dobavljac.TabIndex = 25;
            this.l_dobavljac.Text = "Dobavljač";
            this.l_dobavljac.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_dobavljac.UseCustomForeColor = true;
            // 
            // m_obavezno
            // 
            this.m_obavezno.AutoSize = true;
            this.m_obavezno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_obavezno.ForeColor = System.Drawing.Color.Red;
            this.m_obavezno.Location = new System.Drawing.Point(75, 539);
            this.m_obavezno.Name = "m_obavezno";
            this.m_obavezno.Size = new System.Drawing.Size(139, 25);
            this.m_obavezno.Style = MetroFramework.MetroColorStyle.Green;
            this.m_obavezno.TabIndex = 26;
            this.m_obavezno.Text = "* obavezna polja";
            this.m_obavezno.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_obavezno.UseCustomForeColor = true;
            // 
            // m_info
            // 
            this.m_info.AutoSize = true;
            this.m_info.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_info.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_info.Location = new System.Drawing.Point(75, 141);
            this.m_info.Name = "m_info";
            this.m_info.Size = new System.Drawing.Size(256, 25);
            this.m_info.Style = MetroFramework.MetroColorStyle.Green;
            this.m_info.TabIndex = 27;
            this.m_info.Text = "Unesite detalje novog proizvoda";
            this.m_info.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_info.UseCustomForeColor = true;
            // 
            // m_cijena
            // 
            // 
            // 
            // 
            this.m_cijena.CustomButton.Image = null;
            this.m_cijena.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_cijena.CustomButton.Name = "";
            this.m_cijena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_cijena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_cijena.CustomButton.TabIndex = 1;
            this.m_cijena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_cijena.CustomButton.UseSelectable = true;
            this.m_cijena.CustomButton.Visible = false;
            this.m_cijena.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_cijena.Lines = new string[0];
            this.m_cijena.Location = new System.Drawing.Point(283, 313);
            this.m_cijena.MaxLength = 32767;
            this.m_cijena.Name = "m_cijena";
            this.m_cijena.PasswordChar = '\0';
            this.m_cijena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_cijena.SelectedText = "";
            this.m_cijena.SelectionLength = 0;
            this.m_cijena.SelectionStart = 0;
            this.m_cijena.ShortcutsEnabled = true;
            this.m_cijena.Size = new System.Drawing.Size(268, 23);
            this.m_cijena.Style = MetroFramework.MetroColorStyle.Green;
            this.m_cijena.TabIndex = 29;
            this.m_cijena.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cijena.UseCustomForeColor = true;
            this.m_cijena.UseSelectable = true;
            this.m_cijena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_cijena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_kolicina
            // 
            // 
            // 
            // 
            this.m_kolicina.CustomButton.Image = null;
            this.m_kolicina.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_kolicina.CustomButton.Name = "";
            this.m_kolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_kolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_kolicina.CustomButton.TabIndex = 1;
            this.m_kolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_kolicina.CustomButton.UseSelectable = true;
            this.m_kolicina.CustomButton.Visible = false;
            this.m_kolicina.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_kolicina.Lines = new string[0];
            this.m_kolicina.Location = new System.Drawing.Point(283, 352);
            this.m_kolicina.MaxLength = 32767;
            this.m_kolicina.Name = "m_kolicina";
            this.m_kolicina.PasswordChar = '\0';
            this.m_kolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_kolicina.SelectedText = "";
            this.m_kolicina.SelectionLength = 0;
            this.m_kolicina.SelectionStart = 0;
            this.m_kolicina.ShortcutsEnabled = true;
            this.m_kolicina.Size = new System.Drawing.Size(268, 23);
            this.m_kolicina.Style = MetroFramework.MetroColorStyle.Green;
            this.m_kolicina.TabIndex = 30;
            this.m_kolicina.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_kolicina.UseCustomForeColor = true;
            this.m_kolicina.UseSelectable = true;
            this.m_kolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_kolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_ps
            // 
            // 
            // 
            // 
            this.m_ps.CustomButton.Image = null;
            this.m_ps.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_ps.CustomButton.Name = "";
            this.m_ps.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_ps.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_ps.CustomButton.TabIndex = 1;
            this.m_ps.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_ps.CustomButton.UseSelectable = true;
            this.m_ps.CustomButton.Visible = false;
            this.m_ps.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_ps.Lines = new string[0];
            this.m_ps.Location = new System.Drawing.Point(283, 391);
            this.m_ps.MaxLength = 32767;
            this.m_ps.Name = "m_ps";
            this.m_ps.PasswordChar = '\0';
            this.m_ps.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_ps.SelectedText = "";
            this.m_ps.SelectionLength = 0;
            this.m_ps.SelectionStart = 0;
            this.m_ps.ShortcutsEnabled = true;
            this.m_ps.Size = new System.Drawing.Size(268, 23);
            this.m_ps.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ps.TabIndex = 31;
            this.m_ps.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ps.UseCustomForeColor = true;
            this.m_ps.UseSelectable = true;
            this.m_ps.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_ps.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_dobavljac
            // 
            // 
            // 
            // 
            this.m_dobavljac.CustomButton.Image = null;
            this.m_dobavljac.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_dobavljac.CustomButton.Name = "";
            this.m_dobavljac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_dobavljac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_dobavljac.CustomButton.TabIndex = 1;
            this.m_dobavljac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_dobavljac.CustomButton.UseSelectable = true;
            this.m_dobavljac.CustomButton.Visible = false;
            this.m_dobavljac.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_dobavljac.Lines = new string[0];
            this.m_dobavljac.Location = new System.Drawing.Point(283, 469);
            this.m_dobavljac.MaxLength = 32767;
            this.m_dobavljac.Name = "m_dobavljac";
            this.m_dobavljac.PasswordChar = '\0';
            this.m_dobavljac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_dobavljac.SelectedText = "";
            this.m_dobavljac.SelectionLength = 0;
            this.m_dobavljac.SelectionStart = 0;
            this.m_dobavljac.ShortcutsEnabled = true;
            this.m_dobavljac.Size = new System.Drawing.Size(268, 23);
            this.m_dobavljac.Style = MetroFramework.MetroColorStyle.Green;
            this.m_dobavljac.TabIndex = 33;
            this.m_dobavljac.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_dobavljac.UseCustomForeColor = true;
            this.m_dobavljac.UseSelectable = true;
            this.m_dobavljac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_dobavljac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(262, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(15, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "*";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Red;
            this.metroLabel5.Location = new System.Drawing.Point(262, 317);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(15, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "*";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Red;
            this.metroLabel6.Location = new System.Drawing.Point(262, 356);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(15, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "*";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.Red;
            this.metroLabel7.Location = new System.Drawing.Point(262, 395);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(15, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "*";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.Red;
            this.metroLabel9.Location = new System.Drawing.Point(262, 473);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(15, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "*";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // m_cancel_pro
            // 
            this.m_cancel_pro.BackColor = System.Drawing.Color.LimeGreen;
            this.m_cancel_pro.Location = new System.Drawing.Point(801, 366);
            this.m_cancel_pro.Name = "m_cancel_pro";
            this.m_cancel_pro.Size = new System.Drawing.Size(125, 49);
            this.m_cancel_pro.Style = MetroFramework.MetroColorStyle.Green;
            this.m_cancel_pro.TabIndex = 41;
            this.m_cancel_pro.Text = "Natrag/Otkaži";
            this.m_cancel_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cancel_pro.UseCustomBackColor = true;
            this.m_cancel_pro.UseCustomForeColor = true;
            this.m_cancel_pro.UseSelectable = true;
            this.m_cancel_pro.Click += new System.EventHandler(this.m_cancel_pro_Click);
            // 
            // m_ok
            // 
            this.m_ok.BackColor = System.Drawing.Color.LimeGreen;
            this.m_ok.Location = new System.Drawing.Point(801, 274);
            this.m_ok.Name = "m_ok";
            this.m_ok.Size = new System.Drawing.Size(125, 48);
            this.m_ok.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ok.TabIndex = 40;
            this.m_ok.Text = "Potvrdi";
            this.m_ok.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ok.UseCustomBackColor = true;
            this.m_ok.UseCustomForeColor = true;
            this.m_ok.UseSelectable = true;
            this.m_ok.Click += new System.EventHandler(this.m_ok_Click);
            // 
            // c_mj
            // 
            this.c_mj.FormattingEnabled = true;
            this.c_mj.ItemHeight = 23;
            this.c_mj.Items.AddRange(new object[] {
            "gram",
            "metar",
            "litra",
            "komad"});
            this.c_mj.Location = new System.Drawing.Point(283, 268);
            this.c_mj.Name = "c_mj";
            this.c_mj.Size = new System.Drawing.Size(268, 29);
            this.c_mj.Style = MetroFramework.MetroColorStyle.Green;
            this.c_mj.TabIndex = 42;
            this.c_mj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.c_mj.UseSelectable = true;
            // 
            // datum_info
            // 
            this.datum_info.OwnerDraw = true;
            // 
            // m_dzp
            // 
            // 
            // 
            // 
            this.m_dzp.CustomButton.Image = null;
            this.m_dzp.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_dzp.CustomButton.Name = "";
            this.m_dzp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_dzp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_dzp.CustomButton.TabIndex = 1;
            this.m_dzp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_dzp.CustomButton.UseSelectable = true;
            this.m_dzp.CustomButton.Visible = false;
            this.m_dzp.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_dzp.Lines = new string[0];
            this.m_dzp.Location = new System.Drawing.Point(283, 430);
            this.m_dzp.MaxLength = 32767;
            this.m_dzp.Name = "m_dzp";
            this.m_dzp.PasswordChar = '\0';
            this.m_dzp.PromptText = "GGGG-MM-DD";
            this.m_dzp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_dzp.SelectedText = "";
            this.m_dzp.SelectionLength = 0;
            this.m_dzp.SelectionStart = 0;
            this.m_dzp.ShortcutsEnabled = true;
            this.m_dzp.Size = new System.Drawing.Size(268, 23);
            this.m_dzp.Style = MetroFramework.MetroColorStyle.Green;
            this.m_dzp.TabIndex = 43;
            this.m_dzp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.datum_info.SetToolTip(this.m_dzp, "Unesi u formatu GGGG-MM-DD");
            this.m_dzp.UseCustomForeColor = true;
            this.m_dzp.UseSelectable = true;
            this.m_dzp.WaterMark = "GGGG-MM-DD";
            this.m_dzp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_dzp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel3.Location = new System.Drawing.Point(75, 434);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Datum zadnje prodaje:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // Proizvodi_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.m_dzp);
            this.Controls.Add(this.c_mj);
            this.Controls.Add(this.m_cancel_pro);
            this.Controls.Add(this.m_ok);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.m_dobavljac);
            this.Controls.Add(this.m_ps);
            this.Controls.Add(this.m_kolicina);
            this.Controls.Add(this.m_cijena);
            this.Controls.Add(this.m_info);
            this.Controls.Add(this.m_obavezno);
            this.Controls.Add(this.l_dobavljac);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.l_kolicina);
            this.Controls.Add(this.l_cijena);
            this.Controls.Add(this.l_mjerna);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.m_naziv);
            this.Controls.Add(this.l_naziv);
            this.Name = "Proizvodi_dodaj";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory: Dodaj proizvod";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Proizvodi_dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox m_naziv;
        private MetroFramework.Controls.MetroLabel l_naziv;
        private MetroFramework.Controls.MetroLabel l_mjerna;
        private MetroFramework.Controls.MetroLabel l_cijena;
        private MetroFramework.Controls.MetroLabel l_kolicina;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel l_dobavljac;
        private MetroFramework.Controls.MetroLabel m_obavezno;
        private MetroFramework.Controls.MetroLabel m_info;
        public MetroFramework.Controls.MetroTextBox m_cijena;
        public MetroFramework.Controls.MetroTextBox m_kolicina;
        public MetroFramework.Controls.MetroTextBox m_ps;
        public MetroFramework.Controls.MetroTextBox m_dobavljac;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton m_cancel_pro;
        private MetroFramework.Controls.MetroButton m_ok;
        private MetroFramework.Controls.MetroComboBox c_mj;
        private MetroFramework.Drawing.Html.HtmlToolTip datum_info;
        public MetroFramework.Controls.MetroTextBox m_dzp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}