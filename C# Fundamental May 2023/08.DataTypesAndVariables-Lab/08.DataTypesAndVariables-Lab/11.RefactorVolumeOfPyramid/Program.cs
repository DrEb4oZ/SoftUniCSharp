namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pyramidLenght = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double pyramidWidth = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double pyramidHeight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double V = (pyramidLenght * pyramidWidth * pyramidHeight) / 3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}