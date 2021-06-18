using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    class EmpPayroll
    {

        //create list typeof employee to store emp infor
        //print list of employess from created list .

        List<Employee> Register = new List<Employee>();

        public void AddEmployee(string name, int salary)
        {
            Register.Add(new Employee(name, salary));

        }

        public void showEmployee()
        {

            foreach (var item in Register)
            {
                Console.WriteLine("name : {0} , salary: {1}", item.Name, item.Salary);
            }
        }
    }
}
