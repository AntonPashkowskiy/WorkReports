using System.ComponentModel;

namespace Reports.BLL.Models
{
    public enum WorkTaskStatus
    {
        [Description("In Progress")]
        InProgress = 1,

        [Description("Fixed")]
        Fixed = 2,

        [Description("Implemented")]
        Implemented = 3,

        [Description("Investigated")]
        Investigated = 4
    }
}
