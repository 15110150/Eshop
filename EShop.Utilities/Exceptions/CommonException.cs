using System;

namespace EShop.Utilities.Exceptions
{
    public class CommonException : Exception
    {
        public CommonException()
        {
        }

        public CommonException(string message)
            : base(message)
        {
        }

        public CommonException(string message, CommonException inner)
            : base(message, inner)
        {
        }
    }
}