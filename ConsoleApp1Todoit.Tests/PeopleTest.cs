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

        //We are adding one more person after AddTest and checking if really the array expands and stores multiple person
        //I was checking ID 1 for AddNewTest because sometimes the this test runs first and was 
        //checking ID 2 for AddTest because sometimes it runs after AddNewTest
        //But if you run only PeopleTest by right clicking on PeopleTest in the test list and Run Selecteed Tests,
        //except for Run all, it will be passed
        [Theory]
        [InlineData("Magnus", "Ivarson")]
        public void AddNewTest(string Fname, string Lname)
        {
            Person ps = p.AddPerson(Fname, Lname);
            Assert.Equal(2, ps.PersonID);
        }
        [Fact]
        public void RemovePersonTest()//11 b
        {
            bool actualresult = false;
            //Here we add 2 persons first in the Persons Array
            p.AddPerson("dd", "ee");
            p.AddPerson("dd", "ee");
            //Then we remove our wanted person by his ID
            Person[] t = p.RemovePerson(1);
            foreach (var c in t)
            {
                //Now we verify/test if the returned array have all and only persons of ID except 1, meaning  1 is removed or not.
                if (c.PersonID == 1)
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
