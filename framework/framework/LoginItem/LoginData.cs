using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Login
{
    class LoginData
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Expected { get; private set; }


        public LoginData(string login, string password, string expected)
        {
            Login = login;
            Password = password;
            Expected = expected;
        }
    }
}
