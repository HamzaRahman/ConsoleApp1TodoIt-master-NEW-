using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;

namespace ConsoleApp1TodoIt.Data
{
    public class TodoItems
    {
        static Todo[] todoitems = new Todo[0];
        public int Size()
        {
            return todoitems.Length;
        }
        public Todo[] FindAll()
        {
            return todoitems;
        }
        public Todo FindByID(int todoid)
        {
            Todo todo = new Todo(0, "MM");
            foreach (var p in todoitems)
            {
                if (p.todoID == todoid)
                {
                    return p;
                }

            }
            return todo;
        }
        public Todo AddTodo(string Desc, bool status, Person pi)
        {
            int size = Size();
            size = size + 1;
            Array.Resize<Todo>(ref todoitems, size);
            int ID = TodoSequencer.nextTodoid();
            Todo p = new Todo(ID, Desc);
            p.Done = status;
            p.Assignee = pi;
            todoitems[size - 1] = p;
            return p;
        }
        public void Clear()
        {
            todoitems = new Todo[0];
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            //here we take new size variable for a new Todo array
            //in which the matching done status items will  be stored
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                if (t.Done == doneStatus)
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
        public Todo[] FindByAssignee(int personid)
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                if (t.Assignee.PersonID == personid)
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                //To check if this person is same as we want, we compare its ID, FirstName and LastName
                if ((t.Assignee.PersonID == assignee.PersonID) && (t.Assignee.FirstName == assignee.FirstName)
                    && (t.Assignee.LastName == assignee.LastName))
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
    }
}
