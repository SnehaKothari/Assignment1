using System;
using Xunit;
using Assignment1;

namespace Assignment1test
{
    public class UnitTest1
    {
        Assignment1.LengthHelper length = new Assignment1.LengthHelper();
        [Fact]

        public void stringLength()
        {
            Assert.Equal(0, length.findLength(""));
        }
        [Fact]
        public void failTest()
        {
            Assert.Equal(3, length.findLength("123"));

        }
        [Fact]
        public void stringlength1()
        {
            Assert.NotEqual(11, length.findLength("123456789010"));
        }
        [Fact]
        public void stringLength2()
        {
            string? NULL = null;
            var exception = Record.Exception(() => length.findLength(NULL));
            Assert.IsType<System.NullReferenceException>(exception);
        }
    }
}