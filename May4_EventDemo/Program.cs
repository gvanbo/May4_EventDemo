using System;

namespace May4_EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person myPerson = new Person() { FName = "Mickey", LName = "Mouse" };
            Console.WriteLine($"Created a new Person: {myPerson.FName} {myPerson.LName}");
            myPerson.DOBEvent += DOB_Handle;
            myPerson.DOBEvent += DOB_Handle2; //wire second event

            myPerson.DOB = new DateTime(1925, 5, 05);

        }




        //Created Event Handler
        static void DOB_Handle(Person p)
        {
            int days = DateTime.Today.DayOfYear - p.DOB.DayOfYear;

            if (days > 0) Console.WriteLine($"Sorry, we missed your birthday.");
            if (days < 0) Console.WriteLine($"{p.FName} {p.LName}, Your birthday is in {Math.Abs(days)} days.");
            else Console.WriteLine($"Happy Birthday {p.FName} {p.LName}");

        }

        static void DOB_Handle2(Person p)
        {
            int days = DateTime.Today.DayOfYear - p.DOB.DayOfYear;

            if (days > 0) Console.WriteLine($"Your Birthday was {days} ago.");
            if (days < 0) Console.WriteLine($"Its true, Your birthday is in {Math.Abs(days)}.");
            else Console.WriteLine("Happy Birthday");

        }
    }
}
