using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] commandArguments = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = commandArguments[0];


            Type commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType == null )
            {
                throw new InvalidOperationException("Command not found");
            }

            ICommand commandInstance = (ICommand)Activator.CreateInstance(commandType);
            string result = commandInstance.Execute(commandArguments.Skip(1).ToArray());
            
            return result;
        }
    }
}
