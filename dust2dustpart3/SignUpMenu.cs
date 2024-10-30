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
    public partial class SignUpMenu : Form
    {
        public SignUpMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void mainmenubtn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernametb.Text;
                string email = emailtb.Text;
                string password = passwordtb.Text;
                string firstName = firstnametb.Text;

                LoginAndSignupDAO db_connection = new();

                string procedureResult = db_connection.signup(username, email, password, firstName);

                if (procedureResult.StartsWith("Account"))
                {
                    MessageBox.Show(string.Format("Account Created!"));
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured.\n{0}", ex.Message));
            }

        }

        private void firstnametb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
