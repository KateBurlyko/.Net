using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.LoginData
{
    class LoginDatas
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Expected { get; private set; }


        public LoginDatas(string login, string password, string expected)
        {
            Login = login;
            Password = password;
            Expected = expected;
        }
    }
}
