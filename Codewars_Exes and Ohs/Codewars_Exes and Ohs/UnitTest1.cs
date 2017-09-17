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
        }
    }

    public class Kata
    {
        public static bool XO(string input)
        {
            throw new NotImplementedException();
        }
    }
}
