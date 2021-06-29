using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleApp1TodoIt.Data;

namespace ConsoleApp1Todoit.Tests
{
    public class TodoSequencerTest
    {
        [Fact]
        public void TodoIDTest()
        {
            var ID = TodoSequencer.nextTodoid();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.reset();
        }
    }
}
