using System;

namespace Register
{
    class Program
    {
        static EmpPayroll ep = new EmpPayroll();
        static ConsoleIO ci = new ConsoleIO();

        static void Main(string[] args)
        {
            chooseMenu();
        }

        private static void chooseMenu()
        {
            do
            {
                menuOption();

                switch (ci.readl())
                {
                    case "1":
                        addEmployeeInfo();
                        break;

                    case "2":
                        ep.showEmployee();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        ci.writel("incorrect input, chose again...");
                        break;
                }
            } while (true);

        }

        private static void menuOption()
        {
            ci.writel("\n1. Add Employee Information");
            ci.writel("2. List Employee Information");
            ci.writel("3. Exit");


        }

        private static void addEmployeeInfo()
        {

            do
            {
                ci.writel("Enter 'Q' or'q' to 'Quit' ");
                string name = Util.AskForString("Name:     ");
                if (name == "Q" ||name=="q" )
                    break;
                int salary = Util.AskForInt("Salary:   ");

                ep.AddEmployee(name, salary);
            } while (true);

        }



    }
}
