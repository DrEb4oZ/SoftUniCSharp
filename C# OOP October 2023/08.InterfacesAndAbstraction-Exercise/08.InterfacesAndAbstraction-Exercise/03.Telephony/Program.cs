using System.Text;
using Telephony.Models;
using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phonenumers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICallable callPhone = default;
            foreach (string phonenumber in phonenumers)
            {
                if (phonenumber.Length == 7)
                {
                    callPhone = new StationaryPhone();
                }
                else if (phonenumber.Length == 10)
                {
                    callPhone = new Smartphone();
                }
                try
                {
                    Console.WriteLine(callPhone.Call(phonenumber));

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string url in urls)
            {
                try
                {
                    IBrowsable smarthpone = new Smartphone();
                    Console.WriteLine(smarthpone.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}