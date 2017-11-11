namespace LogIn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2_header = new System.Windows.Forms.Label();
            this.label2_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_login = new System.Windows.Forms.Button();
            this.button1_exit = new System.Windows.Forms.Button();
            this.label3_Pwd = new System.Windows.Forms.Label();
            this.label2_userName = new System.Windows.Forms.Label();
            this.textBox2_pwd = new System.Windows.Forms.TextBox();
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.39416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.60584F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 475);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(266, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26316F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 475);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2_header);
            this.panel2.Controls.Add(this.label2_status);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2_login);
            this.panel2.Controls.Add(this.button1_exit);
            this.panel2.Controls.Add(this.label3_Pwd);
            this.panel2.Controls.Add(this.label2_userName);
            this.panel2.Controls.Add(this.textBox2_pwd);
            this.panel2.Controls.Add(this.textBox1_userName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 348);
            this.panel2.TabIndex = 0;
            // 
            // label2_header
            // 
            this.label2_header.AutoSize = true;
            this.label2_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_header.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2_header.Location = new System.Drawing.Point(38, 34);
            this.label2_header.Name = "label2_header";
            this.label2_header.Size = new System.Drawing.Size(84, 20);
            this.label2_header.TabIndex = 8;
            this.label2_header.Text = "HEADER";
            // 
            // label2_status
            // 
            this.label2_status.AutoSize = true;
            this.label2_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_status.Location = new System.Drawing.Point(38, 317);
            this.label2_status.Name = "label2_status";
            this.label2_status.Size = new System.Drawing.Size(0, 18);
            this.label2_status.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "SIGNUP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_login
            // 
            this.button2_login.Location = new System.Drawing.Point(291, 247);
            this.button2_login.Name = "button2_login";
            this.button2_login.Size = new System.Drawing.Size(75, 34);
            this.button2_login.TabIndex = 5;
            this.button2_login.Text = "LOGIN";
            this.button2_login.UseVisualStyleBackColor = true;
            this.button2_login.Click += new System.EventHandler(this.button2_login_Click);
            // 
            // button1_exit
            // 
            this.button1_exit.Location = new System.Drawing.Point(41, 247);
            this.button1_exit.Name = "button1_exit";
            this.button1_exit.Size = new System.Drawing.Size(75, 34);
            this.button1_exit.TabIndex = 4;
            this.button1_exit.Text = "EXIT";
            this.button1_exit.UseVisualStyleBackColor = true;
            this.button1_exit.Click += new System.EventHandler(this.button1_exit_Click);
            // 
            // label3_Pwd
            // 
            this.label3_Pwd.AutoSize = true;
            this.label3_Pwd.Location = new System.Drawing.Point(121, 150);
            this.label3_Pwd.Name = "label3_Pwd";
            this.label3_Pwd.Size = new System.Drawing.Size(70, 13);
            this.label3_Pwd.TabIndex = 3;
            this.label3_Pwd.Text = "PASSWORD";
            // 
            // label2_userName
            // 
            this.label2_userName.AutoSize = true;
            this.label2_userName.Location = new System.Drawing.Point(121, 84);
            this.label2_userName.Name = "label2_userName";
            this.label2_userName.Size = new System.Drawing.Size(71, 13);
            this.label2_userName.TabIndex = 2;
            this.label2_userName.Text = "USER NAME";
            // 
            // textBox2_pwd
            // 
            this.textBox2_pwd.Location = new System.Drawing.Point(218, 150);
            this.textBox2_pwd.Name = "textBox2_pwd";
            this.textBox2_pwd.Size = new System.Drawing.Size(100, 20);
            this.textBox2_pwd.TabIndex = 1;
            // 
            // textBox1_userName
            // 
            this.textBox1_userName.Location = new System.Drawing.Point(218, 81);
            this.textBox1_userName.Name = "textBox1_userName";
            this.textBox1_userName.Size = new System.Drawing.Size(100, 20);
            this.textBox1_userName.TabIndex = 0;
            this.textBox1_userName.TextChanged += new System.EventHandler(this.textBox1_userName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form_close);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2_login;
        private System.Windows.Forms.Button button1_exit;
        private System.Windows.Forms.Label label3_Pwd;
        private System.Windows.Forms.Label label2_userName;
        private System.Windows.Forms.TextBox textBox2_pwd;
        public System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2_status;
        private System.Windows.Forms.Label label2_header;

    }
}

