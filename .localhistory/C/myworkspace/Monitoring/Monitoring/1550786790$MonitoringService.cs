namespace Watcher
{
    public class MonitoringService
    {
        public void MinitoringFolder(string path)
        {
            int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
        }
    }
}