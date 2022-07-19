using System;
namespace Destructor
{
    class Employee
    {
        private int _empld;
        private String _empName;
        private int _age;
        private double _salary;
        Employee(int empld, string empName, int age, double salary)
        {
            this._empld = empld;
            this._empName = empName;
            this._age = age;
            this._salary = salary;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee calles");
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"John",45,35000);
            Console.WriteLine("Employee ID: " + emp._empld);
            Console.WriteLine("Employee Name: " + emp._empName);
            Console.WriteLine("Age:"+emp._age);
            Console.WriteLine("Salary: " + emp._salary);
        }
   }
}