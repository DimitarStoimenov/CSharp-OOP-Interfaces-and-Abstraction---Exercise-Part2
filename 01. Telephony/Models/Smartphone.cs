namespace Telephony
{
    using System;
    using System.Linq;
    using Telephony.Contracts;
    using Telephony.Exceptions;
    public class Smartphone : ICallable, IBrowsable
    {
        

        public string Call(string number)
        {
            if (!number.All(x => Char.IsDigit(x)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumberExeption);
            }
            return number.Length == 10 ? $"Calling... {number}" : $"Dialing... {number}";

        }
        public string Browse(string url)
        {
            if (url.Any(s => char.IsDigit(s)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidUrlExeption);
            }
            return $"Browsing: {url}!";

        }

    }
}
