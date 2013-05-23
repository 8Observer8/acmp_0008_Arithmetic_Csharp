using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acmp_0008_Arithmetic;

namespace UnitTestArithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArithmetic_YES()
        {
            Arithmetic arith = new Arithmetic();
            int a = 5;
            int b = 6;
            int c = 30;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = 5;
            int b = 6;
            int c = 10;
            string result = arith.arithmetic(a, b, c);
            string expected = "NO";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_A_YES()
        {
            Arithmetic arith = new Arithmetic();
            int a = -5;
            int b = 6;
            int c = -30;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_A_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = -5;
            int b = 6;
            int c = -10;
            string result = arith.arithmetic(a, b, c);
            string expected = "NO";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_B_YES()
        {
            Arithmetic arith = new Arithmetic();
            int a = 5;
            int b = -6;
            int c = -30;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_B_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = 5;
            int b = -6;
            int c = 30;
            string result = arith.arithmetic(a, b, c);
            string expected = "NO";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_A_positive_result_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = -5;
            int b = 6;
            int c = 30;
            string result = arith.arithmetic(a, b, c);
            string expected = "NO";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_B_positive_result_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = 5;
            int b = -6;
            int c = 30;
            string result = arith.arithmetic(a, b, c);
            string expected = "NO";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_ALL_YES()
        {
            Arithmetic arith = new Arithmetic();
            int a = -5;
            int b = -6;
            int c = -30;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_negative_ALL_NO()
        {
            Arithmetic arith = new Arithmetic();
            int a = -5;
            int b = -6;
            int c = 30;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestArithmetic_zerro_ALL_YES()
        {
            Arithmetic arith = new Arithmetic();
            int a = 0;
            int b = 0;
            int c = 0;
            string result = arith.arithmetic(a, b, c);
            string expected = "YES";
            Assert.AreEqual(expected, result);
        }
    }
}
