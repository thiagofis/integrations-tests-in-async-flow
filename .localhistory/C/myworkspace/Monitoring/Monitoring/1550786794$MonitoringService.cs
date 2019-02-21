using System.IO;

namespace Watcher
{
    public class MonitoringService
    {
        public void MinitoringFolder(string path)
        {
            string[] files names = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
        }
    }
}