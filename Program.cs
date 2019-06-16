using System;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace OperationFile
{
    public class FileOps
    {
        static void Main(string[] args)
        {
            var deploy = new FileOps();
           
            deploy.dellFiles();
            deploy.copyFile();

            //deploy.runFile();

            Console.WriteLine("In zi lucratoare sunt " + deploy.getWeekDayOccurences() + " ocurente.");
            Console.WriteLine("In zi de odihna sunt " + deploy.getWeekEndOccurences() + " ocurente.");
        } 

        public void dellFiles()
        { 
            DirectoryInfo inDirectory = new DirectoryInfo(@"D:\schedule\production\");

            foreach (FileInfo file in inDirectory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in inDirectory.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public void copyFile()
        {
            File.Copy(
                @"D:\schedule\scheduler.bat",
                @"D:\schedule\production\production.bat"
            );
        }

        public void runFile()
        {
            Process.Start(
                @"E:\Software\Portable\Notepad++\Notepad++\notepad++.exe",
                @"D:\schedule\production\production.bat"
            );
        }

        /*
         * @params: "1L", "2Ma", "3Mi", "4J", "5V"
         */
        public int getWeekDayOccurences(string txt = "1L")
        {
            var occurences = File.ReadAllText(@"D:\schedule\scheduler.bat");
            int total = Regex.Matches(occurences, txt).Count;
            return total;
        }

        /*
         * @params: "6S", "7D"
         */
        public int getWeekEndOccurences(string txt = "6S")
        {
            var occurences = File.ReadAllText(@"D:\schedule\scheduler.bat");
            int total = Regex.Matches(occurences, txt).Count;
            return total;
        }
    }

}
