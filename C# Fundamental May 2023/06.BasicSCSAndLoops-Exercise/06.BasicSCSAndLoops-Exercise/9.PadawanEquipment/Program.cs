namespace _9.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalPrice = Math.Ceiling(studentCount * 1.1) * lightsaberPrice + studentCount * robePrice + (studentCount - Math.Floor((double)studentCount / 6)) * beltPrice;

            if (moneyAmount >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - moneyAmount;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }

        }
    }
}