using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> comps = new List<Computer>()
            {
                new Computer(){Code=1674,Name="Intel",CPUType=64,Frequency=3000,RAM=512,ROM=2000,GraphicsRAM=512,Price=32000,Amount=5},
                new Computer(){Code=1234,Name="Intel",CPUType=32,Frequency=1800,RAM=128,ROM=3000,GraphicsRAM=2048,Price=16800,Amount=4},
                new Computer(){Code=15734,Name="AMD",CPUType=32,Frequency=2000,RAM=512,ROM=2000,GraphicsRAM=1024,Price=31500,Amount=13},
                new Computer(){Code=134567,Name="Intel",CPUType=64,Frequency=3000,RAM=2048,ROM=7000,GraphicsRAM=128,Price=15000,Amount=30},
                new Computer(){Code=12,Name="Intel",CPUType=64,Frequency=3600,RAM=512,ROM=4000,GraphicsRAM=512,Price=28000,Amount=1},
                new Computer(){Code=176,Name="AMD",CPUType=32,Frequency=1800,RAM=1024,ROM=5000,GraphicsRAM=1024,Price=14700,Amount=3},
                new Computer(){Code=1446,Name="AMD",CPUType=32,Frequency=3000,RAM=512,ROM=2000,GraphicsRAM=512,Price=18000,Amount=7},
                new Computer(){Code=1856,Name="AMD",CPUType=64,Frequency=1500,RAM=256,ROM=3000,GraphicsRAM=2048,Price=12000,Amount=32},
                
            };

            Console.WriteLine("Введите марку процессора");
            string name = Console.ReadLine();
            List<Computer> comps1 = comps.Where(x => x.Name == name).ToList();
            Print(comps1);

            Console.WriteLine("Введите минимальный объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> comps2 = comps.Where(x => x.RAM >= ram).ToList();
            Print(comps2);

            Console.WriteLine("Стоимость в порядке возрастания:");
            List<Computer> comps3 = comps.OrderBy(x => x.Price).ToList();
            Print(comps3);

            Console.WriteLine("Сортровка по типу процессора:");
            IEnumerable<IGrouping<int, Computer>> comps4 = comps.GroupBy(x => x.CPUType);
            foreach (IGrouping<int, Computer> gr in comps4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{ e.Code} { e.Name} {e.CPUType } {e.Frequency } {e.RAM } {e.ROM } {e.GraphicsRAM } {e.Price } {e.Amount }");
                }
            }
             

            Console.WriteLine("Самый дорогой компьютер:");
            Computer comps5 = comps.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{ comps5.Code} { comps5.Name} {comps5.CPUType } {comps5.Frequency } {comps5.RAM } {comps5.ROM } {comps5.GraphicsRAM } {comps5.Price } {comps5.Amount }");
             

            Console.WriteLine("Самый дешевый компьютер:");
            Computer comps6 = comps.OrderByDescending (x => x.Price).LastOrDefault();
            Console.WriteLine($"{ comps6.Code} { comps6.Name} {comps6.CPUType } {comps6.Frequency } {comps6.RAM } {comps6.ROM } {comps6.GraphicsRAM } {comps6.Price } {comps6.Amount }");

            Console.WriteLine("Налиичие моделей, в количестве не менее 30 шт:");
            Console.WriteLine(comps.Any(x => x.Amount >= 30));


            Console.ReadKey();

            
        }
        static void Print(List<Computer> comps)
        {
            foreach (Computer e in comps)
            {
                Console.WriteLine($"{ e.Code} { e.Name} {e.CPUType } {e.Frequency } {e.RAM } {e.ROM } {e.GraphicsRAM } {e.Price } {e.Amount }");
            }
            Console.WriteLine();
        }
    }
}
