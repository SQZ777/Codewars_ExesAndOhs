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
            getXOMethodResult(true,string.Empty);
        }

        [TestMethod]
        public void Input_o_Should_Be_o()
        {
            getChangeMethodResult("o", "o");
        }

        [TestMethod]
        public void Input_O_Should_Be_o()
        {
            getChangeMethodResult("o","O");
        }

        [TestMethod]
        public void Input_X_Should_Be_x()
        {
            getChangeMethodResult("x","X");
        }

        private static void getXOMethodResult(bool expected, string input)
        {
            var actual = Kata.XO(input);
            Assert.AreEqual(expected, actual);
        }

        private static void getChangeMethodResult(string expected,string input)
        {
            var actual = Kata.change(input);
            Assert.AreEqual(expected, actual);
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
            return input.ToLower();
        }

    }
}
