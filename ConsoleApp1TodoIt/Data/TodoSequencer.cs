using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1TodoIt.Data
{
    public class TodoSequencer
    {
        static int todoid;
        public static int nextTodoid()
        {
            return todoid = +1;
        }
        public static void reset()
        {
            todoid = 0;
        }
    }
}
