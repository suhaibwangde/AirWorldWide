using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;

namespace AnagramsTest
{
    [TestClass]
    public class AnagramsTest
    {
        /// <summary>
        /// Verify if given two words are valid
        /// </summary>
        [TestMethod]
        public void VerifyIfTwoWordsreValid()
        {
            var words = new Words("eat", "ate");
            Assert.IsTrue(words.IsValid, "Words are not valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
           // Words
        }

        /// <summary>
        /// Verify if First Word is empty
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstWordIsInValid()
        {
            var words = new Words("", "ate");
            Assert.IsFalse(words.IsValid, "Words are not valid");
            Assert.AreEqual("First Word should not be empty or space", words.Status, "Status is not expected");
            // Words
        }

        /// <summary>
        /// Verify if First Word is space
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstWordIsSpace()
        {
            var words = new Words(" ", "ate");
            Assert.IsFalse(words.IsValid, "Words are not valid");
            Assert.AreEqual("First Word should not be empty or space", words.Status, "Status is not expected");
            // Words
        }

        /// <summary>
        /// Verify if Second Word is empty
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondWordIsInValid()
        {
            var words = new Words("eat", "");
            Assert.IsFalse(words.IsValid, "Words are not valid");
            Assert.AreEqual("Second Word should not be empty or space", words.Status, "Status is not expected");
            // Words
        }

        /// <summary>
        /// Verify if Second Word is space
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondWordIsSpace()
        {
            var words = new Words("eat", " ");
            Assert.IsFalse(words.IsValid, "Words are not valid");
            Assert.AreEqual("Second Word should not be empty or space", words.Status, "Status is not expected");
            // Words
        }

        /// <summary>
        /// Verify if First Word is converted to lower
        /// </summary>
        [TestMethod]
        public void VerifyIfFirstwordIsConvertedToAllLower()
        {
            var words = new Words("Eat", "ate");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.AreEqual(words.FirstWord, "eat", "First word is not converted to lower");
            // Words
        }

        /// <summary>
        /// Verify if Second Word is converted to lower
        /// </summary>
        [TestMethod]
        public void VerifyIfSecondwordIsConvertedToAllLower()
        {
            var words = new Words("eat", "Ate");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.AreEqual(words.SecondWord, "ate", "Second word is not converted to lower");
            // Words
        }

        /// <summary>
        /// Verify if eat and ate are Anagrams
        /// </summary>
        [TestMethod]
        public void VerfifyiFEatAndAteAreAnagrams()
        {
            var words = new Words("eat", "Ate");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsTrue(words.AreAnagram(), "Words are not anagram");
        }

        /// <summary>
        /// Verify if LISTEN and SILENT are Anagrams
        /// </summary>
        [TestMethod]
        public void VerfifyiFListenAndSilentAreAnagrams()
        {
            var words = new Words("LISTEN", "SILENT");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsTrue(words.AreAnagram(), "Words are not anagram");

        }

        /// <summary>
        /// Verify if Triangle and Integral are Anagrams
        /// </summary>
        [TestMethod]
        public void VerfifyiFTriangleAndIntegralAreAnagrams()
        {
            var words = new Words("Triangle", "Integral");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsTrue(words.AreAnagram(), "Words are not anagram");

        }

        /// <summary>
        /// Verify if test and ttsw are not Anagrams
        /// </summary>
        [TestMethod]
        public void VerfifyIfTestAndTtswAreNotAnagrams()
        {
            var words = new Words("test", "ttst");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsFalse(words.AreAnagram(), "Words are anagram");
        }


        /// <summary>
        /// Verify for following
        ///     - Frist     Second  Anagram
        ///`    - sadder    dreads   YES
        ///     - creative  reactive YES
        ///     - viral     liar    NO
        ///     - ad        bc      NO
        /// </summary>
        [TestMethod]
        public void VerfifyAboveCases()
        {
            var words = new Words("sadder", "dreads");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsTrue(words.AreAnagram(), "Sadder & dreads are not anagram");

            words = new Words("creative", "reactive");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsTrue(words.AreAnagram(), "creative & reactive are not anagram");

            words = new Words("viral", "liar");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsFalse(words.AreAnagram(), "viral & liar are anagram");

            words = new Words("ad", "bc");
            Assert.IsTrue(words.IsValid, "Words are valid");
            Assert.AreEqual("Words are valid", words.Status, "Status is not expected");
            Assert.IsFalse(words.AreAnagram(), "viral & liar are anagram");
        }

    }
}
