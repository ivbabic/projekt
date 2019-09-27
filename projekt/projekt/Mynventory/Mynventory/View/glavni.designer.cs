namespace Mynventory.View
{
    partial class Glavni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni));
            this.odjava_info = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.odjava = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Datum = new MetroFramework.Controls.MetroTile();
            this.t_transakcije = new MetroFramework.Controls.MetroTile();
            this.t_obavijesti = new MetroFramework.Controls.MetroTile();
            this.t_izvjestaji = new MetroFramework.Controls.MetroTile();
            this.t_proizvodi = new MetroFramework.Controls.MetroTile();
            this.t_narudzba = new MetroFramework.Controls.MetroTile();
            this.t_racun = new MetroFramework.Controls.MetroTile();
            this.t_dobavljaci = new MetroFramework.Controls.MetroTile();
            this.Vrijeme = new MetroFramework.Controls.MetroTile();
            this.t_korisnici = new MetroFramework.Controls.MetroTile();
            this.MyNventory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odjava)).BeginInit();
            this.SuspendLayout();
            // 
            // odjava_info
            // 
            this.odjava_info.BackColor = System.Drawing.SystemColors.Desktop;
            this.odjava_info.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.odjava_info.OwnerDraw = true;
            this.odjava_info.ToolTipTitle = "Izlaz iz aplikacije";
            this.odjava_info.UseFading = false;
            // 
            // odjava
            // 
            this.odjava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("odjava.BackgroundImage")));
            this.odjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.odjava.Location = new System.Drawing.Point(1157, 61);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(100, 73);
            this.odjava.TabIndex = 33;
            this.odjava.TabStop = false;
            this.odjava_info.SetToolTip(this.odjava, "Izlaz iz aplikacije");
            this.odjava.Click += new System.EventHandler(this.Odjava_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Datum
            // 
            this.Datum.ActiveControl = null;
            this.Datum.BackColor = System.Drawing.Color.DarkRed;
            this.Datum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Datum.Location = new System.Drawing.Point(1108, 373);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(203, 59);
            this.Datum.TabIndex = 32;
            this.Datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Datum.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Datum.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Datum.UseCustomBackColor = true;
            this.Datum.UseCustomForeColor = true;
            this.Datum.UseSelectable = true;
            this.Datum.UseStyleColors = true;
            // 
            // t_transakcije
            // 
            this.t_transakcije.ActiveControl = null;
            this.t_transakcije.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_transakcije.BackColor = System.Drawing.Color.Peru;
            this.t_transakcije.Location = new System.Drawing.Point(613, 356);
            this.t_transakcije.Name = "t_transakcije";
            this.t_transakcije.Size = new System.Drawing.Size(416, 180);
            this.t_transakcije.TabIndex = 23;
            this.t_transakcije.Text = "Transakcije";
            this.t_transakcije.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_transakcije.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_transakcije.TileImage = ((System.Drawing.Image)(resources.GetObject("t_transakcije.TileImage")));
            this.t_transakcije.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_transakcije.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_transakcije.UseCustomBackColor = true;
            this.t_transakcije.UseCustomForeColor = true;
            this.t_transakcije.UseSelectable = true;
            this.t_transakcije.UseTileImage = true;
            this.t_transakcije.Click += new System.EventHandler(this.t_transakcije_Click);
            // 
            // t_obavijesti
            // 
            this.t_obavijesti.ActiveControl = null;
            this.t_obavijesti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_obavijesti.BackColor = System.Drawing.Color.ForestGreen;
            this.t_obavijesti.Location = new System.Drawing.Point(613, 542);
            this.t_obavijesti.Name = "t_obavijesti";
            this.t_obavijesti.Size = new System.Drawing.Size(416, 163);
            this.t_obavijesti.TabIndex = 24;
            this.t_obavijesti.Text = "Obavijesti";
            this.t_obavijesti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_obavijesti.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_obavijesti.TileImage = ((System.Drawing.Image)(resources.GetObject("t_obavijesti.TileImage")));
            this.t_obavijesti.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_obavijesti.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_obavijesti.UseCustomBackColor = true;
            this.t_obavijesti.UseCustomForeColor = true;
            this.t_obavijesti.UseSelectable = true;
            this.t_obavijesti.UseTileImage = true;
            // 
            // t_izvjestaji
            // 
            this.t_izvjestaji.ActiveControl = null;
            this.t_izvjestaji.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_izvjestaji.BackColor = System.Drawing.Color.RoyalBlue;
            this.t_izvjestaji.Location = new System.Drawing.Point(613, 187);
            this.t_izvjestaji.Name = "t_izvjestaji";
            this.t_izvjestaji.Size = new System.Drawing.Size(416, 163);
            this.t_izvjestaji.TabIndex = 25;
            this.t_izvjestaji.Text = "Izvještaji";
            this.t_izvjestaji.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_izvjestaji.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_izvjestaji.TileImage = ((System.Drawing.Image)(resources.GetObject("t_izvjestaji.TileImage")));
            this.t_izvjestaji.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_izvjestaji.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_izvjestaji.UseCustomBackColor = true;
            this.t_izvjestaji.UseCustomForeColor = true;
            this.t_izvjestaji.UseSelectable = true;
            this.t_izvjestaji.UseTileImage = true;
            // 
            // t_proizvodi
            // 
            this.t_proizvodi.ActiveControl = null;
            this.t_proizvodi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_proizvodi.BackColor = System.Drawing.Color.Tomato;
            this.t_proizvodi.Location = new System.Drawing.Point(125, 356);
            this.t_proizvodi.Name = "t_proizvodi";
            this.t_proizvodi.Size = new System.Drawing.Size(416, 180);
            this.t_proizvodi.TabIndex = 26;
            this.t_proizvodi.Text = "PROIZVODI";
            this.t_proizvodi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_proizvodi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_proizvodi.TileImage = ((System.Drawing.Image)(resources.GetObject("t_proizvodi.TileImage")));
            this.t_proizvodi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_proizvodi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_proizvodi.UseCustomBackColor = true;
            this.t_proizvodi.UseCustomForeColor = true;
            this.t_proizvodi.UseSelectable = true;
            this.t_proizvodi.UseTileImage = true;
            this.t_proizvodi.Click += new System.EventHandler(this.t_proizvodi_Click);
            // 
            // t_narudzba
            // 
            this.t_narudzba.ActiveControl = null;
            this.t_narudzba.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_narudzba.BackColor = System.Drawing.Color.SlateGray;
            this.t_narudzba.Location = new System.Drawing.Point(338, 542);
            this.t_narudzba.Name = "t_narudzba";
            this.t_narudzba.Size = new System.Drawing.Size(203, 163);
            this.t_narudzba.TabIndex = 27;
            this.t_narudzba.Text = "Narudžbe";
            this.t_narudzba.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_narudzba.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_narudzba.TileImage = ((System.Drawing.Image)(resources.GetObject("t_narudzba.TileImage")));
            this.t_narudzba.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_narudzba.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_narudzba.UseCustomBackColor = true;
            this.t_narudzba.UseCustomForeColor = true;
            this.t_narudzba.UseSelectable = true;
            this.t_narudzba.UseTileImage = true;
            // 
            // t_racun
            // 
            this.t_racun.ActiveControl = null;
            this.t_racun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_racun.BackColor = System.Drawing.Color.DarkOrchid;
            this.t_racun.Location = new System.Drawing.Point(125, 542);
            this.t_racun.Name = "t_racun";
            this.t_racun.Size = new System.Drawing.Size(203, 163);
            this.t_racun.TabIndex = 28;
            this.t_racun.Text = "Računi";
            this.t_racun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_racun.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_racun.TileImage = ((System.Drawing.Image)(resources.GetObject("t_racun.TileImage")));
            this.t_racun.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_racun.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_racun.UseCustomBackColor = true;
            this.t_racun.UseCustomForeColor = true;
            this.t_racun.UseSelectable = true;
            this.t_racun.UseTileImage = true;
            this.t_racun.Click += new System.EventHandler(this.t_racun_Click);
            // 
            // t_dobavljaci
            // 
            this.t_dobavljaci.ActiveControl = null;
            this.t_dobavljaci.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_dobavljaci.BackColor = System.Drawing.Color.LimeGreen;
            this.t_dobavljaci.Location = new System.Drawing.Point(338, 187);
            this.t_dobavljaci.Name = "t_dobavljaci";
            this.t_dobavljaci.Size = new System.Drawing.Size(203, 163);
            this.t_dobavljaci.TabIndex = 29;
            this.t_dobavljaci.Text = "Dobavljači";
            this.t_dobavljaci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_dobavljaci.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_dobavljaci.TileImage = ((System.Drawing.Image)(resources.GetObject("t_dobavljaci.TileImage")));
            this.t_dobavljaci.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_dobavljaci.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_dobavljaci.UseCustomBackColor = true;
            this.t_dobavljaci.UseCustomForeColor = true;
            this.t_dobavljaci.UseSelectable = true;
            this.t_dobavljaci.UseTileImage = true;
            this.t_dobavljaci.Click += new System.EventHandler(this.t_dobavljaci_Click);
            // 
            // Vrijeme
            // 
            this.Vrijeme.ActiveControl = null;
            this.Vrijeme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Vrijeme.BackColor = System.Drawing.Color.Azure;
            this.Vrijeme.ForeColor = System.Drawing.Color.DarkRed;
            this.Vrijeme.Location = new System.Drawing.Point(1108, 288);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Size = new System.Drawing.Size(203, 79);
            this.Vrijeme.TabIndex = 30;
            this.Vrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vrijeme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Vrijeme.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Vrijeme.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Vrijeme.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Vrijeme.UseCustomBackColor = true;
            this.Vrijeme.UseCustomForeColor = true;
            this.Vrijeme.UseSelectable = true;
            this.Vrijeme.UseTileImage = true;
            // 
            // t_korisnici
            // 
            this.t_korisnici.ActiveControl = null;
            this.t_korisnici.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.t_korisnici.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.t_korisnici.Location = new System.Drawing.Point(125, 187);
            this.t_korisnici.Name = "t_korisnici";
            this.t_korisnici.Size = new System.Drawing.Size(203, 163);
            this.t_korisnici.TabIndex = 31;
            this.t_korisnici.Text = "Korisnici";
            this.t_korisnici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_korisnici.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_korisnici.TileImage = ((System.Drawing.Image)(resources.GetObject("t_korisnici.TileImage")));
            this.t_korisnici.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_korisnici.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.t_korisnici.UseCustomBackColor = true;
            this.t_korisnici.UseCustomForeColor = true;
            this.t_korisnici.UseSelectable = true;
            this.t_korisnici.UseTileImage = true;
            this.t_korisnici.Click += new System.EventHandler(this.Korisnici_Click);
            // 
            // MyNventory
            // 
            this.MyNventory.AutoSize = true;
            this.MyNventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyNventory.ForeColor = System.Drawing.Color.SpringGreen;
            this.MyNventory.Location = new System.Drawing.Point(585, 38);
            this.MyNventory.Name = "MyNventory";
            this.MyNventory.Size = new System.Drawing.Size(291, 55);
            this.MyNventory.TabIndex = 22;
            this.MyNventory.Text = "MyNventory";
            this.MyNventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Glavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 742);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.t_transakcije);
            this.Controls.Add(this.t_obavijesti);
            this.Controls.Add(this.t_izvjestaji);
            this.Controls.Add(this.t_proizvodi);
            this.Controls.Add(this.t_narudzba);
            this.Controls.Add(this.t_racun);
            this.Controls.Add(this.t_dobavljaci);
            this.Controls.Add(this.Vrijeme);
            this.Controls.Add(this.t_korisnici);
            this.Controls.Add(this.MyNventory);
            this.Name = "Glavni";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory - Izbornik";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Glavni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odjava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlToolTip odjava_info;
        private System.Windows.Forms.PictureBox odjava;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile Datum;
        private MetroFramework.Controls.MetroTile t_transakcije;
        private MetroFramework.Controls.MetroTile t_obavijesti;
        private MetroFramework.Controls.MetroTile t_izvjestaji;
        private MetroFramework.Controls.MetroTile t_proizvodi;
        private MetroFramework.Controls.MetroTile t_narudzba;
        private MetroFramework.Controls.MetroTile t_racun;
        private MetroFramework.Controls.MetroTile t_dobavljaci;
        private MetroFramework.Controls.MetroTile Vrijeme;
        private MetroFramework.Controls.MetroTile t_korisnici;
        private System.Windows.Forms.Label MyNventory;
    }
}