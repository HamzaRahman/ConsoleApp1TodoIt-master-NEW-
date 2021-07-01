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
            //To test find by ID, we first store a todo item
            p.AddTodo("mm");
            //Then we test to find it by giving its ID
            Todo ps = p.FindByID(ID);
            Assert.Equal(1, ps.todoID);
        }
        [Theory]
        [InlineData("Todo 1")]
        public void AddTest(string Desc)
        {
            Todo ps = p.AddTodo(Desc);
            Assert.Equal(1, ps.todoID);
        }
        
        //[Theory]
        //[InlineData("Todo 2")]
        //public void AddNewTest(string Desc)
        //{
        //    Todo ps = p.AddTodo(Desc);
        //    Assert.Equal(1, ps.todoID);
        //}
    }
}
