﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KKU_DEMO.Managers
{
    public class FileManager
    {
        private string Path { get; set; }

        public FileManager()
        {
            
        }

        public void WrightData(string filePath, string data)
        {
            Path = HttpContext.Current.Server.MapPath("~") + "\\log";
            var path = Path + filePath;
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(data);
            sw.Close();
        }
    }
}