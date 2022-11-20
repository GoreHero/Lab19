using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Num = 1, Name = "Иванов", Summa = 100, City = "Москва" },
                new Employee() { Num = 2, Name = "Зайцев", Summa = 110, City = "СПБ" },
                new Employee() { Num = 3, Name = "Лисов", Summa = 160, City = "Воркута" },
                new Employee() { Num = 4, Name = "Волков", Summa = 120, City = "Москва" },
                new Employee() { Num = 5, Name = "Козлов", Summa = 10, City = "Сочи" },
                new Employee() { Num = 6, Name = "Слонов", Summa = 145, City = "Москва" },
                new Employee() { Num = 7, Name = "Бегомотов", Summa = 80, City = "Сочи" },
                new Employee() { Num = 8, Name = "Бубликов", Summa = 1000, City = "СПБ" },
            };
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            List<Employee> employees1 = employees
                .Where(x => x.City == city)
                .ToList();
            Print(employees1);

            Console.WriteLine("введите зп");
            int summa = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees2 = employees
                 .Where(x => x.Summa >= summa)
                 .ToList();
            Print(employees2);

            List<Employee> employees3 = employees
                .OrderBy(x => x.Name)
                .ToList();
            Print(employees3);

            IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(x => x.City);
            foreach (IGrouping<string, Employee> group in employees4)
            {
                Console.WriteLine(group.Key);
                foreach (Employee emp in group)
                {
                    Console.WriteLine($"{emp.Num} {emp.Name} {emp.Summa} {emp.City}");
                }
            }

            Employee employee5 = employees.OrderByDescending(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{employee5.Num} {employee5.Name} {employee5.Summa} {employee5.City}");

            Employee employee6 = employees.OrderBy(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{employee6.Num} {employee6.Name} {employee6.Summa} {employee6.City}");

            Console.WriteLine(employees
                .Any(x => x.Summa > 200));

            Console.ReadKey();
        }

        static void Print(List<Employee>employees)
        {
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{ e.Num} {e.Name} {e.Summa } {e.City }");
            }
            Console.WriteLine();
        }
    }
}

