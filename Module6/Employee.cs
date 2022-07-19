using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnonymousType
{
    class Employee
    {
        public void DisplayDetails(object emp)
        {
            String fname = "";
            String lname = "";
            int age = 0;
            PropertyInfo[] attrs = emp.GetType().GetProperties();
            foreach(PropertyInfo attr in attrs)
            {
                switch (attr.Name)
                {
                    case "FirstName":
                        fname = attr.GetValue(emp, null).ToString();
                        break;
                    case "LastName":
                        lname = attr.GetValue(emp, null).ToString();
                        break;
                    case "Age":
                        age= (int)attr.GetValue(emp, null);
                        break;
                }
            }
            Console.WriteLine("Name:  {0}  {1} ,Age: {2}", fname, lname, age);
        }
    }
}
