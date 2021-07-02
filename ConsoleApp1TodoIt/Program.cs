using System;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;
//using Person.Model;


namespace ConsoleApp1TodoIt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Person p1 = new Person(1,"Magnus", "Ivarson");

            People p = new People();

            bool Run = true;
            while(Run)
            {
                Console.WriteLine("Enter 1 To Add A Person");
                
                Console.WriteLine("Enter 5 To Exit Menu");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string Fn = Console.ReadLine();
                        Console.WriteLine("Enter last Name");
                        string Ln = Console.ReadLine();
                        p.AddPerson(Fn, Ln);
                        break;
                    case 5:
                        Run = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice, Press Anything To Continue To Menu");
                        Console.ReadLine();
                        break;     
                }
                Console.Clear();
            }
        }


    }
}
