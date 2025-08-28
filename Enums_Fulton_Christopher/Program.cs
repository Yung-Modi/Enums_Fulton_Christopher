using System;
using System.IO;

namespace Enums_Fulton_Christopher
{
    // Defines an enumeration for months of the year
    // Each month is assigned a number starting at 1 (January = 1, etc.)
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Stores birth date information using the enum for the month
            int myBirthMonth = (int)Months.May;  // May is 5
            int myBirthDay = 2;
            int myBirthYear = 2008;

            // Combines date into a string format
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            // Creates (or overwrite) a file named "myFile.txt" with initial text
            File.WriteAllText("myFile.txt", "This is my text file!\n");

            // Reads and display contents of "myFile.txt"
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Appends more text to the existing file
            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");

            // Displays updated contents of "myFile.txt"
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            // Checks if "newFile.txt" already exists
            if (!File.Exists("newFile.txt"))
            {
                // If it doesn't exist, create it by copying "myFile.txt"
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                // If it does exist, replace "myFile.txt" with "newFile.txt"
                // and create a backup called "backupFile.txt"
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            // Appends the birthday information to "newFile.txt"
            File.AppendAllText("newFile.txt", myBirthDate);

            // Displays the contents of "newFile.txt"
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}

