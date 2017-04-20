using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackwardsCounterProgram;

namespace BackwardsCounterProgramTest
{
    [TestClass]
    public class BackwardsCounterProgramTest
    {
        /// <summary>
        /// Verify if numbers are valid for valid input
        /// </summary>
        [TestMethod]
        public void VerifyIfNumbersAreValid()
        {
            var backwardCounter = new BackwardCounter("25", "5");
            Assert.IsTrue(backwardCounter.IsValid, "Message is not valid");
            Assert.AreEqual("Numbers are valid", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is Empty
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondNumberIsEmpty()
        {
            var backwardCounter = new BackwardCounter("", "5");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Either of the Numbers cannot be empty", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is not valid for alphabetic input
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsNotInteger()
        {
            var backwardCounter = new BackwardCounter("aaa", "5");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Numbers has to be integer", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is not valid for negative input
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsNegative()
        {
            var backwardCounter = new BackwardCounter("-25", "5");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Numbers must be non negative", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is less than 2
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsLessThan2()
        {
            var backwardCounter = new BackwardCounter("1", "1");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("First Number must be greater than 2", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is greater than 1000
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsGreaterThan1000()
        {
            var backwardCounter = new BackwardCounter("1010", "1");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("First Number must be less than 1000", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if First Number is not divisible by Second Number
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsNotDivisibleBySecondNumber()
        {
            var backwardCounter = new BackwardCounter("25", "7");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("First Number not evenly divisible by Second Number", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if Second Number is Empty
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstNumberIsEmpty()
        {
            var backwardCounter = new BackwardCounter("25", "");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Either of the Numbers cannot be empty", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if Second Number is not valid for alphabetic input
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondNumberIsNotInteger()
        {
            var backwardCounter = new BackwardCounter("25", "aa");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Numbers has to be integer", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if Second Number is not valid for negative input
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondNumberIsNegative()
        {
            var backwardCounter = new BackwardCounter("25", "-5");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Numbers must be non negative", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if Second Number is zero
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondNumberIsZero()
        {
            var backwardCounter = new BackwardCounter("25", "0");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Second Number must be greater than zero", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify if Second Number is greater than First Number
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondNumberIsGreaterThanFirstNumber()
        {
            var backwardCounter = new BackwardCounter("5", "25");
            Assert.IsFalse(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Second Number must be less than First Number", backwardCounter.Status, "Status doesnt match as expected.");
        }

        /// <summary>
        /// Verify backward count
        /// </summary>
        [TestMethod]
        public void VerifyBackwardCount()
        {
            var backwardCounter = new BackwardCounter("25", "5");
            Assert.IsTrue(backwardCounter.IsValid, "Message is valid");
            Assert.AreEqual("Numbers are valid", backwardCounter.Status, "Status doesnt match as expected.");
            Assert.AreEqual("25 20 15 10 5", backwardCounter.PrintBackwardCount(), "Output of Print backward count is not as expected");
        }


    }
}
