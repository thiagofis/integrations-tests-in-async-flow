using System.IO;

namespace Watcher
{
    public class AuditService
    {
        public void AuditFolder(string path, int maxNumberOfFiles)
        {
            string[] namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numerOfFiles = namesOfFiles.Length;

            if(numerOfFiles > maxNumberOfFiles)
            {

            }
        }
    }
}