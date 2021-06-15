using System;
using System.Collections.Generic;

namespace Register
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonalRegister> regs = new List<PersonalRegister>();
            
            
            int ch=1;
            do {

                if (ch == 1)
                {
               
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter salary: ");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    PersonalRegister reg = new PersonalRegister();

                    reg.setNamn(name);
                    reg.setLon(salary);



                    regs.Add(reg);

                }
                else if(ch == 2) {

                 
                    foreach (var person in regs)
                        Console.WriteLine(person.getNamn() + "\t " + person.getLon());


                }
                              
                Console.WriteLine("\nPress 1 to Enter Personal info:");
                Console.WriteLine("Press 2 to list Personal info:");
                Console.WriteLine("Press 3 to Exit Personal info:");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch < 3);

                
            

            

           


           


        }
    }
}
