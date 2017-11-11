namespace LogIn
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3_search_form3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button1_save = new System.Windows.Forms.Button();
            this.label2_contactno = new System.Windows.Forms.Label();
            this.textBox2_contactNo_form3 = new System.Windows.Forms.TextBox();
            this.label1_name = new System.Windows.Forms.Label();
            this.textBox1_name_form3 = new System.Windows.Forms.TextBox();
            this.label1_form3_status = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button3_search_form3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button1_save);
            this.panel1.Controls.Add(this.label2_contactno);
            this.panel1.Controls.Add(this.textBox2_contactNo_form3);
            this.panel1.Controls.Add(this.label1_name);
            this.panel1.Controls.Add(this.textBox1_name_form3);
            this.panel1.Controls.Add(this.label1_form3_status);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 434);
            this.panel1.TabIndex = 0;
            // 
            // button3_search_form3
            // 
            this.button3_search_form3.Location = new System.Drawing.Point(7, 303);
            this.button3_search_form3.Name = "button3_search_form3";
            this.button3_search_form3.Size = new System.Drawing.Size(83, 34);
            this.button3_search_form3.TabIndex = 8;
            this.button3_search_form3.Text = "SEARCH";
            this.button3_search_form3.UseVisualStyleBackColor = true;
            this.button3_search_form3.Click += new System.EventHandler(this.button3_Click_Search);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Logout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "DISPLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_Display);
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(109, 303);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(95, 34);
            this.button1_save.TabIndex = 5;
            this.button1_save.Text = "ADD CONTACT";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // label2_contactno
            // 
            this.label2_contactno.AutoSize = true;
            this.label2_contactno.Location = new System.Drawing.Point(180, 196);
            this.label2_contactno.Name = "label2_contactno";
            this.label2_contactno.Size = new System.Drawing.Size(77, 13);
            this.label2_contactno.TabIndex = 4;
            this.label2_contactno.Text = "CONTACT NO";
            // 
            // textBox2_contactNo_form3
            // 
            this.textBox2_contactNo_form3.Location = new System.Drawing.Point(293, 196);
            this.textBox2_contactNo_form3.Name = "textBox2_contactNo_form3";
            this.textBox2_contactNo_form3.Size = new System.Drawing.Size(100, 20);
            this.textBox2_contactNo_form3.TabIndex = 3;
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Location = new System.Drawing.Point(180, 140);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(38, 13);
            this.label1_name.TabIndex = 2;
            this.label1_name.Text = "NAME";
            // 
            // textBox1_name_form3
            // 
            this.textBox1_name_form3.Location = new System.Drawing.Point(293, 140);
            this.textBox1_name_form3.Name = "textBox1_name_form3";
            this.textBox1_name_form3.Size = new System.Drawing.Size(100, 20);
            this.textBox1_name_form3.TabIndex = 1;
            // 
            // label1_form3_status
            // 
            this.label1_form3_status.AutoSize = true;
            this.label1_form3_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_form3_status.Location = new System.Drawing.Point(37, 30);
            this.label1_form3_status.Name = "label1_form3_status";
            this.label1_form3_status.Size = new System.Drawing.Size(90, 24);
            this.label1_form3_status.TabIndex = 0;
            this.label1_form3_status.Text = "STATUS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "DELETE CONTACT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete_Button);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(583, 439);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1_form3_status;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.Label label2_contactno;
        public System.Windows.Forms.TextBox textBox2_contactNo_form3;
        private System.Windows.Forms.Label label1_name;
        public System.Windows.Forms.TextBox textBox1_name_form3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3_search_form3;
        private System.Windows.Forms.Button button3;
    }
}