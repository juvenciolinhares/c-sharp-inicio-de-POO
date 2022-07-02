using System;

using System.Globalization;
namespace ExercicioDeFixacaoListas
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;private set; }
        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double salaryIncrease(double porcentagem)
        {
            return Salary = Salary + (Salary * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
