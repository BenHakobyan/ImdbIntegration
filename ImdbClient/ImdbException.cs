using System;

namespace ImdbClient
{
    public class ImdbException : Exception
    {
        public ImdbException(string message) : base(message)
        {   }
    }
}
