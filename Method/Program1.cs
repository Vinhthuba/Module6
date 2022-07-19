using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Program1
    {
        static void Main(string[] args)
            Book objBook = new Book();
            objBook.Input("C# the complete Reference");
            Console.WriteLine(objBook.Print());
            Console.ReadKey();
    }
}
