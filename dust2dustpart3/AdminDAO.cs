using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dust2dustpart3
{
    internal class AdminDAO : DatabaseAccessObject
    {
        public void DeleteAccount(string username)
        {
            try
            {
                List<MySqlParameter> procedure_params = new()
                {
                    new()
                    {

                        ParameterName = "@username",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = username
                    }
                };

                MySqlHelper.ExecuteDataset(MySqlConnection, "call delete_account(@username)", procedure_params.ToArray());
             }
             catch (Exception ex)
            {
              throw ex;
            }



        }

        public void BanAccount(string username)
        {
            try
            {
                List<MySqlParameter> procedure_params = new()
                {
                    new()
                    {

                        ParameterName = "@username",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = username
                    }
                };
                MySqlHelper.ExecuteDataset(MySqlConnection, "call ban_account(@username)", procedure_params.ToArray());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void UnbanAccount(string username)
        {
            try
            {
                List<MySqlParameter> procedure_params = new()
                {
                    new()
                    {

                        ParameterName = "@username",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = username
                    }
                };
                MySqlHelper.ExecuteDataset(MySqlConnection, "call unban_account(@username)", procedure_params.ToArray());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void KillGame(int? gameID_para)
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
                    }
                };

                MySqlHelper.ExecuteDataset(MySqlConnection, "call kill_game(@gameID)", procedure_params.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
