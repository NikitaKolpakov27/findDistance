using System;
using Logic;

namespace Task
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double V, U, T1, T2;
            
            Console.WriteLine("Определить путь S, пройденный лодкой.");
            Console.WriteLine("Введите скорость лодки: ");
            string v = Console.ReadLine();
            Console.WriteLine("Введите скорость течения: ");
            string u = Console.ReadLine();
            Console.WriteLine("Введите время по озеру: ");
            string t1 = Console.ReadLine();
            Console.WriteLine("Введите время по реке: ");
            string t2 = Console.ReadLine();

            if (!double.TryParse(v, out V) || !double.TryParse(u, out U) || !double.TryParse(t1, out T1) ||
                !double.TryParse(t2, out T2))
            {
                Console.WriteLine("Неверные данные!");
            }
            else
            {
                
                if (V < 0 || U < 0 || T1 < 0 || T2 < 0)
                {
                    Console.WriteLine("Введены орицательные значения!");
                    return;
                }
                
                var b = new Log();
                Console.WriteLine("Путь равен: " + b.findDistance(V, U, T1, T2));
            }
        }
    }
}