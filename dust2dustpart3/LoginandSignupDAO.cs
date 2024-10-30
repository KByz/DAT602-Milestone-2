using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace dust2dustpart3
{
    internal class LoginAndSignupDAO : DatabaseAccessObject
    {

        public string signup(string username_para, string email_para, string password_para, string firstName_para)
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
                        ParameterName = "@email",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 100,
                        Value = email_para
                    },
                    new()
                    {
                        ParameterName = "@password",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 50,
                        Value = password_para
                    },
                    new()
                    {
                        ParameterName = "@firstName",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 100,
                        Value = firstName_para
                    }


                };

                foreach (var param in procedure_params.ToArray())
                {
                    Console.WriteLine(param.Value);
                }

                DataSet register_result = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call signup(@username, @email, @password, @firstName)", procedure_params.ToArray());


                return register_result.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string login(string username_para, string password_para)
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
                        ParameterName = "@password",
                        MySqlDbType = MySqlDbType.VarChar,
                        Size = 100,
                        Value = password_para
                    }

                };

                DataSet auth_result = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call login(@username, @password)", procedure_params.ToArray());


                DataRow auth_result_row = auth_result.Tables[0].Rows[0];

                return auth_result_row.ItemArray[0].ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}