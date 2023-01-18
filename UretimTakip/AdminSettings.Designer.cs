namespace UretimTakip
{
    partial class AdminSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_namesurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_userpassword = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ShowAllUsers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_clock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(915, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 141);
            this.panel1.TabIndex = 0;
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clock.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_clock.Location = new System.Drawing.Point(124, 72);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(17, 27);
            this.lbl_clock.TabIndex = 0;
            this.lbl_clock.Text = ".";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_namesurname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.txt_userpassword);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(859, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 610);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name Surname:";
            // 
            // txt_namesurname
            // 
            this.txt_namesurname.Location = new System.Drawing.Point(142, 68);
            this.txt_namesurname.Name = "txt_namesurname";
            this.txt_namesurname.Size = new System.Drawing.Size(232, 27);
            this.txt_namesurname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "User Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "User Name :";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_add.Image = global::UretimTakip.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(15, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(359, 47);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add User";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_update.Image = global::UretimTakip.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(15, 279);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(359, 47);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update User";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_delete.Image = global::UretimTakip.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(15, 332);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(359, 47);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete User";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_userpassword
            // 
            this.txt_userpassword.Location = new System.Drawing.Point(142, 134);
            this.txt_userpassword.Name = "txt_userpassword";
            this.txt_userpassword.PasswordChar = '*';
            this.txt_userpassword.Size = new System.Drawing.Size(232, 27);
            this.txt_userpassword.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(142, 101);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(232, 27);
            this.txt_username.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btn_ShowAllUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 141);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(131, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 47);
            this.label4.TabIndex = 26;
            this.label4.Text = "Admin Settings";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = global::UretimTakip.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(12, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 89);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_ShowAllUsers
            // 
            this.btn_ShowAllUsers.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowAllUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ShowAllUsers.Image = global::UretimTakip.Properties.Resources.search;
            this.btn_ShowAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowAllUsers.Location = new System.Drawing.Point(428, 24);
            this.btn_ShowAllUsers.Name = "btn_ShowAllUsers";
            this.btn_ShowAllUsers.Size = new System.Drawing.Size(324, 97);
            this.btn_ShowAllUsers.TabIndex = 25;
            this.btn_ShowAllUsers.Text = "Show All Users";
            this.btn_ShowAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowAllUsers.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(859, 610);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 751);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "AdminSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_clock;
        private Panel panel2;
        private TextBox txt_userpassword;
        private TextBox txt_username;
        private Panel panel3;
        private Button btn_update;
        private Button btn_delete;
        private Label label2;
        private Label label1;
        private Button btn_add;
        private Label label4;
        private Button btn_ShowAllUsers;
        private DataGridView dataGridView1;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private TextBox txt_namesurname;
    }
}