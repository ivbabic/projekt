namespace Mynventory.View
{
    partial class Transakcije_forma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabTrans = new MetroFramework.Controls.MetroTabControl();
            this.t_racuni = new MetroFramework.Controls.MetroTabPage();
            this.gr_stavke = new MetroFramework.Controls.MetroGrid();
            this.brojRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunStavkeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.g_racuni = new MetroFramework.Controls.MetroGrid();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPlacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potvrdaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_narudzbe = new MetroFramework.Controls.MetroTabPage();
            this.tabTrans.SuspendLayout();
            this.t_racuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr_stavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunStavkeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_racuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTrans
            // 
            this.tabTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTrans.Controls.Add(this.t_racuni);
            this.tabTrans.Controls.Add(this.t_narudzbe);
            this.tabTrans.ItemSize = new System.Drawing.Size(54, 34);
            this.tabTrans.Location = new System.Drawing.Point(23, 63);
            this.tabTrans.Name = "tabTrans";
            this.tabTrans.SelectedIndex = 0;
            this.tabTrans.Size = new System.Drawing.Size(1104, 591);
            this.tabTrans.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabTrans.TabIndex = 0;
            this.tabTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabTrans.UseSelectable = true;
            // 
            // t_racuni
            // 
            this.t_racuni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.t_racuni.Controls.Add(this.gr_stavke);
            this.t_racuni.Controls.Add(this.g_racuni);
            this.t_racuni.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.t_racuni.HorizontalScrollbarBarColor = true;
            this.t_racuni.HorizontalScrollbarHighlightOnWheel = false;
            this.t_racuni.HorizontalScrollbarSize = 10;
            this.t_racuni.Location = new System.Drawing.Point(4, 38);
            this.t_racuni.Name = "t_racuni";
            this.t_racuni.Size = new System.Drawing.Size(1096, 549);
            this.t_racuni.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_racuni.TabIndex = 0;
            this.t_racuni.Text = "Računi      ";
            this.t_racuni.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_racuni.VerticalScrollbarBarColor = true;
            this.t_racuni.VerticalScrollbarHighlightOnWheel = false;
            this.t_racuni.VerticalScrollbarSize = 10;
            // 
            // gr_stavke
            // 
            this.gr_stavke.AllowUserToResizeRows = false;
            this.gr_stavke.AutoGenerateColumns = false;
            this.gr_stavke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_stavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gr_stavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gr_stavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_stavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gr_stavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr_stavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojRacunaDataGridViewTextBoxColumn,
            this.nazivProizvodaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.gr_stavke.DataSource = this.racunStavkeBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gr_stavke.DefaultCellStyle = dataGridViewCellStyle2;
            this.gr_stavke.EnableHeadersVisualStyles = false;
            this.gr_stavke.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gr_stavke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gr_stavke.Location = new System.Drawing.Point(54, 288);
            this.gr_stavke.Name = "gr_stavke";
            this.gr_stavke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gr_stavke.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gr_stavke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gr_stavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gr_stavke.Size = new System.Drawing.Size(556, 150);
            this.gr_stavke.Style = MetroFramework.MetroColorStyle.Blue;
            this.gr_stavke.TabIndex = 3;
            this.gr_stavke.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // brojRacunaDataGridViewTextBoxColumn
            // 
            this.brojRacunaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojRacunaDataGridViewTextBoxColumn.DataPropertyName = "BrojRacuna";
            this.brojRacunaDataGridViewTextBoxColumn.HeaderText = "Broj Racuna";
            this.brojRacunaDataGridViewTextBoxColumn.Name = "brojRacunaDataGridViewTextBoxColumn";
            // 
            // nazivProizvodaDataGridViewTextBoxColumn
            // 
            this.nazivProizvodaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivProizvodaDataGridViewTextBoxColumn.DataPropertyName = "NazivProizvoda";
            this.nazivProizvodaDataGridViewTextBoxColumn.HeaderText = "Naziv Proizvoda";
            this.nazivProizvodaDataGridViewTextBoxColumn.Name = "nazivProizvodaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // racunStavkeBindingSource2
            // 
            this.racunStavkeBindingSource2.DataSource = typeof(Mynventory.Model.RacunStavke);
            // 
            // g_racuni
            // 
            this.g_racuni.AllowUserToResizeRows = false;
            this.g_racuni.AutoGenerateColumns = false;
            this.g_racuni.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_racuni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_racuni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.g_racuni.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_racuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.g_racuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g_racuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn,
            this.datumPlacanjaDataGridViewTextBoxColumn,
            this.potvrdaDataGridViewCheckBoxColumn});
            this.g_racuni.DataSource = this.racunBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g_racuni.DefaultCellStyle = dataGridViewCellStyle5;
            this.g_racuni.EnableHeadersVisualStyles = false;
            this.g_racuni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.g_racuni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_racuni.Location = new System.Drawing.Point(54, 66);
            this.g_racuni.Name = "g_racuni";
            this.g_racuni.ReadOnly = true;
            this.g_racuni.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_racuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.g_racuni.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.g_racuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g_racuni.Size = new System.Drawing.Size(556, 150);
            this.g_racuni.TabIndex = 2;
            this.g_racuni.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.g_racuni.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.g_racuni_RowEnter);
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "Broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            this.brojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum Izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            this.datumIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumPlacanjaDataGridViewTextBoxColumn
            // 
            this.datumPlacanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumPlacanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumPlacanja";
            this.datumPlacanjaDataGridViewTextBoxColumn.HeaderText = "Datum Plaćanja";
            this.datumPlacanjaDataGridViewTextBoxColumn.Name = "datumPlacanjaDataGridViewTextBoxColumn";
            this.datumPlacanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potvrdaDataGridViewCheckBoxColumn
            // 
            this.potvrdaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.potvrdaDataGridViewCheckBoxColumn.DataPropertyName = "Potvrda";
            this.potvrdaDataGridViewCheckBoxColumn.HeaderText = "Potvrda";
            this.potvrdaDataGridViewCheckBoxColumn.Name = "potvrdaDataGridViewCheckBoxColumn";
            this.potvrdaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(Mynventory.Model.Racun);
            // 
            // t_narudzbe
            // 
            this.t_narudzbe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.t_narudzbe.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.t_narudzbe.HorizontalScrollbarBarColor = true;
            this.t_narudzbe.HorizontalScrollbarHighlightOnWheel = false;
            this.t_narudzbe.HorizontalScrollbarSize = 10;
            this.t_narudzbe.Location = new System.Drawing.Point(4, 38);
            this.t_narudzbe.Name = "t_narudzbe";
            this.t_narudzbe.Size = new System.Drawing.Size(1096, 549);
            this.t_narudzbe.Style = MetroFramework.MetroColorStyle.Blue;
            this.t_narudzbe.TabIndex = 1;
            this.t_narudzbe.Text = "Narudžbe     ";
            this.t_narudzbe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.t_narudzbe.VerticalScrollbarBarColor = true;
            this.t_narudzbe.VerticalScrollbarHighlightOnWheel = false;
            this.t_narudzbe.VerticalScrollbarSize = 10;
            // 
            // Transakcije_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.tabTrans);
            this.Name = "Transakcije_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyNventory : Transakcije";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Transakcije_forma_Load);
            this.tabTrans.ResumeLayout(false);
            this.t_racuni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gr_stavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunStavkeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_racuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabTrans;
        private MetroFramework.Controls.MetroTabPage t_racuni;
        private MetroFramework.Controls.MetroTabPage t_narudzbe;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private MetroFramework.Controls.MetroGrid g_racuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPlacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn potvrdaDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroGrid gr_stavke;
        private System.Windows.Forms.BindingSource racunStavkeBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
    }
}