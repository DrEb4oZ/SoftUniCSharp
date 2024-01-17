using Collection_Hierarchy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public AddRemoveCollection() 
            : base()
        {
        }

        public override int Add(string input)
        {
            myCollection.Insert(0, input);
            return 0;
        }
        public virtual string Remove()
        {
            string removedItem = myCollection[myCollection.Count - 1];
            myCollection.RemoveAt(myCollection.Count - 1);
            return removedItem;
             
        }
    }
}
