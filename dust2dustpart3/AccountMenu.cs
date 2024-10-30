using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dust2dustpart3
{
    public partial class AccountMenu : Form
    {
        public AccountMenu()
        {
            InitializeComponent();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            EditAccount ea = new EditAccount();
            ea.Show();
            this.Close();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }
    }
}
