using System;

namespace eDentist.WebAPI.Exceptions
{
    public class UserException : Exception
    {
        public UserException(string message) :
            base(message)
        {

        }
    }
}
