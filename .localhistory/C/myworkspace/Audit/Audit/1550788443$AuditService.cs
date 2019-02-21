﻿using System.Collections.Generic;
using System.IO;

namespace Audit
{
    public class AuditService
    {
        public void AuditFolder(string path)
        {
            string[] namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numberOfFiles = namesOfFiles.Length;

            List<string> auditTextLines = new List<string>();
            auditTextLines.Add($"This directory has {numberOfFiles} file(s).");
            auditTextLines.AddRange(namesOfFiles);

            File.WriteAllLinesAsync(path, auditTextLines);
        }
    }
}