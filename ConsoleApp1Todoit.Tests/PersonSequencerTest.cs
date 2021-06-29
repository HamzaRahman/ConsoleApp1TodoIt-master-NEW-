using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;

namespace ConsoleApp1Todoit.Tests
{
    
    public class PersonSequencerTest
    {
        [Fact]
        public void PersonIDTest()
        {
            var ID = PersonSequencer.nextPersonid();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.reset(); 
        }
    }
}
