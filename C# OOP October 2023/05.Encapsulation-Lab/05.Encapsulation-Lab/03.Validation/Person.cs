using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        private const string FirstNameLenghtException = "First name cannot contain fewer than 3 symbols!";
        private const string LastNameLenghtException = "Last name cannot contain fewer than 3 symbols!";
        private const string AgeValueException = "Age cannot be zero or a negative integer!";
        private const string SalaryValueException = "Salary cannot be less than 650 leva!";

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(FirstNameLenghtException);
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(LastNameLenghtException);
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(AgeValueException);
                }
                this.age = value;
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException(SalaryValueException);
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                this.Salary *= 1 + percentage / 100 / 2; 
            }

            else
            {
                this.Salary *= 1 + percentage / 100;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
