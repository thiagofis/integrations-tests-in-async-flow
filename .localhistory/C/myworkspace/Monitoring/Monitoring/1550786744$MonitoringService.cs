﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher
{
    public class MonitoringService
    {
        public void CheckFolder(string path)
        {
            int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
        }
    }
}
