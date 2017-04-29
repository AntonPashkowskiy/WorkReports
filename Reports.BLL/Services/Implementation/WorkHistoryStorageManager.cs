using Reports.BLL.Services.Interfaces;
using System;
using Reports.BLL.Models;
using Newtonsoft.Json;
using System.IO;

namespace Reports.BLL.Services.Implementation
{
    public class WorkHistoryStorageManager : IWorkHistoryStorageManager
    {
        #region Fields

        private string _pathToStorageFile;

        #endregion

        #region Ctor

        public WorkHistoryStorageManager(string pathToFile)
        {
            if (pathToFile == null)
            {
                throw new ArgumentNullException("Path to file mustn't be null.");
            }

            if (!File.Exists(pathToFile))
            {
                File.Create(pathToFile);
            }
            _pathToStorageFile = pathToFile;
        }

        #endregion

        #region Public methods

        public WorkHistory RestoreWorkHistoryFromFile()
        {
            if (File.Exists(_pathToStorageFile))
            {
                using (var reader = new StreamReader(File.OpenRead(_pathToStorageFile)))
                {
                    var historyJsonString = reader.ReadToEnd();

                    return (WorkHistory)JsonConvert.DeserializeObject(historyJsonString); 
                }
            }
            else
            {
                throw new IOException("File for history isn't exist.");
            }
        }

        public void SaveWorkHistory(WorkHistory history)
        {
            if (File.Exists(_pathToStorageFile))
            {
                string historyJsonString = JsonConvert.SerializeObject(history, Formatting.Indented);

                using (var writer = new StreamWriter(File.Open(_pathToStorageFile, FileMode.Truncate, FileAccess.Write)))
                {
                    writer.WriteLine(historyJsonString);
                }
            }
            else
            {
                throw new IOException("File for history isn't exist.");
            }
        } 

        #endregion
    }
}
