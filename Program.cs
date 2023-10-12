//Створіть клас «Магазин». Необхідно зберігати у полях класу:
//назву магазину, адреса, опис профілю магазину, контактний телефон, email.
//Реалізуйте методи класу для введення даних, виведення даних.
//Реалізуйте доступ до окремих полів через методи класу.

// Додайте до вже створеного класу «Магазин» інформацію про площу магазину.
// Виконайте навантаження + (для збільшення площі магазину на вказаний розмір),
// — (для зменшення площі магазину на вказаний розмір),
// == (перевірка на рівність площ магазинів),
// < і > (перевірка магазинів менших або більших за площею),
// != і Equals.Використовуйте механізм властивостей полів класу.

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

            Shop shop1 = new Shop("Мій магазин", "вул. Бажана,10", "Це мій магазин", "1122334455", "my_shop@gmail.com", 32000);

            Console.WriteLine("Дані мого магазину:");
            shop1.OutputDataShop();
            Console.WriteLine();

            Shop shop2 = new Shop();
            shop2.InputDataShop("Новий магазин", "вул. Соборна,33", "Це новий магазин", "9988776655", "new_shop@gmail.com", 56000);
            Console.WriteLine("Дані нового магазину:");
            shop2.OutputDataShop();

            shop1.Comparison(shop1, shop2 );

            shop1.Area += 920;
            Console.WriteLine($"\nПлоща магазину \"{shop1.Name}\" збільшена на 920 м^2 : {shop1.Area}");
            shop1.Comparison(shop1 , shop2 );

            shop2.Area -= 32000;
            Console.WriteLine($"\nПлоща магазину \"{shop2.Name}\" зменшена на 32000 :{shop2.Area}");
            shop2.Comparison(shop1, shop2);

            Console.WriteLine($"\nПорівняння магазинів Equals (shop1, shop2): {Equals(shop1, shop2)}");

            shop1 = shop2;
            Console.WriteLine($"Порівняння магазинів Equals (shop1, shop2): {Equals(shop1, shop2)}");

            Console.ReadLine();

        }
    }
}
