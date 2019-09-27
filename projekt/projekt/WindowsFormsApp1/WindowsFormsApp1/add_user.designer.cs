namespace WindowsFormsApp1
{
    partial class Add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_user));
            this.label1 = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rola_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(238, 105);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(244, 20);
            this.prezime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(238, 205);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(244, 20);
            this.tel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(66, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(238, 255);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(244, 20);
            this.email.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(66, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(238, 305);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(244, 20);
            this.password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(66, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // password_2
            // 
            this.password_2.Location = new System.Drawing.Point(238, 355);
            this.password_2.Name = "password_2";
            this.password_2.Size = new System.Drawing.Size(244, 20);
            this.password_2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(66, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(650, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(650, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(238, 56);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(244, 20);
            this.ime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(66, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // rola_combo
            // 
            this.rola_combo.FormattingEnabled = true;
            this.rola_combo.Items.AddRange(new object[] {
            "Admin",
            "Blagajna",
            "Skladiste"});
            this.rola_combo.Location = new System.Drawing.Point(238, 154);
            this.rola_combo.Name = "rola_combo";
            this.rola_combo.Size = new System.Drawing.Size(244, 21);
            this.rola_combo.TabIndex = 16;
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rola_combo);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_user";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rola_combo;
    }
}