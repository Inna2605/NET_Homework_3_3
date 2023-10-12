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
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_Homework_3_3
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Area { get; set; }

        public Shop()
        {
            Name = null;
            Address = null;
            Description = null;
            Phone = null;
            Email = null;
            Area = 0;
        }
        public Shop(string name, string address, string description, string phone, string email, int area)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
            Area = area;
        }
        public void InputDataShop(string name, string address, string description, string phone, string email, int area)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
            Area = area;    
        }
        public void OutputDataShop()
        {
            Console.WriteLine($"Назва магазину: {Name}");
            Console.WriteLine($"Адреса магазину: {Address}");
            Console.WriteLine($"Опис профілю магазину: {Description}");
            Console.WriteLine($"Контактний телефон: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Площа магазину: {Area}");
        }
        public void Comparison(Shop shop1, Shop shop2)
        {
            if (shop1.Area != shop2.Area)
            {
                Console.WriteLine("\nПлоща магазинів не рівна:");
                if (shop1.Area < shop2.Area)
                {
                    Console.WriteLine($"Площа магазину \"{shop2.Name}\"({shop2.Area}) більша ніж площа магазину \"{shop1.Name}\"({shop1.Area})");
                }
                else if (shop1.Area > shop2.Area)
                {
                    Console.WriteLine($"Площа магазину \"{shop1.Name}\"({shop1.Area}) більша ніж площа магазину \"{shop2.Name}\"({shop2.Area})");
                }
            }
            else if (shop1.Area == shop2.Area)
            {
                Console.WriteLine("\nПлоща магазинів рівна:");
                Console.WriteLine($"Площа магазину \"{shop1.Name}\"({shop1.Area}) рівна площі магазину \"{shop2.Name}\"({shop2.Area})");
            }
        }
        public static Shop operator+(Shop shop, int n)
        {
            shop.Area += n;
            return shop;
        }
        public static Shop operator -(Shop shop, int n)
        {
            shop.Area -= n;
            return shop;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1 == shop2;
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1 != shop2;
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1 < shop2;
        }
        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1 > shop2;
        }
    }
}
