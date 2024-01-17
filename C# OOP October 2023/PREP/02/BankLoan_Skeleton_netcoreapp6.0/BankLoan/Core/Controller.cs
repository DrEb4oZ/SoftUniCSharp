using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Core
{
    public class Controller : IController
    {
        private IRepository<ILoan> loans;
        private IRepository<IBank> banks;
        private string[] bankTypes = { "BranchBank", "CentralBank" };
        private string[] loanTypes = { "StudentLoan", "MortgageLoan" };
        private string[] clientTypes = { "Student", "Adult" };
        public Controller()
        {
            loans = new LoanRepository();
            banks = new BankRepository();
        }
        public string AddBank(string bankTypeName, string name)
        {
            if (!bankTypes.Contains(bankTypeName))
            {
                throw new ArgumentException(ExceptionMessages.BankTypeInvalid);
            }
            IBank bank = null;
            if (bankTypeName == "BranchBank")
            {
                bank = new BranchBank(name);
            }

            else if (bankTypeName == "CentralBank")
            {
                bank = new CentralBank(name);
            }

            banks.AddModel(bank);
            return string.Format(OutputMessages.BankSuccessfullyAdded, bankTypeName);
        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            if (!clientTypes.Contains(clientTypeName))
            {
                throw new ArgumentException(ExceptionMessages.ClientTypeInvalid);
            }
            IBank bank = banks.FirstModel(bankName);
            IClient client = null;
            if (clientTypeName == "Adult")
            {
                client = new Adult(clientName, id, income);
            }
            else if (clientTypeName == "Student")
            {
                client = new Student(clientName, id, income);
            }
            if (client.GetType().Name == "Adult" && bank.GetType().Name == "CentralBank")   //this part can be done better but its ok for now
            {
                bank.AddClient(client);
                return string.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);

            }
            else if (client.GetType().Name == "Student" && bank.GetType().Name == "BranchBank")
            {
                bank.AddClient(client);
                return string.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);
            }
            else
            {
                return OutputMessages.UnsuitableBank;
            }
        }

        public string AddLoan(string loanTypeName)
        {
            if (!loanTypes.Contains(loanTypeName))
            {
                throw new ArgumentException(ExceptionMessages.LoanTypeInvalid);
            }

            ILoan loan = null;
            if (loanTypeName == "StudentLoan")
            {
                loan = new StudentLoan();
            }
            else if(loanTypeName == "MortgageLoan")
            {
                loan = new MortgageLoan();
            }

            loans.AddModel(loan);
            return string.Format(OutputMessages.LoanSuccessfullyAdded, loanTypeName);
        }

        public string FinalCalculation(string bankName)
        {
            IBank bank = banks.FirstModel(bankName);
            double clientIncome = bank.Clients.Sum(c => c.Income);
            double loanAmount = bank.Loans.Sum(l => l.Amount);
            double total = clientIncome + loanAmount;
            return $"The funds of bank {bankName} are {total:f2}.";

        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            ILoan loanToReturn = loans.FirstModel(loanTypeName);
            if(loanToReturn == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MissingLoanFromType, loanTypeName));
            }
            IBank bank = banks.FirstModel(bankName);
            bank.AddLoan(loanToReturn);
            loans.RemoveModel(loanToReturn);
            return string.Format(OutputMessages.LoanReturnedSuccessfully, loanTypeName, bankName);
        }

        public string Statistics()
        {
            StringBuilder statistics = new StringBuilder();
            foreach (var bank in banks.Models)
            {
                statistics.AppendLine(bank.GetStatistics());
            }

            return statistics.ToString().TrimEnd();
        }
    }
}
