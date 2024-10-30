using dust2dustpart3;
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
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainmenubtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernametb.Text;
                string password = passwordtb.Text;

                LoginAndSignupDAO db_connection = new();

                string procedureResult = db_connection.login(username, password);

                if (procedureResult.StartsWith("Logged"))
                {
                    this.Hide();
                    AccountMenu am = new AccountMenu();
                    am.Show();
                }
               else if (procedureResult.StartsWith("Invalid"))
                {
                    MessageBox.Show("Invalid login. Try Again!");
                }
               else if (procedureResult.Contains("Locked"))
                {
                    MessageBox.Show("Account has been locked. Please contact an admin.");
                }
                    



            }
            catch (Exception ex) 
            {
                MessageBox.Show(string.Format("Error occured.\n{0}", ex.Message));
            }

        }
    }
}
