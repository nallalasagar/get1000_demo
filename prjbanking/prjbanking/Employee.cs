using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjbanking
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public void GetEmployee()
        {
            Console.WriteLine("Enter the id");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
        }

    }

    
}
