﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Audit
{
    public class AuditService
    {
        public Task AuditFolderAsync(string path)
        {
            string[] namesOfFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            var numberOfFiles = namesOfFiles.Length;

            List<string> auditTextLines = new List<string>();
            auditTextLines.Add($"This directory has {numberOfFiles} file(s).");
            auditTextLines.AddRange(namesOfFiles.Select(File => $"-> {file}"));

            return File.WriteAllLinesAsync($"{path}/audit-summary.txt", auditTextLines);
        }
    }
}