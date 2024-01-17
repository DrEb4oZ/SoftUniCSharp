using MilitaryElite.Core;
using MilitaryElite.Core.Contracts;
using MilitaryElite.IO;
using System;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();
        }
    }
}