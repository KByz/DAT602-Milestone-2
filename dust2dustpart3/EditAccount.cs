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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountMenu am = new AccountMenu();
            am.Show();
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = oldusernametb.Text;
                string newusername = newusernametb.Text;
                string newemail = newemailtb.Text;
                string newpassword = newpasswordtb.Text;
                string newfirstName = newfirstnametb.Text;

                clsUserDAO db_connection = new();

                string procedureResult = db_connection.Update(username, newusername, newemail, newpassword, newfirstName);

                if (procedureResult.StartsWith("Account"))
                {
                    MessageBox.Show(string.Format("Details Saved!"));
                    this.Hide();
                    AccountMenu game = new AccountMenu();
                    game.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured.\n{0}", ex.Message));
            }
            AccountMenu am = new AccountMenu();
            am.Show();
            this.Close();
        }

        private void oldusernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldusernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
