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
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Shop(string name, string address, string description, string phone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
        }
        public void InputDataShop(string name, string address, string description, string phone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
        }
        public void OutputDataShop()
        {
            Console.WriteLine($"Назва магазину: {Name}");
            Console.WriteLine($"Адреса магазину: {Address}");
            Console.WriteLine($"Опис профілю магазину: {Description}");
            Console.WriteLine($"Контактний телефон: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
