using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practical_work_8._6
{
    internal class Task4
    {
        public void Task4Main()
        {
            XDocument xdoc = new XDocument();
            XElement people = new XElement("People");
            XElement person = new XElement("Person"); ;
            XElement adress = new XElement("Address"); ;
            XElement phones = new XElement("Phones"); ;
            XAttribute name;
            XElement street;
            XElement houseNumber;
            XElement flatNumber;
            XElement mobilePhone;
            XElement flatPhone;

            string str;

            while (true)
            {
                Console.WriteLine("Введите 1, что бы создать, введите 0, что бы выйти");
                str = Console.ReadLine();
                if (str == "0")
                    break;
                else
                {
                    Console.WriteLine("Введите ФИО человека");
                    name = new XAttribute("name", Console.ReadLine());

                    Console.WriteLine("Введите название улицы");
                    street = new XElement("Street", Console.ReadLine());

                    Console.WriteLine("Введите номер дома");
                    houseNumber = new XElement("HouseNumber", Console.ReadLine());

                    Console.WriteLine("Введите номер квартиры");
                    flatNumber = new XElement("FlatNumber", Console.ReadLine());

                    Console.WriteLine("Введите номер мобильного телефона");
                    mobilePhone = new XElement("MobilePhone", Console.ReadLine());

                    Console.WriteLine("Введите номер домашнего телефона");
                    flatPhone = new XElement("FlatPhone", Console.ReadLine());

                    phones.Add(mobilePhone);
                    phones.Add(flatPhone);
                    person.Add(name);
                    adress.Add(street);
                    adress.Add(houseNumber);
                    adress.Add(flatNumber);
                    person.Add(adress);
                    person.Add(phones);

                    people.Add(person);
                }
            }

            xdoc.Add(people);
            xdoc.Save("people.xml");
            Console.WriteLine("Data saved");
        }
    }
}
