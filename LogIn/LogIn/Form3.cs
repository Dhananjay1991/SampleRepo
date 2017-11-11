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
    public partial class Form3 : Form
    {
        int count;
        Form1 form1 = new Form1();
        public string user_name;
        public List<ContactInfo> contactlist = new List<ContactInfo>();
        public Form3(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.Text = "Welcome " + user_name;
            try
            {
                using (FileStream stream = File.Open(user_name + "'s contact.txt", FileMode.Open, FileAccess.Read))
                {
                    var bformatter = new BinaryFormatter();
                    this.contactlist = (List<ContactInfo>)bformatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch { }
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_name_form3.Text.Equals("") || textBox2_contactNo_form3.Text.Equals(""))
                {
                    MessageBox.Show("Empty Fields Cannot Be Saved...\nPlease Enter Details...","WARNING!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                for(int i=0;i<contactlist.Count;i++)
                {
                    if(textBox1_name_form3.Text.Equals(contactlist[i].Name))
                    {
                        MessageBox.Show("Name Already Exists...\nCreate New Name...", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1_name_form3.Clear();
                        //textBox2_contactNo_form3.Clear();
                        return;
                    }
                }
                
                contactlist.Add(new ContactInfo(textBox1_name_form3.Text, textBox2_contactNo_form3.Text));
                using (FileStream stream = File.Open(user_name + "'s contact.txt", FileMode.Create, FileAccess.Write))
                {
                    var bformatter = new BinaryFormatter();
                    bformatter.Serialize(stream, contactlist);
                    stream.Close();
                }
                
                textBox1_name_form3.Clear();
                textBox2_contactNo_form3.Clear();
            }
            catch { }
        }

        private void button1_Click_Display(object sender, EventArgs e)
        {
            try
            {
                Form4 form4 = new Form4(this);
                form4.dataGridView1_form4.ColumnCount = 2;
                form4.dataGridView1_form4.Columns[0].Name = "Name";
                form4.dataGridView1_form4.Columns[1].Name = "Contact NO";
                form4.dataGridView1_form4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                form4.dataGridView1_form4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
               
                for(int i=0;i<contactlist.Count;i++)
                {
                    string[] row = new string[] { contactlist[i].Name, contactlist[i].Contact };
                    form4.dataGridView1_form4.Rows.Add(row);
                    form4.dataGridView1_form4.Height += 18;
                    form4.Width += 22;
                    form4.Height += 22;
                }
                form4.dataGridView1_form4.Sort(form4.dataGridView1_form4.Columns[0], ListSortDirection.Ascending);
                this.Hide();
                if (form4.dataGridView1_form4.RowCount == 1)
                    MessageBox.Show("PhoneBook Is Empty!", "Empty PhoneBook!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                form4.ShowDialog();                
                this.Show();
            }
                catch(Exception e3)
                {
                    MessageBox.Show(e3.Message);
                }
        }
        private void button3_Click_Search(object sender, EventArgs e)
        {
            try
            {
                int success = 0;
                bool flag = false;
                SearchDisplay form5 = new SearchDisplay();
                form5.dataGridView1_SearchDisplay.ColumnCount = 2;
                form5.dataGridView1_SearchDisplay.Columns[0].Name = "Name";
                form5.dataGridView1_SearchDisplay.Columns[1].Name = "Contact NO";
                form5.dataGridView1_SearchDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                form5.dataGridView1_SearchDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                if (textBox1_name_form3.Text.Equals("") && textBox2_contactNo_form3.Text.Equals(""))
                {
                    MessageBox.Show("Empty Fields Cannot Be Searched...\nPlease Enter Details...", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < contactlist.Count; i++)
                {
                
                if (!textBox1_name_form3.Text.Equals("") && textBox2_contactNo_form3.Text.Equals(""))
                    {
                        for (int j = 0; j < textBox1_name_form3.Text.Length; j++)
                        {
                            if (textBox1_name_form3.Text.Length > contactlist[i].Name.Length)
                                break;
                            if (textBox1_name_form3.Text.ToLower()[j].Equals(contactlist[i].Name.ToLower()[j]))
                            {
                                flag = true;
                                count++;
                                continue;
                            }
                        }                  
                    }
                    else
                    {
                        MessageBox.Show("Enter Only Name!!!");
                        textBox1_name_form3.Clear();
                        textBox2_contactNo_form3.Clear();
                        return;
                    }
                    if (count == textBox1_name_form3.Text.Length)
                    {
                        success++;
                        string[] row = new string[] { contactlist[i].Name, contactlist[i].Contact };
                        form5.dataGridView1_SearchDisplay.Rows.Add(row);
                        form5.dataGridView1_SearchDisplay.Height += 18;
                        form5.Width += 22;
                        form5.Height += 22;
                    }
                    count = 0;
                }
                form5.dataGridView1_SearchDisplay.Sort(form5.dataGridView1_SearchDisplay.Columns[0], ListSortDirection.Ascending);
                if (flag==true && success!=0)
                {
                    this.Hide();
                    form5.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Entered Name " + "\"" + textBox1_name_form3.Text + "\"" + " Not Found in The Contact List", "Not Found!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1_name_form3.Clear();
                textBox2_contactNo_form3.Clear();
            }
            catch { }
        }

       
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Close This Window.By Closing This Session Will Be Expired", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Button(object sender, EventArgs e)
        {
            bool flag = false;
            if (textBox1_name_form3.Text.Equals("") && textBox2_contactNo_form3.Text.Equals(""))
            {
                MessageBox.Show("Empty Fields...\nPlease Enter Details...", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int i=0;i<contactlist.Count;i++)
            {
                if (textBox1_name_form3.Text.Equals(contactlist[i].Name) || textBox2_contactNo_form3.Text.Equals(contactlist[i].Contact))
                {
                    flag = true;
                    contactlist.RemoveAt(i);
                    using (FileStream stream = File.Open(user_name + "'s contact.txt", FileMode.Create, FileAccess.Write))
                    {
                        var bformatter = new BinaryFormatter();
                        bformatter.Serialize(stream, contactlist);
                        stream.Close();
                    }
                    MessageBox.Show("Successfuly Deleted", "Found And Deleted!!!");
                    break;
                }
            }
            if(flag==false)
                MessageBox.Show("Entered Name " + "\"" + textBox1_name_form3.Text + "\"" + " Not Found in The Contact List", "Not Found!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1_name_form3.Clear();
            textBox2_contactNo_form3.Clear();
        }
        public bool checkForDuplicateEntry()
        {
            bool flag = false;
            for (int i = 0; i < contactlist.Count; i++)
            {
                if (textBox1_name_form3.Text.ToLower().Equals(contactlist[i].Name))
                {
                    flag = true;
                    MessageBox.Show("Name Already Exist!!!.\nDuplicate Name Cannot Be Saved");
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
