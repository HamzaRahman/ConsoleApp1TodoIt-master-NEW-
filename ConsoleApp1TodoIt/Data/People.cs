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
            //We are taking this person because we have to return something at the end if our wanted person is not found
            //To know whether the function returned the person we wanted or this new one, we are setting its ID to 0
            //Because all other persons ID will start form one and we will know if its zero than not found, else if its greater than
            //zero, its found
            Person person = new Person(0,"MM","MM");
            //Here we run a foreach loop on peoples array
            foreach (var p in peoples)
            {
                //Then we compare our wanted ID with every persons ID
                if(p.PersonID == personid)
                {
                    //if its found then it will be returned
                    return p;
                }
            }
            //else the 0 ID person we created will be returned
            return person;
        }
        public Person AddPerson(string Fname,string Lname)
        {
            int size = Size();
            size = size + 1;
            Array.Resize(ref peoples,size);
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
