using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN703_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int num;
            string numstring;

            //Loop
            do
            {
                //User Input
                Console.WriteLine("Enter a negative number:");
                numstring = Console.ReadLine();
                num = Convert.ToInt32(numstring);
            }
            while (num >= 0);
        }
    }
}
