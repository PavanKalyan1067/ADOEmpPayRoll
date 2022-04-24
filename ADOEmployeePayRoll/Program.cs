using System;
using ADO_Employee_Payroll;

namespace ADOEmployeePayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO Employee Pay Roll");

            //Create oobject for Employee Repository
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetSqlData();
        }
    }
}
