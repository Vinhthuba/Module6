using System;

namespace Instantiating
{
    class Program
    {
        static void Main(string[] args)
        {
            House londonHouse = new House { HouseName = "LonDon Street", Members = 3 };
            Console.WriteLine("House Name: {0},Members: {1} ", londonHouse.HouseName, londonHouse.Members);
        }
    }
}