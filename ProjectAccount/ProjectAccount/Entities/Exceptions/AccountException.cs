using System;
namespace ProjectAccount.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {

        }
    }
}
