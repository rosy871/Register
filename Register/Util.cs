using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public static class Util
    {

        internal static string AskForString(string v)
        {
            string name;
            bool success = false;
            do
            {
                Console.Write(v);
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter something");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return name;

        }

        internal static int AskForInt(string v)
        {
            int salary;
            bool success = false;
            do
            {
                Console.Write(v);
                string input = Console.ReadLine();
                success = int.TryParse(input, out salary) && salary > 0;
                Console.WriteLine(success);

                if (!success)
                {
                    Console.WriteLine("incorrect input..type number that is greater than 0");
                }


            } while (!success);

            return salary;

        }

    }
}
