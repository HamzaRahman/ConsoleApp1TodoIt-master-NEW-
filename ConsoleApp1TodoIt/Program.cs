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
                Console.WriteLine("Enter 2 To Find A Person By ID");
                Console.WriteLine("Enter 3 To Show All Person");
                Console.WriteLine("Enter 4 To Show Number of Person");
                Console.WriteLine("Enter 5 To Exit Menu");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //Task 8 e.
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string Fn = Console.ReadLine();
                        Console.WriteLine("Enter last Name");
                        string Ln = Console.ReadLine();
                        p.AddPerson(Fn, Ln);
                        break;
                    //Task 8 d.
                    case 2:
                        Console.WriteLine("Enter The Person's ID To Find That Person");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Person pById = p.FindByID(ID);
                        if(pById.PersonID == 0)
                        {
                            Console.WriteLine("Person Does Not Exist In The List.");
                            Console.WriteLine("Press Anything To Continue To Menu");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("ID. First Name. Last Name");
                            Console.WriteLine("{0}   {1}          {2}", ID, pById.FirstName, pById.LastName);
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                        }
                        break;
                    //Task 8 c.
                    case 3:
                        Person[] people = p.FindAll();
                        Console.WriteLine("ID. First Name. Last Name");
                        foreach (var d in people)
                        {
                            string id = Convert.ToString(d.PersonID);
                            Console.WriteLine("{0}   {1}          {2}", id, d.FirstName, d.LastName);
                        }
                        Console.WriteLine("Press Enter To Continue To Menu");
                        Console.ReadLine();
                        break;
                    //Task 8 b.
                    case 4:
                        string Size = Convert.ToString(p.Size());
                        Console.WriteLine("The Number of People is:{0}", Size);
                        Console.WriteLine("Press Enter To Continue To Menu");
                        Console.ReadLine();
                        break;
                    case 5:
                        Run = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice, Press Enter To Continue To Menu");
                        Console.ReadLine();
                        break;     
                }
                Console.Clear();
            }
        }


    }
}
