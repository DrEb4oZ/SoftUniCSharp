using Collection_Hierarchy.Core.Contracts;
using Collection_Hierarchy.Models;
using Collection_Hierarchy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Hierarchy.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int removeItemCount = int.Parse(Console.ReadLine());

            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            IMyList myList = new MyList();

            Dictionary<string,List<int>> indexes = new Dictionary<string, List<int>>()
            {
                {"AddCollection", new List<int>() },
                {"AddRemoveCollection", new List<int>() },
                {"MyList", new List<int>() },
            };
            Dictionary<string, List<string>> removedStrings = new Dictionary<string, List<string>>()
            {
                {"AddCollection", new List<string>() },
                {"AddRemoveCollection", new List<string>() },
                {"MyList", new List<string>() },
            };

            for (int i = 0; i < input.Length; i++)
            {
                indexes["AddCollection"].Add(addCollection.Add(input[i]));
                indexes["AddRemoveCollection"].Add(addRemoveCollection.Add(input[i]));
                indexes["MyList"].Add(myList.Add(input[i]));
            }

            for (int i = 0; i < removeItemCount; i++)
            {
                removedStrings["AddRemoveCollection"].Add(addRemoveCollection.Remove());
                removedStrings["MyList"].Add(myList.Remove());
            }

            Console.WriteLine(string.Join(" ", indexes["AddCollection"]));
            Console.WriteLine(string.Join(" ", indexes["AddRemoveCollection"]));
            Console.WriteLine(string.Join(" ", indexes["MyList"]));

            Console.WriteLine(string.Join(" ", removedStrings["AddRemoveCollection"]));
            Console.WriteLine(string.Join(" ", removedStrings["MyList"]));
        }
    }
}
