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
    public partial class Form4 : Form
    {
        int rowDeleted;
        Form3 form;
        public Form4(Form3 form3)
        {
            form = form3;
            InitializeComponent();
            this.Text = form3.user_name + "'s PhoneBook";
            CreateContextMenu();
        }
        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Delete");
            menuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            menuItem.Name = "Delete";
            menuStrip.Items.Add(menuItem);

            this.ContextMenuStrip = menuStrip;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rowDeleted = dataGridView1_form4.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            MessageBox.Show(dataGridView1_form4.Rows[rowDeleted].Cells["Name"].Value.ToString());
            for (int i = 0; i <form.contactlist.Count; i++)
            {
                if(form.contactlist[i].Name.Equals(dataGridView1_form4.Rows[rowDeleted].Cells["Name"].Value.ToString()))
                    form.contactlist.RemoveAt(i);
            }
            dataGridView1_form4.Rows.RemoveAt(dataGridView1_form4.Rows.GetFirstRow(DataGridViewElementStates.Selected));
            dataGridView1_form4.ClearSelection();

            using (FileStream stream = File.Open(form.user_name + "'s contact.txt", FileMode.Create, FileAccess.Write))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, form.contactlist);
                stream.Close();
            }
        }
    }
}
