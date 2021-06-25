using System;
using System.Collections.Generic;
using System.Text;

namespace MyDll
{
    public interface IDapperFacade
    {
        bool CheckLogin(string login);
        bool Authorize(string login, string pass);
    }
}
