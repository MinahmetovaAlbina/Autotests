using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    public class AccauntData
    {
        public AccauntData(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
}
}
