using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.YangolenkoDS.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("(x + y + z) * 5");
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine(DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
