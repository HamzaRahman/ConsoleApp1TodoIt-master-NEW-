using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1TodoIt.Model;

namespace ConsoleApp1TodoIt.Data
{
    public class People
    {
        static Person[] peoples = new Person[0];
        public int Size()
        {
            return peoples.Length;
        }
        public Person[] FindAll()
        {
            return peoples;
        }
        public Person FindByID(int personid)
        {
            Person person = new Person(1,"","");
            foreach (var p in peoples)
            {
                if(p.PersonID == personid)
                {
                    person = p;
                }

            }
            return person;
        }
        public Person AddPerson(string Fname,string Lname)
        {
            var size = Size();
            size=+1;
            Array.Resize<Person>(ref peoples,size);
            int ID = PersonSequencer.nextPersonid();
            Person p = new Person(ID, Fname, Lname);
            peoples[size-1] = p;
            return p;
        }
        public void Clear()
        {
            peoples = new Person[0];
        }
    }
}
