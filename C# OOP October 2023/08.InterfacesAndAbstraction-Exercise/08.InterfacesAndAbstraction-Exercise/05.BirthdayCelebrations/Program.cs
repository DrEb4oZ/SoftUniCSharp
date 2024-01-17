using BirthdayCelebrations.Core;
using BirthdayCelebrations.IO;
using BirthdayCelebrations.IO.Interfaces;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();
        }
    }
}