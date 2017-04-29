using Reports.BLL.Models;

namespace Reports.BLL.Services.Interfaces
{
    public interface IWorkHistoryStorageManager
    {
        void SaveWorkHistory(WorkHistory history);

        WorkHistory RestoreWorkHistoryFromFile();
    }
}
