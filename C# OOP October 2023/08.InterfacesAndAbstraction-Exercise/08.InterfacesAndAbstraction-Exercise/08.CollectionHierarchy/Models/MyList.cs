using Collection_Hierarchy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Models
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public MyList() 
            : base()
        {
        }

        public override string Remove()
        {
            string removedElement = myCollection[0];
            myCollection.RemoveAt(0);
            return removedElement;
        }
        public int Used => myCollection.Count;
    }
}
