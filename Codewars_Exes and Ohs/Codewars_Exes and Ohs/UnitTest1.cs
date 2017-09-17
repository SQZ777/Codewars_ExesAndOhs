using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_Exes_and_Ohs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void XOMethod_Input_Null_Should_Be_true()
        {
            getXOMethodResult(true, string.Empty);
        }

        [TestMethod]
        public void ChangeMethod_Input_o_Should_Be_o()
        {
            getChangeMethodResult("o", "o");
        }

        [TestMethod]
        public void ChangeMethod_Input_O_Should_Be_o()
        {
            getChangeMethodResult("o", "O");
        }

        [TestMethod]
        public void ChangeMethod_Input_X_Should_Be_x()
        {
            getChangeMethodResult("x", "X");
        }

        [TestMethod]
        public void getOlength_Input_oo_Should_Be_2()
        {
            getGetOLengthMethodResult(2, "oo");
        }

        [TestMethod]
        public void getXlength_Input_xx_Should_Be_3()
        {
            getGetXLengthMethodResult(3, "xxx");
        }

        [TestMethod]
        public void XO_Input_oo_Should_Be_False()
        {
            getXOMethodResult(false,"oo");
        }

        [TestMethod]
        public void XO_Input_ox_Should_Be_true()
        {
            getXOMethodResult(true, "ox");
        }

        [TestMethod]
        public void XO_Input_oox_Should_Be_False()
        {
            getXOMethodResult(false, "oox");
        }

        [TestMethod]
        public void XO_Input_ooxx_Should_Be_ture()
        {
            getXOMethodResult(true, "ooxx");
        }

        [TestMethod]
        public void XO_Input_abc_Should_Be_true()
        {
            getXOMethodResult(true,"abc");
        }

        [TestMethod]
        public void XO_Input_abco_Should_Be_false()
        {
            getXOMethodResult(false, "abco");
        }

        [TestMethod]
        public void XO_Input_abcxo_Should_Be_true()
        {
            getXOMethodResult(true, "abcxo");
        }

        private static void getGetOLengthMethodResult(int expected, string input)
        {
            var actual = Kata.getOLength(input);
            Assert.AreEqual(expected, actual);
        }

        private static void getGetXLengthMethodResult(int expected, string input)
        {
            var actual = Kata.getXLength(input);
            Assert.AreEqual(expected, actual);
        }

        private static void getXOMethodResult(bool expected, string input)
        {
            var actual = Kata.XO(input);
            Assert.AreEqual(expected, actual);
        }

        private static void getChangeMethodResult(string expected, string input)
        {
            var actual = Kata.change(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public static bool XO(string input)
        {
            input = change(input);
            var xLength = getXLength(input);
            var oLength = getOLength(input);
            if (xLength == oLength)
                return true;
            return false;
        }

        public static int getXLength(string input)
        {
            return input.ToCharArray().Count(x => x.Equals('x'));
        }

        public static int getOLength(string input)
        {
            return input.ToCharArray().Count(x => x.Equals('o'));
        }

        public static string change(string input)
        {
            return input.ToLower();
        }

        
    }
}
