using System;
using System.Collections.Generic;
using System.IO;
using Comparar_2.Entities;

namespace Comparar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Curso Udemy - C# COMPLETO 2020 Programação Orientada a Objetos + Projetos\Seção 14\6 - Interface IComparable\Arquivo\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
