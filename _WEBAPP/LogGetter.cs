using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace _WEBAPP
{
    public class LogGetter
    {
        public string file_name;
        public string date;

        private const string configPath = @"C:\inetpub\wwwroot\config.json";
        private static string dir_path;

        public LogGetter()
        {
            file_name = "";
            date = "";
        }
        public static string[] GetLogFiles()
        {
            GetPath();
            string[] filePaths = Directory.GetFiles(dir_path, "*.log");
            if (filePaths.Length == 0)
            {
                return new string[] { "empty" };
            }

            return filePaths;

        }

        public void InitObj(string f_path)
        {
            
            file_name = Path.GetFileName(f_path);
            if (f_path == "empty")
            {
                return;
            }
            string date_ = Path.GetFileName(f_path);

            //block to make date pretty (dd-mm-yyyy)
            date = "";
            date += date_[7];
            date += date_[8];
            date += "-";
            date += date_[5];
            date += date_[6];
            date += "-";
            date += date_[1];
            date += date_[2];
            date += date_[3];
            date += date_[4];

            //block to make date pretty
            
        }

        //Get Dir path;
        private static void GetPath()
        {
            StreamReader r = new StreamReader(configPath);
            string json = r.ReadToEnd();
            dynamic config_file = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            dir_path = config_file.dir_path;
        }


    }
}