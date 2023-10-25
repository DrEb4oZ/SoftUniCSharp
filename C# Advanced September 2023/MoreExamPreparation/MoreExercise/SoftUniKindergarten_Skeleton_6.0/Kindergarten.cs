using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Child> Registry { get; set; }

        public int ChildrenCount
        {
            get
            {
                return Registry.Count;
            }
        }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] childNameTokens = childFullName
                .Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string firstNameInput = childNameTokens[0];
            string secondNameInput = childNameTokens[1];

            return Registry.Remove(Registry.FirstOrDefault(ch => ch.FirstName == firstNameInput && ch.LastName == secondNameInput));
        }


        public Child GetChild(string childFullName)
        {
            string[] childNameTokens = childFullName
                .Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string firstNameInput = childNameTokens[0];
            string secondNameInput = childNameTokens[1];

            return Registry.FirstOrDefault(ch => ch.FirstName == firstNameInput && ch.LastName == secondNameInput);
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (Child child in Registry.OrderByDescending(ch => ch.Age).ThenBy(ch => ch.LastName).ThenBy(ch => ch.FirstName))
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
