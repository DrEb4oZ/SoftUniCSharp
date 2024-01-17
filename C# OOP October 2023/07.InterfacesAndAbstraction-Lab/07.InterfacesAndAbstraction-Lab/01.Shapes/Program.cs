using Shapes.Models;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            int width = int.Parse(Console.ReadLine());
            int hegiht = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(width, hegiht);

            circle.Draw();
            rectangle.Draw();
        }
    }
}