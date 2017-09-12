using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountStuff
{
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            FileOpener fo = new FileOpener();
            
        }
    }
}
