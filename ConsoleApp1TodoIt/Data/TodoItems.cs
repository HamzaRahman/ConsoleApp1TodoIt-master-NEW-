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
        public Todo AddTodo(string Desc)
        {
            int size = Size();
            size = size + 1;
            Array.Resize<Todo>(ref todoitems, size);
            int ID = TodoSequencer.nextTodoid();
            Todo p = new Todo(ID, Desc);
            todoitems[size - 1] = p;
            return p;
        }
        public void Clear()
        {
            todoitems = new Todo[0];
        }
    }
}
