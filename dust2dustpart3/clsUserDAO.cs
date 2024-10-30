using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace dust2dustpart3
{
    internal class clsUserDAO : DatabaseAccessObject
    {
        public List<User> GetAllUsers()
        {
            List<User> lcUsers = new List<User>();

            var all_accounts = MySqlHelper.ExecuteDataset(MySqlConnection, "call all_accounts()");
            lcUsers = (from aResult in System.Data.DataTableExtensions.AsEnumerable(all_accounts.Tables[0])
            select
                new User
                  {
                   username = Convert.ToString(aResult["username"]),
                   email = Convert.ToString(aResult["email"]),
                   password = Convert.ToString(aResult["password"]),
                   firstName = Convert.ToString(aResult["firstName"]),
                   accountType = Convert.ToString(aResult["accountType"]),
                   status = Convert.ToString(aResult["status"]),
                   attempts = Convert.ToInt32(aResult["attempts"])
                  }).ToList();
         
            return lcUsers;
        }

        public string Update(string username_para, string newusername_para, string newemail_para, string newpassword_para, string newfirstName_para)
        {
            try
            {
                List<MySqlParameter> procedure_params = new()
                    {
                    new()
                    {
                        ParameterName = "@username",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 50,
                        Value = username_para
                    },
                    new()
                    {
                        ParameterName = "@newusername",
                        MySqlDbType= MySqlDbType.VarChar,
                        Size = 50,
                        Value = newusername_para
                    },
                    new()
                    {
                        ParameterName = "@email",
                        MySqlDbType= MySqlDbType.VarChar,
                        Size = 255,
                        Value = newemail_para

                    },
                    new()
                    {
                        ParameterName = "@password",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 100,
                        Value = newpassword_para
                    },
                    new()
                    {
                        ParameterName = "@firstName",
                        MySqlDbType= MySqlDbType.VarChar,
                        Size = 100,
                        Value = newfirstName_para
                    }


                };
                foreach (var param in procedure_params.ToArray())
                {
                    Console.WriteLine(param.Value);
                }

                DataSet register_result = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call edit_account(@username, @newusername, @email, @password, @firstName)", procedure_params.ToArray());


                return register_result.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void Update(string username, string? email, string password, string? firstName, string? accountType, string? status, int attempts)
        {
            throw new NotImplementedException();
        }

        
    }
}

