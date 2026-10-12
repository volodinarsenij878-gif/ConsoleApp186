using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program37
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Стоимость товара (руб): ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                if (price == 0)
                    Console.WriteLine("Акция!");
                else
                    Console.WriteLine("Обычная цена.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}