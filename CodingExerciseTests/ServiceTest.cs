using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coding_Exercise.BusinessLayer;
using Coding_Exercise;
using Moq;

namespace CodingExerciseTests
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void GetHighestOccurenceCharacterTest()
        {
            LineAnalyzer lineAnalyzer = new LineAnalyzer();

            var occurenceChar = lineAnalyzer.GetHighestOccurenceCharacter("xdawqaa");

            Assert.AreEqual(occurenceChar.character, 'a');
            Assert.AreEqual(occurenceChar.numOfOccurences, 3);
        }

        [TestMethod]
        public void GetLowestOccurenceCharacterTest()
        {
            LineAnalyzer lineAnalyzer = new LineAnalyzer();

            var occurenceChar = lineAnalyzer.GetLowestOccurenceCharacter("xddawwqqaa");

            Assert.AreEqual(occurenceChar.character, 'x');
            Assert.AreEqual(occurenceChar.numOfOccurences, 1);
        }
    }
}
