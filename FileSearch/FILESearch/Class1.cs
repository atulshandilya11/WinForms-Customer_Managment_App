using System.IO;

namespace FILESearch
{
    public class File
    {
        public delegate void DispalyFileName(string file);
        public event DispalyFileName sendFileName;
        public void Search (string dirName)
        { 
            
            foreach (string dir in Directory.GetDirectories(dirName))
            {
                foreach(string str in Directory.GetFiles(dir))
                    {
                    sendFileName(str);
                    Thread.Sleep(1000);
                }
                Search(dir);
            }
           
        }

    }
}
