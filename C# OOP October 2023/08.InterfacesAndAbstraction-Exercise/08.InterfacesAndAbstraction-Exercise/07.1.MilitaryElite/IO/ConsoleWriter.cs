using MilitaryElite.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(object obj) => Console.WriteLine(obj);
    }
}
