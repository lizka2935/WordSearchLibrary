using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordSearchLibrary;

namespace WordSearchLibraryTests
{
    [TestClass]
    public class WordSearchClassTests
    {
        [TestMethod]
        public void WordCount_2_Return2()
        {
            //Arrange
            string textString = "Мыорнпа Мышь мыш мышь";
            string word = "мышь ";
            int exe = 2;
            //Act
            int actual = WordSearchClass.WordCount(textString,word);
            //Assert
            Assert.AreEqual(exe, actual);
        }
        [DataTestMethod]
        [DataRow("gdhfgd jefieif hdgfh dfvyug", "fr",0 )]
        public void WordCount_Zero_ReturnZero(string textString,string word, int exement)
        {
            int actual = WordSearchClass.WordCount(textString, word);
            Assert.AreEqual(exement, actual);
        }

        [DataTestMethod]
        [DataRow("gdhfgd jefieif hdgfh dfvyug", "")]
        [DataRow("gdhfgd jefieif hdgfh dfvyug", " ")]
        [DataRow("        ", "             ")]
        public void WordCount_Exception_ReturnException(string textString, string word)
        {
            Action actual = () => WordSearchClass.WordCount(textString, word);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

    }
    
}
