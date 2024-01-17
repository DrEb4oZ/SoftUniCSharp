using WildFarm.Core;
using WildFarm.Core.Interfaces;
using WildFarm.Factory;
using WildFarm.IO;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter(), new AnimalFactory(), new FoodFactory());
            engine.Run();
        }
    }
}