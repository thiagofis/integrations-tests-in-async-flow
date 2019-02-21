using System.Collections.Generic;
using System.IO;

namespace Watcher
{
    public class AuditService
    {
        public void AuditFolder(string path, int maxNumberOfFiles)
        {
            IList<string> namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numerOfFiles = namesOfFiles.;
            
            string[] lines = { "First line", "Second line", "Third line" };

            File.WriteAllLinesAsync(path, lines);

        }
    }
}