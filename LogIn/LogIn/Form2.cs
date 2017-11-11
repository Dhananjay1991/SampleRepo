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
    public partial class Form2 : Form
    {
        List<LoginDetails> loginlist = new List<LoginDetails>();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream stream = File.Open("LoginData.txt", FileMode.Open, FileAccess.Read))
                {
                    var bformatter = new BinaryFormatter();
                    this.loginlist = (List<LoginDetails>)bformatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch { }
            if (checkForDuplicateEntry())
                return;
            loginlist.Add(new LoginDetails(textBox1_form2_user.Text, textBox2_form2_pwd.Text));
            try
            {
                using (FileStream stream = File.Open("LoginData.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var bformatter = new BinaryFormatter();
                    bformatter.Serialize(stream, loginlist);
                    stream.Close();
                }
                this.Close();
                textBox1_form2_user.Clear();
                textBox2_form2_pwd.Clear();
                
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
        public bool checkForDuplicateEntry()
        {
            bool flag = false;
            for (int i = 0; i < loginlist.Count; i++)
            {
                if (textBox1_form2_user.Text.ToLower().Equals(loginlist[i].User_Name.ToLower()))
                {
                    flag = true;
                    MessageBox.Show("User Name Already Exist!!!.\nDuplicate User Cannot Be Saved","WARNING!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    textBox1_form2_user.Clear();
                    textBox2_form2_pwd.Clear();
                    break;
                }
            }
            if (flag == false)
                return false;
            else
                return true;
        }
    }
}
