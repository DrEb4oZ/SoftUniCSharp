using Collection_Hierarchy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        protected List<string> myCollection;
        public AddCollection()
        {
            this.myCollection = new List<string>();
        }

        public virtual int Add(string input)
        {
            myCollection.Add(input);
            return myCollection.Count - 1;
        }
    }
}
