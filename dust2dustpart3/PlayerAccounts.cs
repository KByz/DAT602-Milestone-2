using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dust2dustpart3
{
    public partial class PlayerAccounts : Form
    {
        public PlayerAccounts()
        {
            InitializeComponent();
            clsUserDAO clsUserDAO = new clsUserDAO();

            // Retrieve the user data
            List<User> User = clsUserDAO.GetAllUsers();

            // Set the DataGridView's data source
            accountsDGV.DataSource = User;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clsUserDAO userDAO = new clsUserDAO();
                List<User> user = userDAO.GetAllUsers();
                accountsDGV.DataSource = user;
            }
        }

        private void PlayerAccounts_Load(object sender, EventArgs e)
        {

        }

        private void accountDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                User selectedUser = (User)accountsDGV.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void accountsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (accountsDGV.SelectedRows.Count > 0)
            {
                User selectedUser = (User)accountsDGV.SelectedRows[0].DataBoundItem;

                string username = selectedUser.username;

                AdminDAO adminDAO = new AdminDAO();

                adminDAO.DeleteAccount(selectedUser.username);

                MessageBox.Show("Account Deleted!");

                accountsDGV.Update();
                accountsDGV.Refresh();
            }
            
        }

        private void editaccountbtn_Click(object sender, EventArgs e)
        {
            EditAccount ea = new EditAccount();
            ea.Show();
            this.Hide();
        }

        private void banbtn_Click(object sender, EventArgs e)
        {
            if (accountsDGV.SelectedRows.Count > 0)
            {
                User selectedUser = (User)accountsDGV.SelectedRows[0].DataBoundItem;

                string username = selectedUser.username;

                AdminDAO adminDAO = new AdminDAO();

                adminDAO.BanAccount(selectedUser.username);

                MessageBox.Show("Account Banned!");

                accountsDGV.Update();
                accountsDGV.Refresh();
            }

        }

        private void unbanbtn_Click(object sender, EventArgs e)
        {
            if (accountsDGV.SelectedRows.Count > 0)
            {
                User selectedUser = (User)accountsDGV.SelectedRows[0].DataBoundItem;

                string username = selectedUser.username;

                AdminDAO adminDAO = new AdminDAO();

                adminDAO.UnbanAccount(selectedUser.username);

                MessageBox.Show("Account Unbanned!");

                accountsDGV.Update();
                accountsDGV.Refresh();
            }

        }
    }
}
