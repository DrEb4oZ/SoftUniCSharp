using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }
        public List<Person> FamilyPerson
        {
            get
            {
                return this.family;
            }

            set
            {
                this.family = value;
            }
        }

        public void AddMember(Person person)
        {
            FamilyPerson.Add(person);
        }

        public Person GetOldestMember()
        {
            int oldestAge = int.MinValue;
            Person oldest = null;
            foreach (Person person in family)
            {
                if (person.Age > oldestAge) 
                {
                    oldestAge = person.Age;
                    oldest = person;
                }
            }

            return oldest;

            // return this.People.MaxBy(p => p.Age);  // better variant from lector
        }
    }
}
