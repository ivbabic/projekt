namespace Mynventory.View
{
    partial class Dobavljaci_forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dobavljaci_forma));
            this.g_dobavljaci = new MetroFramework.Controls.MetroGrid();
            this.b_uredi_dob = new MetroFramework.Controls.MetroButton();
            this.b_izbrisi_dob = new MetroFramework.Controls.MetroButton();
            this.b_dodaj = new MetroFramework.Controls.MetroButton();
            this.Oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.g_dobavljaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // g_dobavljaci
            // 
            this.g_dobavljaci.AllowUserToResizeRows = false;
            this.g_dobavljaci.AutoGenerateColumns = false;
            this.g_dobavljaci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_dobavljaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_dobavljaci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.g_dobavljaci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_dobavljaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.g_dobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g_dobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.Oib});
            this.g_dobavljaci.DataSource = this.dobavljaciBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g_dobavljaci.DefaultCellStyle = dataGridViewCellStyle2;
            this.g_dobavljaci.EnableHeadersVisualStyles = false;
            this.g_dobavljaci.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.g_dobavljaci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_dobavljaci.Location = new System.Drawing.Point(23, 251);
            this.g_dobavljaci.Name = "g_dobavljaci";
            this.g_dobavljaci.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_dobavljaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.g_dobavljaci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.g_dobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g_dobavljaci.Size = new System.Drawing.Size(748, 390);
            this.g_dobavljaci.Style = MetroFramework.MetroColorStyle.Green;
            this.g_dobavljaci.TabIndex = 1;
            this.g_dobavljaci.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // b_uredi_dob
            // 
            this.b_uredi_dob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_uredi_dob.BackgroundImage")));
            this.b_uredi_dob.Location = new System.Drawing.Point(900, 427);
            this.b_uredi_dob.Name = "b_uredi_dob";
            this.b_uredi_dob.Size = new System.Drawing.Size(106, 47);
            this.b_uredi_dob.TabIndex = 6;
            this.b_uredi_dob.Text = "Uredi";
            this.b_uredi_dob.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_uredi_dob.UseCustomBackColor = true;
            this.b_uredi_dob.UseCustomForeColor = true;
            this.b_uredi_dob.UseSelectable = true;
            this.b_uredi_dob.Click += new System.EventHandler(this.b_uredi_dob_Click);
            // 
            // b_izbrisi_dob
            // 
            this.b_izbrisi_dob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_izbrisi_dob.BackgroundImage")));
            this.b_izbrisi_dob.Location = new System.Drawing.Point(900, 509);
            this.b_izbrisi_dob.Name = "b_izbrisi_dob";
            this.b_izbrisi_dob.Size = new System.Drawing.Size(106, 47);
            this.b_izbrisi_dob.TabIndex = 5;
            this.b_izbrisi_dob.Text = "Izbriši";
            this.b_izbrisi_dob.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_izbrisi_dob.UseCustomBackColor = true;
            this.b_izbrisi_dob.UseCustomForeColor = true;
            this.b_izbrisi_dob.UseSelectable = true;
            this.b_izbrisi_dob.Click += new System.EventHandler(this.b_izbrisi_dob_Click);
            // 
            // b_dodaj
            // 
            this.b_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_dodaj.BackgroundImage")));
            this.b_dodaj.Location = new System.Drawing.Point(900, 345);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(106, 47);
            this.b_dodaj.TabIndex = 4;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_dodaj.UseCustomBackColor = true;
            this.b_dodaj.UseCustomForeColor = true;
            this.b_dodaj.UseSelectable = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // Oib
            // 
            this.Oib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oib.DataPropertyName = "Oib";
            this.Oib.HeaderText = "Oib";
            this.Oib.Name = "Oib";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // dobavljaciBindingSource2
            // 
            this.dobavljaciBindingSource2.DataSource = typeof(Mynventory.Model.Dobavljaci);
            // 
            // Dobavljaci_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.b_uredi_dob);
            this.Controls.Add(this.b_izbrisi_dob);
            this.Controls.Add(this.b_dodaj);
            this.Controls.Add(this.g_dobavljaci);
            this.Name = "Dobavljaci_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventory: Dobavljači";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Dobavljaci_forma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g_dobavljaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid g_dobavljaci;
        private MetroFramework.Controls.MetroButton b_uredi_dob;
        private MetroFramework.Controls.MetroButton b_izbrisi_dob;
        private MetroFramework.Controls.MetroButton b_dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oib;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource2;
    }
}