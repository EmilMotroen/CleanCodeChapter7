using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeChapter7
{
    public class Employee
    {
        private string name;
        private double pay;
        private static List<Employee> employees = new List<Employee>();

        public Employee(string name, double pay)
        {
            this.name = name;
            this.pay = pay;
            employees.Add(this);
        }

        public double GetPay()
        {
            return pay;
        }

        public static List<Employee> GetEmployees()
        {
            if (employees.Count == 0) 
            {
                return [];  // Return an empty list if the employees list is empty
            }
            
            return employees;
        }
    }
}
