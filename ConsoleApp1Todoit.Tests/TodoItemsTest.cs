using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;
using Xunit;

namespace ConsoleApp1Todoit.Tests
{
    public class TodoItemsTest
    {
        TodoItems p = new TodoItems();
        [Fact]
        public void SizeTest()
        {
            int i = 0;
            int ps = p.Size();
            Assert.Equal(i.GetType(), ps.GetType());
        }

        [Fact]
        public void FindAllTest()
        {
            Todo[] peoples = new Todo[0];
            Todo[] ps = p.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            Person pr = new Person(1, "dd", "ee");
            //To test find by ID, we first store a todo item
            p.AddTodo("mm",true,pr);
            //Then we test to find it by giving its ID
            Todo ps = p.FindByID(ID);
            Assert.Equal(1, ps.todoID);
        }
        [Theory]
        [InlineData("Todo 1")]
        public void AddTest(string Desc)
        {
            Person pr = new Person(1, "dd", "ee");
            Todo ps = p.AddTodo(Desc,true,pr);
            Assert.Equal(1, ps.todoID);
        }
        [Theory]
        [InlineData(true)]
        public void FindByDoneStatusTest(bool s)
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            p.AddTodo("DDD",true,pr);
            //Then we find for Todo items which have done status true
            Todo[] t = p.FindByDoneStatus(s);
            foreach(var c in t)
            {
                //Now we verify/test if the returned array has all and only true done status todo items
                if(c.Done == s)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        [Theory]
        [InlineData(1)]
        public void FindByAssignee(int ID)
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            p.AddTodo("DDD", true, pr);
            //Then we find for Todo items which have assignee ID equal to 1
            Todo[] t = p.FindByAssignee(ID);
            foreach (var c in t)
            {
                //Now we verify/test if the returned array has all and only assignee ID equal to 1 todo items
                Assert.Equal(1, c.Assignee.PersonID);
                if (c.Assignee.PersonID == ID)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        //Here we take a Person for input search, (we are not going to add it in the array)
        Person FBA = new Person(1, "dd", "ee");
        [Fact]
        public void FindByAssigneeTest()
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            p.AddTodo("DDD", true, pr);
            //Then we find for Todo items which have assignee equal to FBA (Input search data)
            Todo[] t = p.FindByAssignee(FBA);
            foreach (var c in t)
            {
                //Now we verify/test if the returned array has all and only assignee equal to FBA (Input search data) todo items
                if ((c.Assignee.PersonID == FBA.PersonID) && (c.Assignee.FirstName == FBA.FirstName) 
                    && (c.Assignee.LastName == FBA.LastName))
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }

        [Fact]
        public void FindByUnAssignedTodoItemsTest()//10 d
        {
            bool actualresult = false;
            Person pr = new Person(1, "dd", "ee");
            //Here we add a person first in the Todo array
            p.AddTodo("DDD", true, null);
            //Then we find for Todo items which have assignee equal to FBA (Input search data)
            Todo[] t = p.FindUnassignedTodoItems();
            foreach (var c in t)
            {
                //Now we verify/test if the returned array has all and only assignee equal to FBA (Input search data) todo items
                if (c.Assignee == null)
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
        [Fact]
        public void RemoveTodoTest()//11 b
        {
            bool actualresult = false;
            //Here we add 2 persons first in the Persons Array
            p.AddTodo("DDD", true, null);
            p.AddTodo("DDD", true, null);
            //Then we remove our wanted person by his ID
            Todo[] t = p.RemoveTodo(1);
            foreach (var c in t)
            {
                //Now we verify/test if the returned array have all and only persons of ID except 1, meaning  1 is removed or not.
                if (c.todoID == 1)
                {
                    actualresult = false;
                    break;
                }
                else
                {
                    actualresult = true;
                }
            }
            Assert.True(actualresult);
        }
    }

}
