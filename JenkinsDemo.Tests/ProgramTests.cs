using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JenkinsDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class ProgramTests
        {
            [TestMethod]
            public void TestHelloWorld()
            {
                // Arrange
                string expected = "Hello, Jenkins CI/CD!";
                // Act
                string actual = JenkinsDemo.Program.GetHelloWorld();
                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
