using NUnit.Framework;
using Reports.BLL.Models;
using System;

namespace Reports.BLL.Tests.Models
{
    [TestFixture]
    public class WorkTaskTests
    {
        #region GetIdNumberPart

        [Test]
        public void GetIdNumberPart_IdIsNull_ThrowsException()
        {
            var workTask = new WorkTask
            {
                Id = null
            };
            Assert.Throws<Exception>(() => workTask.GetIdNumberPart());
        }

        [Test]
        public void GetIdNumberPart_IdNotContainNumberPart_ThrowsException()
        {
            var workTask = new WorkTask
            {
                Id = "test"
            };
            Assert.Throws<Exception>(() => workTask.GetIdNumberPart());
        }

        [Test]
        [TestCase("RM-420", 420)]
        [TestCase("42000_SA", 42000)]
        [TestCase("435", 435)]
        [TestCase("S_12_S", 12)]
        public void GetIdNumberPart_IdContainNumberPart_ReturnsNumberPart(string id, int expectedNumberPart)
        {
            var workTask = new WorkTask
            {
                Id = id
            };
            Assert.AreEqual(workTask.GetIdNumberPart(), expectedNumberPart);
        }

        #endregion
    }
}
