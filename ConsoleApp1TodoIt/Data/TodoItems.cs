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
                if ((t.Assignee.FirstName == assignee.FirstName)
                    && (t.Assignee.LastName == assignee.LastName))
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
        public Todo[] FindUnassignedTodoItems()//10 d
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                //To check if this person is same as we want, we compare its ID, FirstName and LastName
                if (t.Assignee == null)
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
        public Todo[] RemoveTodo(int todoid)//11 a
        {
            int size = 0;
            Todo[] TD = new Todo[0];
            //Here we run a foreach loop on todoitems array
            foreach (var p in todoitems)
            {
                //Then we compare our wanted ID with every Todo ID
                if (p.todoID != todoid)
                {
                    //if its not found then it will be stored in TD array
                    size = size + 1;
                    Array.Resize<Todo>(ref TD, size);
                    TD[size - 1] = p;
                }
            }
            //Now we copy TD array to todoitems array
            Array.Copy(TD, todoitems, size);
            //returning TD array
            return TD;
        }
    }
}
