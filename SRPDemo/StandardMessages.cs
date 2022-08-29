using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Application");
        }
        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give a valid { fieldName }!"); 
        }
    }
}
