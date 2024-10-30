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
    public partial class ActiveGames : Form
    {
        public ActiveGames()
        {
            InitializeComponent();
            clsGameDAO clsGameDAO = new clsGameDAO();

            List<Game> Game = clsGameDAO.GamesAndPlayers();

            gamesDGV.DataSource = Game;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void killbtn_Click(object send, EventArgs e)
        {
            if (gamesDGV.SelectedRows.Count > 0)
            {

                Game selectedGame = (Game)gamesDGV.SelectedRows[0].DataBoundItem;

                int? gameID = selectedGame.gameID;

                AdminDAO AdminDAO = new AdminDAO();

                AdminDAO.KillGame(selectedGame.gameID);

                MessageBox.Show("Game has been killed!");

                gamesDGV.Update();
                gamesDGV.Refresh();
            }

        }

        private void gamesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clsGameDAO clsGameDAO = new clsGameDAO();
                List<Game> game = clsGameDAO.GamesAndPlayers();
                gamesDGV.DataSource = game;
            }
        }
    }
}

