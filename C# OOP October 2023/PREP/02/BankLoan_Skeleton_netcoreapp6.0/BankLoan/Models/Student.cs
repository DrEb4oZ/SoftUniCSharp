using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public class Student : Client
    {
        public Student(string name, string id, double income) 
            : base(name, id, 2, income)  // 2 is percentage so maybe it must be 0.02
        {
        }

        public override void IncreaseInterest()
        {
            Interest += 1;     // same as above its percentaget so maybe it must be 0.01;
        }
    }
}
