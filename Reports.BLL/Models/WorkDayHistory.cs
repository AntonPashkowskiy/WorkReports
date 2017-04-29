using System;
using System.Collections.Generic;

namespace Reports.BLL.Models
{
    public class WorkDayHistory
    {
        #region Properties

        public DateTime Date { get; set; }

        public IList<WorkTask> TaskList { get; set; }

        #endregion

        #region Ctor

        public WorkDayHistory()
        {
            TaskList = new List<WorkTask>();
        }

        #endregion

        #region Public Methods

        public void AddTask(WorkTask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("Task mustn't be null.");
            }
            TaskList.Add(task);
        }

        #endregion
    }
}
