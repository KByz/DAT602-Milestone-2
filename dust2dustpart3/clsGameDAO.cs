using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dust2dustpart3
{
    internal class clsGameDAO : DatabaseAccessObject
    {
        public List<Game> ActiveGames(int gameID_para, string runtime_para, string status_para)
        {
            List<Game> lcGames = new List<Game>();

            var active_games = MySqlHelper.ExecuteDataset(MySqlConnection, "call active_games()");
            lcGames = (from aResult in System.Data.DataTableExtensions.AsEnumerable(active_games.Tables[0])
                       select
                       new Game
                       {
                           gameID = Convert.ToInt32(aResult["gameID"]),
                           runtime = Convert.ToString(aResult["runtime"]),
                           status = Convert.ToString(aResult["status"]),

                       }).ToList();

            return lcGames;
        }


        public static List<Game> GamesAndPlayers() 
        {
            List<Game> lcGames = new List<Game>();

            try
            {

                var games_and_players = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call get_game_and_players()");

                if (games_and_players.Tables.Count > 0 && games_and_players.Tables[0].Rows.Count > 0)
                {
                    lcGames = (from aResult in System.Data.DataTableExtensions.AsEnumerable(games_and_players.Tables[0])
                               select new Game
                               {
                                   gameID = Convert.ToInt32(aResult["gameID"]),
                                   username = Convert.ToString(aResult["username"])
                               }).ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error!: " + ex.Message);
                throw; 
            }
            return lcGames;
        }



        /*
        public string NewGame(int gameID_para, TimeSpan runtime_para, string status_para)
        {
            try
            {
                List<MySqlParameter> procedure_params = new()
        {
          new()
          {
             ParameterName = "@gameID",
             MySqlDbType = MySqlDbType.Int32,
             Value = gameID_para
          },
          new()
          {
          ParameterName = "runtime",
          MySqlDbType = MySqlDbType.Time,
          Value = runtime_para

          },
          new()
          {
           ParameterName= "@status",
           MySqlDbType = MySqlDbType.VarChar,
           Size = 25,
            Value = status_para
          }
         };

                foreach (var param in procedure_params.ToArray())
                {
                    Console.WriteLine(param.Value);
                }

                DataSet register_result = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call new_game(@gameID, @runtime, @status)", procedure_params.ToArray());


                return register_result.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            internal void NewGame(int gameID_para, TimeSpan runtime_para, string status_para)
            {
                throw new NotImplementedException();
            }
        } */
    } 
}

