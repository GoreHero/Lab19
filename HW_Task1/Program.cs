using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        //Создать список, содержащий 6-10 записей с различным набором значений характеристик.
        //Определить:
        //- все компьютеры с указанным процессором.Название процессора запросить у пользователя;
        //- все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
        //- вывести весь список, отсортированный по увеличению стоимости;
        //- вывести весь список, сгруппированный по типу процессора;
        //- найти самый дорогой и самый бюджетный компьютер;
        //- есть ли хотя бы один компьютер в количестве не менее 30 штук?

        static void Main(string[] args)

        {
            List<Computer> comps = new List<Computer>()
            {
                new Computer() {codComp="1", nameComp = "KUU",typeProc = "AMD", freqProc = 1.9 ,amountRAM = 16, amountHardDisk= 512, amountVideo = 0, costComp= 49209, countInStock = 13},
                new Computer() {codComp="2", nameComp = "HAIER",typeProc = "INTEL", freqProc = 1.1 ,amountRAM = 16, amountHardDisk= 1024, amountVideo = 8, costComp= 84231, countInStock = 0},
                new Computer() {codComp="3", nameComp = "ACER",typeProc = "INTEL", freqProc = 1.1 ,amountRAM = 8, amountHardDisk= 2048, amountVideo = 16, costComp= 165495, countInStock = 40},
                new Computer() {codComp="4", nameComp = "ACER",typeProc = "INTEL", freqProc = 3.5 ,amountRAM = 32, amountHardDisk= 128, amountVideo = 4, costComp= 40023, countInStock = 20},
                new Computer() {codComp="5", nameComp = "COLORFUL",typeProc = "INTEL", freqProc = 2.1 ,amountRAM = 32, amountHardDisk= 256, amountVideo = 32, costComp= 13465, countInStock = 10},
                new Computer() {codComp="6", nameComp = "ASUS",typeProc = "AMD", freqProc = 3.1 ,amountRAM = 16, amountHardDisk= 1024, amountVideo = 32, costComp= 56533, countInStock = 50},
                new Computer() {codComp="7", nameComp = "ASUS",typeProc = "AMD", freqProc = 1.1 ,amountRAM = 16, amountHardDisk= 1024, amountVideo = 8, costComp= 100000, countInStock = 100},
                new Computer() {codComp="8", nameComp = "LENOVO",typeProc = "AMD", freqProc = 1.3 ,amountRAM = 32, amountHardDisk= 512, amountVideo = 4, costComp= 99999, countInStock = 0},
            };
            Console.WriteLine("Какой тип процессора интересует?");
            string proc = Console.ReadLine();
            List<Computer> comp1 = comps.Where(x => x.typeProc == proc).ToList();
            Print(comp1);

            Console.WriteLine("ОЗУ от?");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer>comp2 = comps.Where(x => x.amountRAM >ram).ToList();
            Print(comp2);

            List<Computer> comp3 = comps.OrderBy(x=>x.costComp).ToList();
            Print(comp3);

            IEnumerable<IGrouping<string, Computer>> comp4 = comps.GroupBy(x => x.typeProc);
            foreach(IGrouping<string, Computer> comp in comp4)
            {
                Console.WriteLine(comp.Key);
                foreach(Computer e in comp)
                {
                    Console.WriteLine($"{e.codComp} {e.nameComp} {e.typeProc} {e.freqProc} {e.amountRAM} {e.amountHardDisk} {e.amountVideo} {e.costComp} {e.countInStock}");
                }
            }

            Computer comp5 = comps.OrderByDescending(x=>x.costComp).FirstOrDefault();
            Computer comp6 = comps.OrderBy(x=>x.costComp).FirstOrDefault();
            Console.WriteLine($"Самый дорогой вариант - {comp5.codComp} {comp5.nameComp}\nСамый дешевый вариант - {comp6.codComp} {comp6.nameComp}");

            if ((comps.Any(x=>x.countInStock>30))==true)
                Console.WriteLine("есть хотябы один компьютер в наличии от 30 штук");
            else
                Console.WriteLine("менее 30");

            Console.ReadKey();

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.codComp} {e.nameComp} {e.typeProc} {e.freqProc} {e.amountRAM} {e.amountHardDisk} {e.amountVideo} {e.costComp} {e.countInStock}");
            }
            Console.WriteLine();
        }
    }
}
