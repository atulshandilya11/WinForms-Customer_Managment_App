using FILESearch;
namespace Lab3
{
    class Program
    {
     static void Main(string[] args)
        {
            Console.WriteLine("enter the directory");
            string? strdir = Console.ReadLine();

            FILESearch.File fileobj = new FILESearch.File();

            fileobj.sendFileName += DisplayFileName;
           

            Thread thread = new Thread(()=>fileobj.Search(strdir));
            thread.Start();
        }
        static void DisplayFileName (string str)
        {
            Console.WriteLine (str);
        }
    }
    
}
