using System.ComponentModel.Design;
using System.Text.RegularExpressions;
/*
3
##InvaliDiteM##
@InvalidIteM@
@#Invalid_IteM@#


1
@#FasdddF3fdfd@#AAssdFg@#
*/
namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int barcodeCount = int.Parse(Console.ReadLine());
            string barcodesRegex = @"[@][#]{1,}[A-Z][0-9a-zA-Z]{4,}[A-Z][@][#]{1,}";

            for (int i = 0; i < barcodeCount; i++)
            {
                string currentBarcode = Console.ReadLine();
                Regex validBarcode = new Regex(barcodesRegex);
                string productGroup = string.Empty;
                if (validBarcode.IsMatch(currentBarcode))
                {
                    MatchCollection validMatches = Regex.Matches(currentBarcode, barcodesRegex);
                    foreach (Match match in validMatches)
                    {

                        if (!match.Value.Any(x => char.IsDigit(x)))
                        {
                            productGroup = "00";
                        }

                        else
                        {
                            foreach (char item in currentBarcode)
                            {
                                if (char.IsDigit(item))
                                {
                                    productGroup += item;
                                }
                            }
                        }

                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}