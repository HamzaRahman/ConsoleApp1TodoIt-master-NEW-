using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Person;

namespace ConsoleApp1TodoIt.UnitTest
{
    [TestClass]
    class PersonTest
    {
        [TestMethod]
        public void NullTest()
        {
            string Fname = null;
            string Lname = null;
            Person p1 = new Person(Fname, Lname);
        }
    }
}
