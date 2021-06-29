using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;
using Xunit;

namespace ConsoleApp1Todoit.Tests
{
    
    public class PersonTest
    {
        [Theory]
        [InlineData(1,null,null)]
        public void NullTest(int ID,string Fname, string Lname)
        {           
            try
            {
                Person p1 = new Person(ID,Fname, Lname);
                //Assert.Equal(Fname, p1.FirstName);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal( "Empty or only whitespace is not allowed.", ex.Message);
            }
        }
        [Theory]
        [InlineData(1,"Magnus", "Ivarsson")]
        public void NormalTest(int ID,string Fname, string Lname)
        {
            Person p1 = new Person(ID,Fname, Lname);
            Assert.Equal("Magnus", p1.FirstName);
            Assert.Equal("Ivarsson", p1.LastName);
        }
    }
}
