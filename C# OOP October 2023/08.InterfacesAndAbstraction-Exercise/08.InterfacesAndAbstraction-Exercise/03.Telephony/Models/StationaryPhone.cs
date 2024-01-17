using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        private const string InvalidPhonenumberException = "Invalid number!";
        public string Call(string phonenumber)
        {
            if (phonenumber.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException(InvalidPhonenumberException);
            }
            return $"Dialing... {phonenumber}";
        }
    }
}
