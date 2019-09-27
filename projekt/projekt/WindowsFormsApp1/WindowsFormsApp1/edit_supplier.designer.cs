namespace WindowsFormsApp1
{
    partial class Edit_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kontakt_d = new System.Windows.Forms.TextBox();
            this.naziv_d = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id_d = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(83, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // kontakt_d
            // 
            this.kontakt_d.Location = new System.Drawing.Point(280, 141);
            this.kontakt_d.Name = "kontakt_d";
            this.kontakt_d.Size = new System.Drawing.Size(219, 20);
            this.kontakt_d.TabIndex = 2;
            // 
            // naziv_d
            // 
            this.naziv_d.Location = new System.Drawing.Point(280, 96);
            this.naziv_d.Name = "naziv_d";
            this.naziv_d.Size = new System.Drawing.Size(218, 20);
            this.naziv_d.TabIndex = 3;
            this.naziv_d.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(486, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(626, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel/Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(150, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // id_d
            // 
            this.id_d.Location = new System.Drawing.Point(279, 54);
            this.id_d.Name = "id_d";
            this.id_d.ReadOnly = true;
            this.id_d.Size = new System.Drawing.Size(219, 20);
            this.id_d.TabIndex = 7;
            // 
            // Edit_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_d);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.naziv_d);
            this.Controls.Add(this.kontakt_d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_supplier";
            this.Text = "Edit Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox kontakt_d;
        public System.Windows.Forms.TextBox naziv_d;
        public System.Windows.Forms.TextBox id_d;
    }
}