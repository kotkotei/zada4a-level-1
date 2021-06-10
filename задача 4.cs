using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//4.	Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? 
            Console.WriteLine("стоимость монитора: m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("стоимость систем болка: s");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("стоимость клава : c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("стоимость мышь: k");
            int k = Convert.ToInt32(Console.ReadLine());
            int b = (m+s+c+k)*3;
            Console.WriteLine("Цена покупки:" + b);
            Console.ReadKey();

        }
    }
}
