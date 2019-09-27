namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.log = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log.ForeColor = System.Drawing.Color.Green;
            this.log.Location = new System.Drawing.Point(271, 311);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(127, 48);
            this.log.TabIndex = 0;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(382, 148);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(235, 20);
            this.username.TabIndex = 1;
            this.username.Text = "ime";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.Color.Green;
            this.clear.Location = new System.Drawing.Point(533, 311);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 48);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(186, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(382, 185);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(235, 20);
            this.password.TabIndex = 4;
            this.password.Text = "admin";
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "MyNventory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(578, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 59);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.username);
            this.Controls.Add(this.log);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "MyNventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox username;
        public System.Windows.Forms.TextBox password;
    }
}

