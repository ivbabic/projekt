namespace Mynventory.View
{
    partial class Useri_forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Useri_forma));
            this.g_useri = new MetroFramework.Controls.MetroGrid();
            this.b_dodaj = new MetroFramework.Controls.MetroButton();
            this.b_uredi = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.g_useri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // g_useri
            // 
            this.g_useri.AllowUserToOrderColumns = true;
            this.g_useri.AllowUserToResizeRows = false;
            this.g_useri.AutoGenerateColumns = false;
            this.g_useri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_useri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_useri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.g_useri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_useri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.g_useri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.g_useri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.rolaDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.g_useri.DataSource = this.useriBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.g_useri.DefaultCellStyle = dataGridViewCellStyle2;
            this.g_useri.EnableHeadersVisualStyles = false;
            this.g_useri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.g_useri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.g_useri.Location = new System.Drawing.Point(56, 195);
            this.g_useri.Name = "g_useri";
            this.g_useri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.g_useri.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.g_useri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.g_useri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.g_useri.Size = new System.Drawing.Size(641, 390);
            this.g_useri.Style = MetroFramework.MetroColorStyle.Green;
            this.g_useri.TabIndex = 0;
            this.g_useri.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // b_dodaj
            // 
            this.b_dodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_dodaj.BackgroundImage")));
            this.b_dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_dodaj.ForeColor = System.Drawing.Color.Black;
            this.b_dodaj.Location = new System.Drawing.Point(825, 271);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(135, 51);
            this.b_dodaj.Style = MetroFramework.MetroColorStyle.Green;
            this.b_dodaj.TabIndex = 1;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_dodaj.UseCustomForeColor = true;
            this.b_dodaj.UseSelectable = true;
            this.b_dodaj.Click += new System.EventHandler(this.B_dodaj_Click);
            // 
            // b_uredi
            // 
            this.b_uredi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_uredi.BackgroundImage")));
            this.b_uredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_uredi.ForeColor = System.Drawing.Color.Black;
            this.b_uredi.Location = new System.Drawing.Point(825, 366);
            this.b_uredi.Name = "b_uredi";
            this.b_uredi.Size = new System.Drawing.Size(135, 51);
            this.b_uredi.Style = MetroFramework.MetroColorStyle.Green;
            this.b_uredi.TabIndex = 2;
            this.b_uredi.Text = "Uredi";
            this.b_uredi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_uredi.UseCustomForeColor = true;
            this.b_uredi.UseSelectable = true;
            this.b_uredi.Click += new System.EventHandler(this.B_uredi_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.ForeColor = System.Drawing.Color.Black;
            this.metroButton2.Location = new System.Drawing.Point(825, 461);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(135, 51);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Izbriši";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // rolaDataGridViewTextBoxColumn
            // 
            this.rolaDataGridViewTextBoxColumn.DataPropertyName = "Rola";
            this.rolaDataGridViewTextBoxColumn.HeaderText = "Rola";
            this.rolaDataGridViewTextBoxColumn.Name = "rolaDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // useriBindingSource
            // 
            this.useriBindingSource.DataSource = typeof(Mynventory.Model.Useri);
            // 
            // Useri_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.g_useri);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.b_uredi);
            this.Controls.Add(this.b_dodaj);
            this.Name = "Useri_forma";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MyNventori : Korisnici";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Useri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g_useri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton b_dodaj;
        private MetroFramework.Controls.MetroButton b_uredi;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource useriBindingSource;
        public MetroFramework.Controls.MetroGrid g_useri;
    }
}