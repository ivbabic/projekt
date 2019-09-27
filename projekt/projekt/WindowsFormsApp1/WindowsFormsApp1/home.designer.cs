namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.users = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tren_ime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prijavljen = new System.Windows.Forms.TextBox();
            this.odjava = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.users.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            resources.ApplyResources(this.users, "users");
            this.users.Controls.Add(this.tabPage1);
            this.users.Controls.Add(this.tabPage2);
            this.users.Controls.Add(this.tabPage3);
            this.users.Controls.Add(this.tabPage4);
            this.users.Controls.Add(this.tabPage5);
            this.users.Controls.Add(this.tabPage6);
            this.users.Controls.Add(this.tabPage7);
            this.users.Controls.Add(this.tabPage8);
            this.users.Name = "users";
            this.users.SelectedIndex = 0;
            this.users.Selected += new System.Windows.Forms.TabControlEventHandler(this.users_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.tren_ime);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.prijavljen);
            this.tabPage1.Controls.Add(this.odjava);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tren_ime
            // 
            resources.ApplyResources(this.tren_ime, "tren_ime");
            this.tren_ime.Name = "tren_ime";
            this.tren_ime.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // prijavljen
            // 
            this.prijavljen.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.prijavljen, "prijavljen");
            this.prijavljen.Name = "prijavljen";
            this.prijavljen.ReadOnly = true;
            // 
            // odjava
            // 
            resources.ApplyResources(this.odjava, "odjava");
            this.odjava.Name = "odjava";
            this.odjava.UseVisualStyleBackColor = true;
            this.odjava.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // button10
            // 
            resources.ApplyResources(this.button10, "button10");
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.First_Name,
            this.Surname,
            this.Position,
            this.Phone,
            this.Email,
            this.Password,
            this.Password_2});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // First_Name
            // 
            this.First_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.First_Name, "First_Name");
            this.First_Name.Name = "First_Name";
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Surname, "Surname");
            this.Surname.Name = "Surname";
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Position, "Position");
            this.Position.Name = "Position";
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Phone, "Phone");
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            // 
            // Password_2
            // 
            resources.ApplyResources(this.Password_2, "Password_2");
            this.Password_2.Name = "Password_2";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Name = "tabPage3";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.User_id,
            this.Naziv,
            this.Kontakt});
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // SID
            // 
            this.SID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.SID, "SID");
            this.SID.Name = "SID";
            this.SID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // User_id
            // 
            this.User_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.User_id, "User_id");
            this.User_id.Name = "User_id";
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            // 
            // Kontakt
            // 
            this.Kontakt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Kontakt, "Kontakt");
            this.Kontakt.Name = "Kontakt";
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.users);
            this.Name = "Home";
            this.users.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl users;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tren_ime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        public System.Windows.Forms.TextBox prijavljen;
    }
}