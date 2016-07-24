using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETS2_Company_Telemetry_Logger
{
    class Log
    {
        private List<string> l = new List<string>();        

        public void newLine(string line) {
            l.Add(line);
        }

        public void deleteLines() {
            l.Clear();
        }

        public void writeOnFile() {
            if (!Directory.Exists(Properties.Settings.Default.LogPath + @"\Logs"))
            { // Verify if exist the directory "Logs" on root of program
                Directory.CreateDirectory(Properties.Settings.Default.LogPath + @"\Logs"); //If dont, its created
            }   
            string[] splitDate;            
            DateTime dt;
            dt =DateTime.UtcNow;
            splitDate = Convert.ToString(dt).Split('/', ' ',':');
            File.AppendAllLines(Properties.Settings.Default.LogPath+@"\Logs\LOG-" + splitDate[0] + "-" + splitDate[1] + "-" + splitDate[2] + "--" + splitDate[3] + "-" + splitDate[4] +"-"+splitDate[5]+ ".txt", l);
            
        }
    }
}
