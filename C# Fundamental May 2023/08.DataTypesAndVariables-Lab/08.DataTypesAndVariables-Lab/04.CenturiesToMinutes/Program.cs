namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte centuries = byte.Parse(Console.ReadLine());
                ushort years = (ushort)(centuries * 100);
                float days = years * 365.2422f;
                uint hours = (uint)days * 24;
                ulong minutes = (ulong)hours * 60;

                Console.WriteLine($"{centuries} centuries = {years} years = {Math.Floor(days)} days = {hours} hours = {minutes} minutes");
            }
        }
    }
}