using BorderControl.Core;
using BorderControl.Core.Interfaces;
using BorderControl.IO;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();


            // after checking Georgi Inkov solution -> ICitizen and IRobot is irrelevant, I don`t use it anywhere so I don`t need it. In the business logic there is a method EndsWith() - which returns boolean, checking if string end is the same with another one -> returns true or false. Overall my solution is not that bad. But still I need to keep in mind how to properly use Interfaces and to remember the new (for me) method EndsWith() - and check for things like that in the future
        }
    }
}