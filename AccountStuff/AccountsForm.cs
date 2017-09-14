using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountStuff
{
    public partial class AccountsForm : Form
    {
        private FileOpener fo = new FileOpener();
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AccForm = new CreateAccount();
            AccForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fo.DecryptFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "Encryption.bin", "temp.txt");
            DataTable dt = new DataTable();
            dt.Columns.Add("Website");
            dt.Columns.Add("Email");
            dt.Columns.Add("Password");

            string[] lines = File.ReadAllLines("temp.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                dt.Rows.Add(parts[0], parts[1], parts[2]);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            File.Delete("temp.txt");
        }
    }
}
