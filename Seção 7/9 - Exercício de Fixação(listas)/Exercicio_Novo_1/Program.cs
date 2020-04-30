using System;
using System.Globalization;
using System.Collections.Generic;
namespace Exercicio_Novo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.ID == searchID);
            if (emp != null)
            {
                Console.Write("Enter percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist.");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
