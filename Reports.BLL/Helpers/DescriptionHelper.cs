using System;
using System.ComponentModel;

namespace Reports.BLL.Helpers
{
    public static class DescriptionHelper
    {
        #region Public methods

        public static string RetrieveEnumDescription(Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var enumValueMemberInfo = enumType.GetMember(enumValue.ToString());
            var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(enumValueMemberInfo[0], typeof(DescriptionAttribute));

            return descriptionAttribute == null ? string.Empty : descriptionAttribute.Description;
        }

        #endregion
    }
}
