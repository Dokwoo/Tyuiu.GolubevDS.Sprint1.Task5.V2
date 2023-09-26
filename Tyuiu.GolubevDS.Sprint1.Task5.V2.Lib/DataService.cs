using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GolubevDS.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double celsius = (temp - 32) * 5 / 9;

            Console.WriteLine($"Температура в градусах Цельсия: {Math.Round(celsius)}");

            return (int) celsius;
        }
    }
}
