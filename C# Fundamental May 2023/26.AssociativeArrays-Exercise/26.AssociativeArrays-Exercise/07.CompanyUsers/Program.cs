using System.ComponentModel;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employee> employeesInCompany = new Dictionary<string, Employee>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] currentEntry = input.Split(" -> ");
                string companyName = currentEntry[0];
                string employeeName = currentEntry[1];
                Employee currentEmployee = new Employee(companyName, new List<string>());
                if (!employeesInCompany.ContainsKey(companyName))
                {
                    employeesInCompany.Add(companyName, currentEmployee);
                }

                if (!employeesInCompany[companyName].EmployeeName.Contains(employeeName))
                {
                    employeesInCompany[companyName].EmployeeName.Add(employeeName);
                }
            }
            foreach (var kvp in employeesInCompany.Values)
            {
                Console.Write(kvp);
            }
        }
    }
    public class Employee
    {
        public Employee(string companyName, List<string> employeeName)
        {
            CompanyName = companyName;
            EmployeeName = employeeName;
        }

        public string CompanyName { get; set; }
        public List<string> EmployeeName { get; set; }

        public override string ToString()
        {
            string result = $"{CompanyName}\n";
            foreach (var employee in EmployeeName)
            {
                result += $"-- {employee}\n";
            }
            return result;
        }
    }
}