﻿using System;
using System.IO;

namespace Bloco_using
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Arquivo\File1.txt";

            try
            {
                //{
                //    using (FileStream fs = new FileStream(path, FileMode.Open))
                //    {
                //        using (StreamReader sr = new StreamReader(fs))
                //        {
                //            while (!sr.EndOfStream)
                //            {
                //                string line = sr.ReadLine();
                //                Console.WriteLine(line);
                //            }
                //        }
                //    }
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            // o using abre e fecha os "Streams"
        }
    }
}
