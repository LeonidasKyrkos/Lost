using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            string recalCode;
            string correctCode;

            x = "4 8 15 16 23 42";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the core calibration sequence, then press Return:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            recalCode = Console.ReadLine();
            Console.WriteLine("");

            if (recalCode == correctCode)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recalibrating energy core ... Complete. Press Return to exit.");
                Console.ReadLine();
                string genius = "http://i.imgur.com/1WzX9.gif";
                System.Diagnostics.Process.Start(genius);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failure! Press Return to exit and implode.");
                Console.Beep();
                Console.ReadLine();
                string idiot = "http://i.imgur.com/vrbGkUY.gif";
                System.Diagnostics.Process.Start(idiot);
            }
        }
    }
}
