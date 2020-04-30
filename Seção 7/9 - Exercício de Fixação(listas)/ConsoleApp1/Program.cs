using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee {i}");
                Console.Write($"Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int iD = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.ID == iD);
            if (emp != null)
            {
                Console.Write("Enter percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
