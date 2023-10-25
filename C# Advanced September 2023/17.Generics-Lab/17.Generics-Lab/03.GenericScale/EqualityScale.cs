using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{

    public class EqualityScale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;

        }

        public bool AreEqual(T left, T right)
        {
            return left.CompareTo(right) == 0;
        }

    }
}

