using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0Logic
{
    class AccountLogin : ILogin
    {
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class AccountCreation : AccountLogin
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
