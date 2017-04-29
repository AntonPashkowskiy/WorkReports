using NUnit.Framework;
using Reports.BLL.Helpers;
using Reports.BLL.Models;
using System.Threading.Tasks;

namespace Reports.BLL.Tests.Helpers
{
    [TestFixture]
    public class DescriptionHelperTests
    {
        #region RetrieveEnumDescription

        [Test]
        [TestCase(WorkTaskStatus.InProgress, "In Progress")]
        [TestCase(WorkTaskStatus.Fixed, "Fixed")]
        [TestCase(WorkTaskStatus.Implemented, "Implemented")]
        [TestCase(WorkTaskStatus.Investigated, "Investigated")]
        public void RetrieveEnumDescription_EnumValuePassed_ReturnsEnumDescription(
            WorkTaskStatus enumValue,
            string enumValueDescription)
        {
            Assert.AreEqual(DescriptionHelper.RetrieveEnumDescription(enumValue), enumValueDescription);
        }

        [Test]
        public void RetrieveEnumDescription_EnumValueHasNotDescriptionAttribute_ReturnsEmptyString()
        {
            Assert.IsEmpty(DescriptionHelper.RetrieveEnumDescription(TaskStatus.Created));
        }

        #endregion
    }
}
