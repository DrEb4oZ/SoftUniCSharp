using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        private const string InvalidPhonenumberException = "Invalid number!";
        private const string InvalidURLException = "Invalid URL!";

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException(InvalidURLException);
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phonenumber)
        {
            if (phonenumber.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException(InvalidPhonenumberException);
            }
            return $"Calling... {phonenumber}";
        }
    }
}
