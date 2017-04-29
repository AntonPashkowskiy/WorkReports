using System.Collections.Generic;

namespace Reports.BLL.Models
{
    public class WorkHistory
    {
        #region Properties

        public IList<WorkDayHistory> History { get; set; }

        #endregion
    }
}
