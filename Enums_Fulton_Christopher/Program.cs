using System;
using System.IO;

namespace Enums_Fulton_Christopher
{

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.May;
            int myBirthDay = 2;
            int myBirthYear = 08;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}
