namespace Mynventory.View
{
    partial class Proizvodi_forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proizvodi_forma));
            this.g_proizvodi = new MetroFramework.Controls.MetroGrid();
            this.b_dodaj_pro = new MetroFramework.Controls.MetroButton();
            this.b_izbrisi_pro = new MetroFramework.Controls.MetroButton();
            this.b_uredi_pro = new MetroFramework.Controls.MetroButton();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poreznaStopaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZadnjeProdajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.g_proizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // g_proizvodi
            // 
            this.g_proizvodi.AllowUserToResizeRows = false;
            this.g_proizvodi.AutoGenerateColumns = false;
            this.g_proizvodi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_proizvodi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_proizvodi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.g_proizvodi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_proizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.g_proizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g_proizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.mjernaJedinicaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.poreznaStopaDataGridViewTextBoxColumn,
            this.datumZadnjeProdajeDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn});
            this.g_proizvodi.DataSource = this.proizvodiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g_proizvodi.DefaultCellStyle = dataGridViewCellStyle2;
            this.g_proizvodi.EnableHeadersVisualStyles = false;
            this.g_proizvodi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.g_proizvodi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_proizvodi.Location = new System.Drawing.Point(23, 233);
            this.g_proizvodi.Name = "g_proizvodi";
            this.g_proizvodi.ReadOnly = true;
            this.g_proizvodi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_proizvodi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.g_proizvodi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.g_proizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g_proizvodi.Size = new System.Drawing.Size(847, 390);
            this.g_proizvodi.Style = MetroFramework.MetroColorStyle.Green;
            this.g_proizvodi.TabIndex = 0;
            this.g_proizvodi.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // b_dodaj_pro
            // 
            this.b_dodaj_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_dodaj_pro.BackgroundImage")));
            this.b_dodaj_pro.Location = new System.Drawing.Point(968, 345);
            this.b_dodaj_pro.Name = "b_dodaj_pro";
            this.b_dodaj_pro.Size = new System.Drawing.Size(106, 47);
            this.b_dodaj_pro.TabIndex = 1;
            this.b_dodaj_pro.Text = "Dodaj";
            this.b_dodaj_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_dodaj_pro.UseCustomBackColor = true;
            this.b_dodaj_pro.UseCustomForeColor = true;
            this.b_dodaj_pro.UseSelectable = true;
            this.b_dodaj_pro.Click += new System.EventHandler(this.b_dodaj_pro_Click);
            // 
            // b_izbrisi_pro
            // 
            this.b_izbrisi_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_izbrisi_pro.BackgroundImage")));
            this.b_izbrisi_pro.Location = new System.Drawing.Point(968, 509);
            this.b_izbrisi_pro.Name = "b_izbrisi_pro";
            this.b_izbrisi_pro.Size = new System.Drawing.Size(106, 47);
            this.b_izbrisi_pro.TabIndex = 2;
            this.b_izbrisi_pro.Text = "Izbriši";
            this.b_izbrisi_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_izbrisi_pro.UseCustomBackColor = true;
            this.b_izbrisi_pro.UseCustomForeColor = true;
            this.b_izbrisi_pro.UseSelectable = true;
            this.b_izbrisi_pro.Click += new System.EventHandler(this.b_izbrisi_pro_Click);
            // 
            // b_uredi_pro
            // 
            this.b_uredi_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_uredi_pro.BackgroundImage")));
            this.b_uredi_pro.Location = new System.Drawing.Point(968, 427);
            this.b_uredi_pro.Name = "b_uredi_pro";
            this.b_uredi_pro.Size = new System.Drawing.Size(106, 47);
            this.b_uredi_pro.TabIndex = 3;
            this.b_uredi_pro.Text = "Uredi";
            this.b_uredi_pro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_uredi_pro.UseCustomBackColor = true;
            this.b_uredi_pro.UseCustomForeColor = true;
            this.b_uredi_pro.UseSelectable = true;
            this.b_uredi_pro.Click += new System.EventHandler(this.b_uredi_pro_Click);
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataSource = typeof(Mynventory.Model.Proizvodi);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "Mjerna Jedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poreznaStopaDataGridViewTextBoxColumn
            // 
            this.poreznaStopaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.poreznaStopaDataGridViewTextBoxColumn.DataPropertyName = "PoreznaStopa";
            this.poreznaStopaDataGridViewTextBoxColumn.HeaderText = "Porezna Stopa";
            this.poreznaStopaDataGridViewTextBoxColumn.Name = "poreznaStopaDataGridViewTextBoxColumn";
            this.poreznaStopaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZadnjeProdajeDataGridViewTextBoxColumn
            // 
            this.datumZadnjeProdajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumZadnjeProdajeDataGridViewTextBoxColumn.DataPropertyName = "DatumZadnjeProdaje";
            this.datumZadnjeProdajeDataGridViewTextBoxColumn.HeaderText = "Datum Zadnje Prodaje";
            this.datumZadnjeProdajeDataGridViewTextBoxColumn.Name = "datumZadnjeProdajeDataGridViewTextBoxColumn";
            this.datumZadnjeProdajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "Dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "Dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            this.dobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Proizvodi_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.b_uredi_pro);
            this.Controls.Add(this.b_izbrisi_pro);
            this.Controls.Add(this.b_dodaj_pro);
            this.Controls.Add(this.g_proizvodi);
            this.Name = "Proizvodi_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory : Proizvodi";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Proizvodi_forma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g_proizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroGrid g_proizvodi;
        private MetroFramework.Controls.MetroButton b_dodaj_pro;
        private MetroFramework.Controls.MetroButton b_izbrisi_pro;
        private MetroFramework.Controls.MetroButton b_uredi_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poreznaStopaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZadnjeProdajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
    }
}