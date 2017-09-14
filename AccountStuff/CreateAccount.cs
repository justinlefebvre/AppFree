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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string passwordGen = "";
            for(int i = 0; i < 5; i++){
                passwordGen = RandomPassword.Generate();
            }
            FileOpener fo = new FileOpener();
            fo.DecryptFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "Encryption.bin", "temp.txt");
            File.AppendAllText(@"temp.txt", webSiteTextIn.Text + "," + emailTextIn.Text + "," + passwordGen + Environment.NewLine);
            fo.EncryptFile("temp.txt", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + "Encryption.bin");
            File.Delete("temp.txt");
            
            this.Close();
        }
    }
}
