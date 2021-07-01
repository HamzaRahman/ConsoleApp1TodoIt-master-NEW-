using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;
using ConsoleApp1TodoIt.Model;

namespace ConsoleApp1Todoit.Tests
{
    public class PeopleTest
    {
        People p = new People();
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            p.AddPerson("MM", "ff");
            Person ps = p.FindByID(ID);
            Assert.Equal(1, ps.PersonID);
        }
        [Fact]
        public void SizeTest()
        {
            int i=0;
            int ps = p.Size();
            Assert.Equal(i.GetType(), ps.GetType());
        }
        [Fact]
        public void FindAllTest()
        {
            Person[] peoples = new Person[0];
            Person[] ps = p.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        [Theory]
        [InlineData("Magnus","Ivarson")]
        public void AddTest(string Fname,string Lname)
        {
            Person ps = p.AddPerson(Fname, Lname);
            Assert.Equal(1, ps.PersonID);
            
        }

        
        //[Theory]
        //[InlineData("Magnus", "Ivarson")]
        //public void AddNewTest(string Fname, string Lname)
        //{
        //    Person ps = p.AddPerson(Fname, Lname);
        //    Assert.Equal(1, ps.PersonID);
        //}
    }
}
