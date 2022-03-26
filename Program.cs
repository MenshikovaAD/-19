using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer () {TypeCode = 013258, Name = "ASUS", ProcessorType = "Intel Core i5" , ProcessorFrequency ="2.5 ГГц" , AmountOfRAM =8 , HardDiskCapacity = "512 ГБ" , VideoServerMemory = "4 ГБ" , Summa = 108000 , QuantityInStock = 3},
                new Computer () {TypeCode = 015698, Name = "ASUS", ProcessorType = "Intel Core i3" , ProcessorFrequency ="1.5 ГГц" , AmountOfRAM =4 , HardDiskCapacity = "256 ГБ" , VideoServerMemory = "2 ГБ" , Summa = 78246 , QuantityInStock = 6},
                new Computer () {TypeCode = 056222, Name = "Aicer", ProcessorType = "Intel Core i5" , ProcessorFrequency ="1.5 ГГц" , AmountOfRAM =8 , HardDiskCapacity = "256 ГБ" , VideoServerMemory = "4 ГБ" , Summa = 54500 , QuantityInStock = 7},
                new Computer () {TypeCode = 013639, Name = "Aicer", ProcessorType = "Intel Core i5" , ProcessorFrequency ="2.5 ГГц" , AmountOfRAM =4 , HardDiskCapacity = "128 ГБ" , VideoServerMemory = "2 ГБ" , Summa = 38000 , QuantityInStock = 3},
                new Computer () {TypeCode = 078522, Name = "Apple", ProcessorType = "Intel Core i7" , ProcessorFrequency ="2.5 ГГц" , AmountOfRAM =8 , HardDiskCapacity = "512 ГБ" , VideoServerMemory = "4 ГБ" , Summa = 198560 , QuantityInStock = 12},
                new Computer () {TypeCode = 069852, Name = "Apple", ProcessorType = "Intel Core i7" , ProcessorFrequency ="2.5 ГГц" , AmountOfRAM =8 , HardDiskCapacity = "512 ГБ" , VideoServerMemory = "4 ГБ" , Summa = 189563 , QuantityInStock = 31},
                new Computer () {TypeCode = 045875, Name = "Huawei", ProcessorType = "Intel Core i3" , ProcessorFrequency ="1.5 ГГц" , AmountOfRAM =4 , HardDiskCapacity = "128 ГБ" , VideoServerMemory = "4 ГБ" , Summa = 46950 , QuantityInStock = 9},
            };
            Console.WriteLine("Введите тип процессора");
            string processorType = Console.ReadLine();

            List<Computer> computers1 = computers.Where(c => c.ProcessorType == processorType).ToList();
            Print(computers1);
            

            Console.WriteLine("Введите объем оперативной памяти");
            int amountOfRAM = Convert.ToInt32(Console.ReadLine());

            List<Computer> computers2 = computers.Where(c => c.AmountOfRAM >= amountOfRAM).ToList();
            Print(computers2);
            

            List<Computer> computers3 = computers.OrderBy(c => c.Summa).ToList();
            Print(computers3);
            

            IEnumerable<IGrouping<String, Computer>> computers4 = computers.GroupBy(x => x.ProcessorFrequency);
            foreach(IGrouping<String, Computer> g in computers4 )
                {
                Console.WriteLine(g.Key);
                foreach (Computer e in g)
                {
                    Console.WriteLine($"{e.TypeCode}. {e.Name}, {e.ProcessorType}, {e.ProcessorFrequency}, {e.AmountOfRAM}, {e.HardDiskCapacity}, {e.VideoServerMemory}, {e.Summa}, {e.QuantityInStock}");
                }
            }


            Computer computers5 = computers.OrderByDescending(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{computers5.TypeCode}. {computers5.Name}, {computers5.ProcessorType}, {computers5.ProcessorFrequency}, {computers5.AmountOfRAM}, {computers5.HardDiskCapacity}, {computers5.VideoServerMemory}, {computers5.Summa}, {computers5.QuantityInStock}");

            Computer computers6 = computers.OrderBy(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{computers6.TypeCode}. {computers6.Name}, {computers6.ProcessorType}, {computers6.ProcessorFrequency}, {computers6.AmountOfRAM}, {computers6.HardDiskCapacity}, {computers6.VideoServerMemory}, {computers6.Summa}, {computers6.QuantityInStock}");


            Console.WriteLine(computers.Any(x=>x.QuantityInStock>=30));
            Console.ReadKey();
        }

        static void Print (List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.TypeCode}. {e.Name}, {e.ProcessorType}, {e.ProcessorFrequency}, {e.AmountOfRAM}, {e.HardDiskCapacity}, {e.VideoServerMemory}, {e.Summa}, {e.QuantityInStock}");    
            }
            Console.WriteLine();
        }
    }
}
