using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthsCount = int.Parse(Console.ReadLine());
            double totalElectircityBill = 0;
            double totalOtherBill = 0;

            for (int i = 0; i < monthsCount; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                totalElectircityBill += electricityBill;
                totalOtherBill += (electricityBill + 20 + 15) * 1.20;
            }
            double totalMonthBills = totalElectircityBill + monthsCount * 20 + monthsCount * 15 + totalOtherBill;
            double avarageBills = totalMonthBills / monthsCount;
            Console.WriteLine($"Electricity: {totalElectircityBill:f2} lv");
            Console.WriteLine($"Water: {(monthsCount * 20):f2} lv");
            Console.WriteLine($"Internet: {(monthsCount * 15):f2} lv");
            Console.WriteLine($"Other: {totalOtherBill:f2} lv");
            Console.WriteLine($"Average: {avarageBills:f2} lv");
        }
    }
}
