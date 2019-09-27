namespace WindowsFormsApp1
{
    partial class Add_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.dime = new System.Windows.Forms.TextBox();
            this.dcontact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dime
            // 
            this.dime.Location = new System.Drawing.Point(280, 96);
            this.dime.Name = "dime";
            this.dime.Size = new System.Drawing.Size(218, 20);
            this.dime.TabIndex = 1;
            // 
            // dcontact
            // 
            this.dcontact.Location = new System.Drawing.Point(280, 139);
            this.dcontact.Name = "dcontact";
            this.dcontact.Size = new System.Drawing.Size(218, 20);
            this.dcontact.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(83, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(626, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel / Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dcontact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dime);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_supplier";
            this.Text = "Suppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dime;
        private System.Windows.Forms.TextBox dcontact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}