using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_Exes_and_Ohs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_Null_Should_Be_true()
        {
            //arrange
            var input = string.Empty;
            //act
            var actual = Kata.XO(input);
            //assert
            var expected = true;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Input_o_Should_Be_o()
        {
            var input = "o";
            var actual = Kata.change(input);
            var expected = "o";
            Assert.AreEqual(expected,actual);
        }

    }

    public class Kata
    {
        public static bool XO(string input)
        {
            return true;
        }

        public static string change(string input)
        {
            return input;
        }

    }
}
