using System.IO;

namespace Watcher
{
    public class MonitoringService
    {
        public void MinitoringFolder(string path, int maxNumberOfFiles)
        {
            string[] namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numerOfFiles = namesOfFiles.Length;
        }
    }
}