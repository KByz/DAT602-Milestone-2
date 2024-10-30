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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginMenu lg = new LoginMenu();
            lg.Show();
            this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUpMenu sm = new SignUpMenu();
            sm.Show();
            this.Hide();
        }

        private void contactbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Contact admin@email.com for help with your account."));
        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
