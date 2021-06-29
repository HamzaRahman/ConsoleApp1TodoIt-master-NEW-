using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class PersonSequencer
    {
        static int personid;
        public static int nextPersonid()
        {
            return personid =+ 1;
        }
        public static void reset()
        {
            personid = 0;
        }
    }
}
