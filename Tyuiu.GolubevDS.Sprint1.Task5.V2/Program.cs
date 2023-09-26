using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GolubevDS.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, faren;
            Console.WriteLine("Введите температуру по Цельсию (°C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Температура в градусах по Фаренгейту(°F) : " + faren);
            Console.ReadLine();
        }
    }
}
