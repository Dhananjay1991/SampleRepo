using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace LogIn
{
    public partial class Form1 : Form
    {
        List<LoginDetails> loginlist = new List<LoginDetails>();
        public string user_name;
        bool user_name_flag = false, pwd_flag = false;
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            label2_header.ForeColor = Color.Blue;
            label2_status.ForeColor = Color.Red;
            label2_header.Text = "WELCOME!!!";
            label2_status.Text = "New Users Please SIGNUP!";
            textBox2_pwd.UseSystemPasswordChar = true;
            
        }
        ~Form1()
        {
            this.Close();
        }

        private void button1_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void form_close(object sender, MouseEventArgs e)
        {
            this.Close();
            Environment.Exit(0);           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.ShowDialog(this);
            //label2_status.Text = "";  
            this.Show();
        }

        private void button2_login_Click(object sender, EventArgs e)
        {            
            user_name = textBox1_userName.Text;
            try
            {
                if (textBox1_userName.Text.Equals("") && textBox2_pwd.Text.Equals(""))
                {
                    label2_status.Text = "Fields Cannot Be Left Blanked!";
                    return;
                }

                else if (!(File.Exists("LoginData.txt")))
                {
                    label2_status.ForeColor = Color.Red;
                    label2_status.Text = "Database Not Found!";
                    return;
                }
                using (FileStream stream = File.Open("LoginData.txt", FileMode.Open, FileAccess.Read))
                {
                    var bformatter = new BinaryFormatter();
                    this.loginlist = (List<LoginDetails>)bformatter.Deserialize(stream);
                    stream.Close();
                }
                for (int i = 0; i < loginlist.Count; i++)
                {
                    if (textBox1_userName.Text.Equals(loginlist[i].User_Name))
                    {
                        user_name_flag = true;
                        if (textBox2_pwd.Text.Equals(loginlist[i].Password))
                        {
                            pwd_flag = true;
                            label2_status.Text = loginlist[i].User_Name + " Successfully Logged In";
                            label2_status.Refresh();
                            label2_status.ForeColor = Color.Red;

                            Form3 form3 = new Form3(user_name);
                            form3.label1_form3_status.ForeColor = Color.Red;
                            form3.label1_form3_status.Text = "For Searching Operation Enter Only Name!";
                            this.Hide();
                            form3.ShowDialog();
                            label2_status.Text = loginlist[i].User_Name + " Successfully Logged Out";
                            this.Show();
                            break;
                        }

                    }
                }
                
                if (user_name_flag == false)
                {
                    label2_status.Text = "Invalid User Name!";
                    label2_status.Refresh();
                }
                else if (user_name_flag == true && pwd_flag == false)
                {
                    label2_status.Text = "Invalid Password!";
                    label2_status.Refresh();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            textBox1_userName.Clear();
            textBox2_pwd.Clear();
        }
            
        private void textBox1_userName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
