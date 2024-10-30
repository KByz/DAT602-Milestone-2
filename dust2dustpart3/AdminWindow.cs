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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            AccountMenu am = new AccountMenu();
            am.Show();
            this.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUpMenu sg = new SignUpMenu();
            sg.Show();
            this.Close();
        }

        private void allaccountsbtn_Click(object sender, EventArgs e)
        {
            PlayerAccounts pa = new PlayerAccounts();
            pa.Show();
            this.Close();
        }

        private void gamesbtn_Click(object sender, EventArgs e)
        {
            ActiveGames ag = new ActiveGames();
            ag.Show();
            this.Hide();
        }
    }
}
