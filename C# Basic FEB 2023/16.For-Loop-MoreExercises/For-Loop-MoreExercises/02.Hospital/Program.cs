using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hospitalWorkDays = int.Parse(Console.ReadLine());
            int doctorsCount = 7;
            int dayCounter = 0;
            int patientsSendToAnotherHospital = 0;
            int patientsTreated = 0;
            for (int i = 0; i < hospitalWorkDays; i++)
            {
                dayCounter++;
                if (dayCounter == 3)
                {
                    dayCounter = 0;
                    if (patientsSendToAnotherHospital > patientsTreated)
                    {
                        doctorsCount++;
                    }
                }
                int patientsCount = int.Parse(Console.ReadLine());
                if (patientsCount > doctorsCount)
                {
                    patientsSendToAnotherHospital += patientsCount - doctorsCount;
                    patientsTreated += doctorsCount;
                }
                else
                {
                    patientsTreated += patientsCount;
                }
            }
            Console.WriteLine($"Treated patients: {patientsTreated}.");
            Console.WriteLine($"Untreated patients: {patientsSendToAnotherHospital}.");
        }
    }
}
