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
            TodoItems t = new TodoItems();

            bool Run = true;
            while(Run)
            {
                Console.WriteLine("Enter 1 To Add A Person");
                Console.WriteLine("Enter 2 To Find A Person By ID");
                Console.WriteLine("Enter 3 To Show All Person");
                Console.WriteLine("Enter 4 To Show Number of Person");
                Console.WriteLine("Enter 5 To Delete All Person");

                Console.WriteLine("Enter 6 To Add A Todo Item");
                Console.WriteLine("Enter 7 To Find A Todo Item By ID");
                Console.WriteLine("Enter 8 To Show All Todo Item");

                Console.WriteLine("Enter 10 To Exit Menu");
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
                    //Task 8 f.    
                    case 5:
                        p.Clear();
                        Console.WriteLine("Deleted\nPress Enter To Continue To Menu");
                        Console.ReadLine();
                        break;

                    //Task 9 e.
                    case 6:
                        Console.WriteLine("Enter Description");
                        string desc = Console.ReadLine();
                        Console.WriteLine("Enter Person's ID to Assign Him This Todo Item");
                        ID = Convert.ToInt32(Console.ReadLine());
                        pById = p.FindByID(ID);
                        if (pById.PersonID == 0)
                        {
                            Console.WriteLine("Person Does Not Exist In The List.\n Please Add This Person First In The List");
                            Console.WriteLine("Press Anything To Continue To Menu");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Is This Todo Item Task Completed Or In-Progress ?");
                            Console.WriteLine("Enter 1 For Yes\n Enter 2 For No");
                            var c = Convert.ToInt32(Console.ReadLine());
                            bool donestatus;
                            if(c==1)
                            {
                                donestatus = true;
                            }
                            else
                            {
                                donestatus = false;
                            }
                            t.AddTodo(desc, donestatus, pById);
                            Console.WriteLine("Todo Item Added\nPress Enter To Continue To Menu");
                            Console.ReadLine();
                            Console.ReadLine();
                        }
                        break;
                    //Task 9 d.
                    case 7:
                        Console.WriteLine("Enter The Todo Item's ID To Find That Todo Item");
                        ID = Convert.ToInt32(Console.ReadLine());
                        Todo tById = t.FindByID(ID);
                        if (tById.todoID == 0)
                        {
                            Console.WriteLine("Person Does Not Exist In The List.");
                            Console.WriteLine("Press Anything To Continue To Menu");
                            Console.ReadLine();
                        }
                        else
                        {
                            string status = Convert.ToString(tById.Done);
                            Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                            Console.WriteLine("{0}   {1}           {2}             {3}", ID, tById.Description, status, tById.Assignee.FirstName);
                            Console.WriteLine("Press Enter To Continue To Menu");
                            Console.ReadLine();
                        }
                        break;
                    //Task 9 c.
                    case 8:
                        Todo[] todoitems = t.FindAll();
                        Console.WriteLine("ID. Description. Completed Status. Assignee's FirstName");
                        foreach (var d in todoitems)
                        {
                            string id = Convert.ToString(d.todoID);
                            Console.WriteLine("{0}   {1}           {2}             {3}", id, d.Description, d.Done, d.Assignee.FirstName);
                        }
                        Console.WriteLine("Press Enter To Continue To Menu");
                        Console.ReadLine();
                        break;

                    case 10:
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
