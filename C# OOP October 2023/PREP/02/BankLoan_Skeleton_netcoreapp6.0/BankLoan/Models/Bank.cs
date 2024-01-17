using BankLoan.Models.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
        private string name;
        private int capacity;
        List<ILoan> loans;
        List<IClient> clients;

        protected Bank(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            loans = new List<ILoan>();
            clients = new List<IClient>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BankNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public int Capacity
        {
            get => capacity;
            private set
            {
                capacity = value;
            }
        }

        public IReadOnlyCollection<ILoan> Loans => loans.AsReadOnly();
        
        public IReadOnlyCollection<IClient> Clients => clients.AsReadOnly();

        public void AddClient(IClient Client)
        {
            if(clients.Count == capacity)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughCapacity);
            }
            clients.Add(Client);
        }

        public void AddLoan(ILoan loan)
        {
            loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder statistic = new StringBuilder();
            statistic.AppendLine($"Name: {Name}, Type: {GetType().Name}");
            if (clients.Count == 0)
            {
                statistic.AppendLine("Clients: none");
            }
            else
            {
                statistic.AppendLine($"Clients: {string.Join(", ", clients.Select(c => c.Name))}");
            }
            statistic.AppendLine($"Loans: {loans.Count}, Sum of Rates: {SumRates()}");

            return statistic.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {
            clients.Remove(Client);
        }

        public double SumRates()
        {
            return loans.Sum(l => l.InterestRate);
        }
    }
}
