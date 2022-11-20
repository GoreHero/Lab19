using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        class Door
        {
            public int Id { get; set; }
            public string Material { get; set; }
            public int Height { get; set; }
        }

        static void Main(string[] args)
        {
            List<Door> listDoor = new List<Door>()
            {
                new Door() { Id = 1, Material = "Дерево", Height =2000},
                new Door() { Id = 2, Material = "Стекло", Height =2000},
                new Door() { Id = 3, Material = "Метал", Height =2000},
                new Door() { Id = 4, Material = "Дерево", Height =2700},
                new Door() { Id = 5, Material = "Дерево", Height =2300},
                new Door() { Id = 6, Material = "Метал", Height =2200},
                new Door() { Id = 7, Material = "Дерево", Height =2000},

            };
            //IEnumerable<Door> doors = from d in listDoor
            //                   where d.Material=="Дерево"
            //                   select d;  
            //list<Door> doors = (from d in listDoor
            //                   where d.Material=="Дерево"
            //                   select d).ToList();      //если нужно сохранить списком
              
            Door doors = listDoor
                .Where(d => d.Material == "Дерево")
                .First();

            //int a = 3;
            //int b = 4;
            //int c = a.Add(b);
            //Console.WriteLine(c);

            Console.WriteLine(doors.Id);

            //foreach (Door d in doors)
            //    Console.WriteLine($"{d.Id} {d.Material} {d.Height}");
            //Console.ReadKey();



        }

    }
    //static class IntExtension
    //{

    //    public static int Add(this int v1, int v2)
    //    {
    //        return v1 + v2;
    //    }
    //}
}
