using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dust2dustpart3
{
        public class Game
        {
            private int? _gameID;
            private string? _runtime;
            private string? _status;



            // Class statics
            public static Game? CurrentGame { get; set; }

            public static List<Game> lcGames = new List<Game>();

            // Control
            public Boolean Update = false;
            public Then? then;

        // Properties
            public int? gameID
            {
                get { return _gameID; }
                set
                {
                    _gameID = value;
                    //if (Update) updateData();
                }
            }
            public string? runtime
            {
                get { return _runtime; }
                set
                {
                    _runtime = value;
                   // if (Update) updateData();
                }
            }

            public string? status
            {
                get { return _status; }
                set
                {
                    _status = value;
                   // if (Update) updateData();
                }
            }

        public string? username { get; internal set; }

        // Editor GUI
        public void Edit(Then pRunNext)
        {
            then = pRunNext;
            EditAccount editor = new EditAccount();
            editor.Show();
        }

        public void UpdateData()
        {
            if (this.Update == true)
            {
               // this.updateData();
                if (this.gameID == Game.CurrentGame.gameID)
                {
                    Game.CurrentGame.Update = false;
                    Game.CurrentGame.gameID = this.gameID;
                    Game.CurrentGame.runtime = this.runtime;
                    Game.CurrentGame.status = this.status;
                }
                this.Update = false;
            }
        }
       
        /*
        private void newGame()
        {
            if (_gameID != null)
            {
                clsGameDAO dbAccess = new clsGameDAO();
                dbAccess.NewGame(_gameID, _runtime, _status);
            }

        } */

    }
    public class Map
    {
        private int? _mapID;
        private int? _gameID;

    }
    public class Tile
    {
        private int? _tileID;
        private int? _mapID;
        private int? _row;
        private int? _col;
        private int? _tileType;
        private int? _npcID;
        private int? _itemID;
        private string? _username;
        private TimeSpan? _movementTimer;
    }
}
