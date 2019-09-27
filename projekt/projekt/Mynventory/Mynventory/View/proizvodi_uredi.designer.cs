namespace Mynventory.View
{
    partial class Proizvodi_uredi
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
            this.c_mj = new MetroFramework.Controls.MetroComboBox();
            this.m_cancel_pro = new MetroFramework.Controls.MetroButton();
            this.m_ok_pro = new MetroFramework.Controls.MetroButton();
            this.m_dobavljac = new MetroFramework.Controls.MetroTextBox();
            this.m_ps = new MetroFramework.Controls.MetroTextBox();
            this.m_kolicina = new MetroFramework.Controls.MetroTextBox();
            this.m_cijena = new MetroFramework.Controls.MetroTextBox();
            this.m_info = new MetroFramework.Controls.MetroLabel();
            this.l_dobavljac = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.l_kolicina = new MetroFramework.Controls.MetroLabel();
            this.l_cijena = new MetroFramework.Controls.MetroLabel();
            this.l_mjerna = new MetroFramework.Controls.MetroLabel();
            this.m_naziv = new MetroFramework.Controls.MetroTextBox();
            this.l_naziv = new MetroFramework.Controls.MetroLabel();
            this.m_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
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
            this.c_mj.Location = new System.Drawing.Point(282, 288);
            this.c_mj.Name = "c_mj";
            this.c_mj.Size = new System.Drawing.Size(268, 29);
            this.c_mj.Style = MetroFramework.MetroColorStyle.Green;
            this.c_mj.TabIndex = 59;
            this.c_mj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.c_mj.UseSelectable = true;
            // 
            // m_cancel_pro
            // 
            this.m_cancel_pro.BackColor = System.Drawing.Color.LimeGreen;
            this.m_cancel_pro.Location = new System.Drawing.Point(800, 384);
            this.m_cancel_pro.Name = "m_cancel_pro";
            this.m_cancel_pro.Size = new System.Drawing.Size(125, 49);
            this.m_cancel_pro.Style = MetroFramework.MetroColorStyle.Green;
            this.m_cancel_pro.TabIndex = 58;
            this.m_cancel_pro.Text = "Natrag/Otkaži";
            this.m_cancel_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cancel_pro.UseCustomBackColor = true;
            this.m_cancel_pro.UseCustomForeColor = true;
            this.m_cancel_pro.UseSelectable = true;
            this.m_cancel_pro.Click += new System.EventHandler(this.m_cancel_pro_Click);
            // 
            // m_ok_pro
            // 
            this.m_ok_pro.BackColor = System.Drawing.Color.LimeGreen;
            this.m_ok_pro.Location = new System.Drawing.Point(800, 292);
            this.m_ok_pro.Name = "m_ok_pro";
            this.m_ok_pro.Size = new System.Drawing.Size(125, 48);
            this.m_ok_pro.Style = MetroFramework.MetroColorStyle.Green;
            this.m_ok_pro.TabIndex = 57;
            this.m_ok_pro.Text = "Potvrdi";
            this.m_ok_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ok_pro.UseCustomBackColor = true;
            this.m_ok_pro.UseCustomForeColor = true;
            this.m_ok_pro.UseSelectable = true;
            this.m_ok_pro.Click += new System.EventHandler(this.m_ok_pro_Click_1);
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
            this.m_dobavljac.Location = new System.Drawing.Point(282, 458);
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
            this.m_dobavljac.TabIndex = 56;
            this.m_dobavljac.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_dobavljac.UseCustomForeColor = true;
            this.m_dobavljac.UseSelectable = true;
            this.m_dobavljac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_dobavljac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.m_ps.Location = new System.Drawing.Point(282, 417);
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
            this.m_ps.TabIndex = 55;
            this.m_ps.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_ps.UseCustomForeColor = true;
            this.m_ps.UseSelectable = true;
            this.m_ps.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_ps.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.m_kolicina.Location = new System.Drawing.Point(282, 376);
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
            this.m_kolicina.TabIndex = 54;
            this.m_kolicina.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_kolicina.UseCustomForeColor = true;
            this.m_kolicina.UseSelectable = true;
            this.m_kolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_kolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.m_cijena.Location = new System.Drawing.Point(282, 335);
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
            this.m_cijena.TabIndex = 53;
            this.m_cijena.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_cijena.UseCustomForeColor = true;
            this.m_cijena.UseSelectable = true;
            this.m_cijena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_cijena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // m_info
            // 
            this.m_info.AutoSize = true;
            this.m_info.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.m_info.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_info.Location = new System.Drawing.Point(74, 159);
            this.m_info.Name = "m_info";
            this.m_info.Size = new System.Drawing.Size(291, 25);
            this.m_info.Style = MetroFramework.MetroColorStyle.Green;
            this.m_info.TabIndex = 52;
            this.m_info.Text = "Uredite detalje odabranog proizvoda";
            this.m_info.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_info.UseCustomForeColor = true;
            // 
            // l_dobavljac
            // 
            this.l_dobavljac.AutoSize = true;
            this.l_dobavljac.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_dobavljac.Location = new System.Drawing.Point(74, 462);
            this.l_dobavljac.Name = "l_dobavljac";
            this.l_dobavljac.Size = new System.Drawing.Size(66, 19);
            this.l_dobavljac.Style = MetroFramework.MetroColorStyle.Green;
            this.l_dobavljac.TabIndex = 51;
            this.l_dobavljac.Text = "Dobavljač";
            this.l_dobavljac.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_dobavljac.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel1.Location = new System.Drawing.Point(74, 421);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Porezna stopa:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // l_kolicina
            // 
            this.l_kolicina.AutoSize = true;
            this.l_kolicina.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_kolicina.Location = new System.Drawing.Point(74, 380);
            this.l_kolicina.Name = "l_kolicina";
            this.l_kolicina.Size = new System.Drawing.Size(56, 19);
            this.l_kolicina.Style = MetroFramework.MetroColorStyle.Green;
            this.l_kolicina.TabIndex = 48;
            this.l_kolicina.Text = "Količina:";
            this.l_kolicina.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_kolicina.UseCustomForeColor = true;
            // 
            // l_cijena
            // 
            this.l_cijena.AutoSize = true;
            this.l_cijena.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_cijena.Location = new System.Drawing.Point(74, 339);
            this.l_cijena.Name = "l_cijena";
            this.l_cijena.Size = new System.Drawing.Size(48, 19);
            this.l_cijena.Style = MetroFramework.MetroColorStyle.Green;
            this.l_cijena.TabIndex = 47;
            this.l_cijena.Text = "Cijena:";
            this.l_cijena.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_cijena.UseCustomForeColor = true;
            // 
            // l_mjerna
            // 
            this.l_mjerna.AutoSize = true;
            this.l_mjerna.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_mjerna.Location = new System.Drawing.Point(74, 298);
            this.l_mjerna.Name = "l_mjerna";
            this.l_mjerna.Size = new System.Drawing.Size(101, 19);
            this.l_mjerna.Style = MetroFramework.MetroColorStyle.Green;
            this.l_mjerna.TabIndex = 46;
            this.l_mjerna.Text = "Mjerna jedinica:";
            this.l_mjerna.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_mjerna.UseCustomForeColor = true;
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
            this.m_naziv.Location = new System.Drawing.Point(282, 253);
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
            this.m_naziv.TabIndex = 45;
            this.m_naziv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_naziv.UseCustomForeColor = true;
            this.m_naziv.UseSelectable = true;
            this.m_naziv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_naziv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // l_naziv
            // 
            this.l_naziv.AutoSize = true;
            this.l_naziv.ForeColor = System.Drawing.Color.LawnGreen;
            this.l_naziv.Location = new System.Drawing.Point(74, 257);
            this.l_naziv.Name = "l_naziv";
            this.l_naziv.Size = new System.Drawing.Size(44, 19);
            this.l_naziv.Style = MetroFramework.MetroColorStyle.Green;
            this.l_naziv.TabIndex = 44;
            this.l_naziv.Text = "Naziv:";
            this.l_naziv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.l_naziv.UseCustomForeColor = true;
            // 
            // m_id
            // 
            // 
            // 
            // 
            this.m_id.CustomButton.Image = null;
            this.m_id.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.m_id.CustomButton.Name = "";
            this.m_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.m_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.m_id.CustomButton.TabIndex = 1;
            this.m_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.m_id.CustomButton.UseSelectable = true;
            this.m_id.CustomButton.Visible = false;
            this.m_id.ForeColor = System.Drawing.Color.LawnGreen;
            this.m_id.Lines = new string[0];
            this.m_id.Location = new System.Drawing.Point(282, 211);
            this.m_id.MaxLength = 32767;
            this.m_id.Name = "m_id";
            this.m_id.PasswordChar = '\0';
            this.m_id.ReadOnly = true;
            this.m_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m_id.SelectedText = "";
            this.m_id.SelectionLength = 0;
            this.m_id.SelectionStart = 0;
            this.m_id.ShortcutsEnabled = true;
            this.m_id.Size = new System.Drawing.Size(268, 23);
            this.m_id.Style = MetroFramework.MetroColorStyle.Green;
            this.m_id.TabIndex = 61;
            this.m_id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m_id.UseCustomForeColor = true;
            this.m_id.UseSelectable = true;
            this.m_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.m_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.LawnGreen;
            this.metroLabel2.Location = new System.Drawing.Point(74, 215);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(24, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // Proizvodi_uredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.m_id);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.c_mj);
            this.Controls.Add(this.m_cancel_pro);
            this.Controls.Add(this.m_ok_pro);
            this.Controls.Add(this.m_dobavljac);
            this.Controls.Add(this.m_ps);
            this.Controls.Add(this.m_kolicina);
            this.Controls.Add(this.m_cijena);
            this.Controls.Add(this.m_info);
            this.Controls.Add(this.l_dobavljac);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.l_kolicina);
            this.Controls.Add(this.l_cijena);
            this.Controls.Add(this.l_mjerna);
            this.Controls.Add(this.m_naziv);
            this.Controls.Add(this.l_naziv);
            this.Name = "Proizvodi_uredi";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory : Uredi proizvod";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Proizvodi_uredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton m_cancel_pro;
        private MetroFramework.Controls.MetroButton m_ok_pro;
        public MetroFramework.Controls.MetroTextBox m_dobavljac;
        public MetroFramework.Controls.MetroTextBox m_ps;
        public MetroFramework.Controls.MetroTextBox m_kolicina;
        public MetroFramework.Controls.MetroTextBox m_cijena;
        private MetroFramework.Controls.MetroLabel m_info;
        private MetroFramework.Controls.MetroLabel l_dobavljac;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel l_kolicina;
        private MetroFramework.Controls.MetroLabel l_cijena;
        private MetroFramework.Controls.MetroLabel l_mjerna;
        public MetroFramework.Controls.MetroTextBox m_naziv;
        private MetroFramework.Controls.MetroLabel l_naziv;
        public MetroFramework.Controls.MetroTextBox m_id;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox c_mj;
    }
}