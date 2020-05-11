using System;
using System.IO;

namespace File_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Arquivo\File1.txt";
            string targetPath = @"C:\Arquivo\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
