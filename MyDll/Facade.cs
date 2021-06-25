using System;
using Dapper;

namespace MyDll
{
    public class DapperFacade
    {
        public DapperFacade() { }

        public bool CheckLogin(string login)
        {
            return true;
        }

        public bool Authorize(string login, string pass)
        {
            return true;
        }
    }
}
