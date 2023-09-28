//Створіть клас «Магазин». Необхідно зберігати у полях класу:
//назву магазину, адреса, опис профілю магазину, контактний телефон, email.
//Реалізуйте методи класу для введення даних, виведення даних.
//Реалізуйте доступ до окремих полів через методи класу.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Shop shop = new Shop("Мій магазин", "вул. Бажана,10", "Це мій магазин", "1122334455", "my_shop@gmail.com");

            Console.WriteLine("Дані мого магазину:");
            shop.OutputDataShop();
            Console.WriteLine();

            shop.InputDataShop("Новий магазин", "вул. Соборна,33", "Це новий магазин", "9988776655", "new_shop@gmail.com");
            Console.WriteLine("Дані нового магазину:");
            shop.OutputDataShop();
            Console.ReadLine();

        }
    }
}
