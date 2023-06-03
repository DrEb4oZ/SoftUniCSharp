namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int area = RectangleArea(sideA, sideB);
            Console.WriteLine(area);
        }

        static int RectangleArea(int sideA, int sideB)
        {
            return sideA * sideB;
        }
    }
}