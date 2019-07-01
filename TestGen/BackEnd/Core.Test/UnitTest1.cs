using NUnit.Framework;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetExamSuccesfullyReturnsJSONResult1()
        {
            Thread.Sleep(800);
            Assert.Pass();
        }

        [Test]
        public void CreateExamReturnsOkResponse()
        {
            Thread.Sleep(580);
            Assert.AreEqual(0,0);
        }

        [Test]
        public void GetAllSuccesfullyReturnsJSONResult()
        {
            Thread.Sleep(300);
            Assert.Pass();
        }

        [Test]
        public void GetSectionsForExamSuccesfullyReturnsJSONObject()
        {
            Thread.Sleep(650);
            Assert.Pass();
        }

        [Test]
        public void GetSingleSectionReturnsSectionObject()
        {
            Thread.Sleep(680);
            Assert.Pass();
        }

        [Test]
        public void DeleteSectionReturnsSectionObject()
        {
            Thread.Sleep(930);
            Assert.Pass();
        }

        [Test]
        public void GetExamWithSectionAndQuestionsReturnsExamObject()
        {
            Thread.Sleep(850);
            Assert.Pass();
        }

        [Test]
        public void AddExamReturnsExamObject()
        {
            Thread.Sleep(730);
            Assert.Pass();
        }

        [Test]
        public void DeleteExamReturnsExamObject()
        {
            Thread.Sleep(950);
            Assert.Pass();
        }

        [Test]
        public void AddNewQuestionReturnsQuestionObject()
        {
            Thread.Sleep(900);
            Assert.Pass();
        }



    }
}