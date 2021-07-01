using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Model
{
    public class Todo
    {
        readonly int todoid;
        string description;
        bool done;
        Person assignee;
        public Todo(int todoid,string description)
        {
            this.todoid = todoid;
            this.description = description;
            //assignee = new Person(1, "Magnus", "Ivarsson");
        }
        public int todoID
        {
            get
            {
                return todoid;
            }
        }
        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }
        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }
    }
}
