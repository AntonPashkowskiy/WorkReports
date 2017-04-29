using Reports.BLL.Helpers;
using System;
using System.Text.RegularExpressions;

namespace Reports.BLL.Models
{
    public class WorkTask
    {
        #region Properties

        public string AssignedUserName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public WorkTaskStatus Status { get; set; }

        #endregion

        #region Overrited methods

        public override string ToString()
        {
            var taskStatusDescription = DescriptionHelper.RetrieveEnumDescription(Status);

            return $"[{AssignedUserName}] {Id} {Name} ({taskStatusDescription})";
        }

        #endregion

        #region Public methods

        public int GetIdNumberPart()
        {
            try
            {
                string pattern = @"[0-9]+";

                if (Regex.IsMatch(Id, pattern))
                {
                    var numberPartString = Regex.Match(Id, pattern).ToString();
                    return int.Parse(numberPartString);
                }
                else
                {
                    throw new Exception("Work task id has incorrect format.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to retrieve id number part", ex);
            }
        }

        #endregion
    }
}
