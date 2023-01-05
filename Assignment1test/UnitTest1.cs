using System;
using Xunit;
using Assignment1;

namespace Assignment1test
{
    public class UnitTest1
    {
       LengthHelper lengthstr = new LengthHelper();
        [Fact]

        public void stringLength()
        {
            string str = "";
            int length = lengthstr.findLength(str);
            Assert.Equal(0, length);
        }
        [Fact]
        public void failTest()
        {
            string str = "123";
            int length = lengthstr.findLength(str);
            Assert.Equal(3, length);
        }
        [Fact]
        public void stringlength1()
        {
            string str = "123456789010";
            int length = lengthstr.findLength(str);
            Assert.NotEqual(11, length);
        }
        [Fact]
        public void stringLength2()
        {
            string? NULL = null;
            var exception = Record.Exception(() => lengthstr.findLength(NULL));
            Assert.IsType<System.NullReferenceException>(exception);

        }
        [Theory]
        [InlineData("123",3)]
        [InlineData("4356",4)]
        public void theoryTest(string str,int number)
        {
            int length = lengthstr.findLength(str);
            Assert.Equal(number, length);


        }
    }
}

