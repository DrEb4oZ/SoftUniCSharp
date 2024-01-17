using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Models.Contracts
{
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
}
