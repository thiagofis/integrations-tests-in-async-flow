using System.Collections.Generic;
using System.IO;

namespace Watcher
{
    public class AuditService
    {
        public void AuditFolder(string path, int maxNumberOfFiles)
        {
            IList<string> namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numerOfFiles = namesOfFiles.Count;

            IList<string> auditTextLines = new List<string>();
            auditTextLines.

            File.WriteAllLinesAsync(path, lines);

        }
    }
}