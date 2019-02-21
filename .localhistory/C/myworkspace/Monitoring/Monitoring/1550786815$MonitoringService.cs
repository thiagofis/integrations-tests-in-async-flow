using System.IO;

namespace Watcher
{
    public class MonitoringService
    {
        public void MinitoringFolder(string path)
        {
            string[] filesNames = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
        }
    }
}