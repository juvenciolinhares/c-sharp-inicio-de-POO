using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioDeFixacaoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            List<Employees> list = new List<Employees>();

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Employye #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id the will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employees emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.salaryIncrease(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Update list of employees: ");
            foreach(Employees funcs in list)
            {
                Console.WriteLine(funcs);
            }

        }
    }


}
