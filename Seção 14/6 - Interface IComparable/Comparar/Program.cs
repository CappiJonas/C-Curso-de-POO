using System;
using System.Collections.Generic;
using System.IO;

namespace Comparar
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Curso Udemy - C# COMPLETO 2020 Programação Orientada a Objetos + Projetos\Seção 14\6 - Interface IComparable\Arquivo\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
