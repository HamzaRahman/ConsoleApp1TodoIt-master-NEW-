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
        [InlineData(null,null)]
        public void NullTest(string Fname, string Lname)
        {           
            try
            {
                Person p1 = new Person(Fname, Lname);
                Assert.Equal(Fname, p1.FirstName);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal( "Empty or only whitespace is not allowed.", ex.Message);
            }
        }
        [Theory]
        [InlineData("Hamza", "Rahman")]
        public void NormalTest(string Fname, string Lname)
        {
            Person p1 = new Person(Fname, Lname);
            Assert.Equal("Hamza", p1.FirstName);
            Assert.Equal("Rahman", p1.LastName);
        }
    }
}
