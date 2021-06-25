using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyDll
{
    public class DapperFacade : IDapperFacade
    {
        private const string connetionString = "Data Source=server1;Initial Catalog=SupperAppdb;User Id=student;";

        public DapperFacade() { }

        public bool CheckLogin(string login)
        {
            using (IDbConnection conn = new SqlConnection(connetionString))
            {
                if (conn.Query<object>($"EXEC Check_Login {login}").AsList().Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Authorize(string login, string pass)
        {
            using (IDbConnection conn = new SqlConnection(connetionString))
            {
                if (conn.Query<object>($"EXEC Authorize {login}, {pass}").AsList().Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
