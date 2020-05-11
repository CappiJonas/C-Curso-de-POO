using System;
using System.IO;

namespace Classe_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Arquivo\myfolder\File1.txt";

            Console.WriteLine($"Directory Separator Char: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"Path Separator: {Path.PathSeparator}");
            Console.WriteLine($"Get Directory Name: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"Get File Name: {Path.GetFileName(path)}");
            Console.WriteLine($"Get Extension: {Path.GetExtension(path)}");
            Console.WriteLine($"Get File Name Without Extension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Get Full Path: {Path.GetFullPath(path)}");
            Console.WriteLine($"Get Temp Path: {Path.GetTempPath()}");
        }
    }
}
