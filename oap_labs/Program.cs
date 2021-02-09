using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{

    class Program
    {
        static void Main(string[] args)
        {
            // команда Console.Write выводит текст в консоль
            Console.Write("Input katet1: ");
            // команда Console.ReadLine читает СТРОКУ из консоли
            var Katet1 = Console.ReadLine();

            Console.Write("Input katet2: ");
            var Katet2 = Console.ReadLine();

            // команда Math.Sqrt - квадратный корень
            // Math.Pow - возведение в степень
            // Convert.ToDouble - преобразует строку в число
            var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(Katet1), 2) + Math.Pow(Convert.ToDouble(Katet2), 2));
            var Perimetr = Katet1 + Katet2 + Gipotenuza;
            // выводим результат
            // знак $ перед строкой указывает, что внутри строки в фигурных скобках названия переменных
            Console.WriteLine($"Gipotenuza = {Gipotenuza}");
            Console.WriteLine($"Perimetr = {Perimetr}");

            // читаем строку, чтобы консольное окно сразу не закрылось
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}


