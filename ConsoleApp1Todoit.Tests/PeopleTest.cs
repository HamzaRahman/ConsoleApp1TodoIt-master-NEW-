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
        [Fact]
        public void SizeTest()
        {
            int i=0;
            var ps = p.Size();
            Assert.Equal(i.GetType(), ps.GetType());
        }

        [Fact]
        public void FindAllTest()
        {
            Person[] peoples = new Person[0];
            var ps = p.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        [Theory]
        [InlineData("Magnus","Ivarson")]
        public void AddTest(string Fname,string Lname)
        {
            var ps = p.AddPerson(Fname, Lname);
            Assert.Equal(1, ps.PersonID);
        }
    }
}
