using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{public class Program

    {
        static void Main(string[] agrs)
        {



            // Console.Write ("Введите число1:");
            // var number1 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Введите число2:");
            // var number2 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Введите число3:");
            // var number3 = Convert.ToDouble (Console.ReadLine ());
            // if (число1> = 0)
            // {
            //     число1 = Math.Pow (число1, 2);
            // }
            //  else
            // {
            //     число1 = Math.Pow (число1, 4);
            // }

            // if (number3> = 0) number3 = Math.Pow (number3, 2);
            // else number3 = Math.Pow (number3, 4);



            // число2 = (число2> = 0)? Math.Pow (число2, 2): Math.Pow (число2, 4);
            // Console.WriteLine ($ "число2 = {число2} \ n число1 = {число1} \ n число3 = {число3}");
            // Console.ReadLine ();

            // Console.Write ("Input: x1:");
            // var x1 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Input: y1:");
            // var y1 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Input: x2:");
            // var x2 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Input: y2:");
            // var y2 = Convert.ToDouble (Console.ReadLine ());
            // var Dlina1 = Math.Sqrt (Math.Pow (x1, 2) + Math.Pow (y1, 2));
            // var Dlina2 = Math.Sqrt (Math.Pow (x2, 2) + Math.Pow (y2, 2));
            // if (Длина1 <Длина2)
            // {
            // Console.WriteLine ("Первая точка ближе");
            // }
            // else
            // {
            //   Console.WriteLine ("Вторая точка ближе");
            // }
            //             Console.ReadLine ();


            // Console.Write ("Input: Ugol1:");
            // var Ugol1 = Convert.ToDouble (Console.ReadLine ());
            // Console.Write ("Input: Ugol2:");
            // var Ugol2 = Convert.ToDouble (Console.ReadLine ());

            // if ((Ugol1 + Ugol2) <180)
            // {
            // Console.WriteLine ("Треугольник существует");

            // else ((Ugol1 == 90 || Ugol2 == 90 || Ugol1 + Ugol2 == 90))
            // {
            // Console.WriteLine ("Треугольник прямоугольный");

            // }

            // else Console.WriteLine ("Треугольник непрямоугольный");

            // }
            // else Console.WriteLine ("Треугольник несуществует");











            Console.Write("Число1");
            var Число1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число2:");
            var Число2 = Convert.ToDouble(Console.ReadLine());
            var Polusumma = (Число1 +Число2) / 2;
            var Proizvedenie = 2 * (Число1 + Число2);

            if(Число1 < Число2)
            {
                Число1 = Polusumma;
                Число2 = Proizvedenie;

            }
            else
            {
                Число2 = Polusumma;
                Число1 = Proizvedenie;
            }
            Console.WriteLine( $" Число 1 = { Число1 } ");
            Console.WriteLine( $" Число 2 = { Число2 } ");









            Console.ReadLine();
        }
    }
}





