using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_site
{
    class Program
    {
        static void Main(string[] args)
        {
// 4.Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание
//сайта, ip адрес сайта.Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным
//полям через методы класса.
   
                Site w = new Site("sweet-cookie.com.od", "C//programm/system", "on-line shop with sweets", "PS//link/455666");
            Site w1 = new Site("prom.ua", "D//programm/system", "on-line multistore",  "PS//link/D3TR6767");
               
                w.Print();
                w1.Print();
            }
        }
        class Site

        {
            public Site() { Console.WriteLine("default const"); }
            public Site(string n, string ad, string inf,  string ip) // Конструктор класса
            {
                Name = n;
                Way = ad;
                info = inf;
                Ip = ip;

            }

            string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value != "")
                        name = value;
                }
            }

          string way;
            public string Way
            {
                get
                {
                    return way;
                }
                set
                {
                    if (value != "")
                        way = value;
                }
            }
            public string info { get; set; }
           
           // string ipad;
            public string Ip { get; set; }

            public void Print()
            {
                Console.WriteLine($"Web-site {Name} you can find at {Way} and we are {info}.Our IP-address is {Ip} ");
               
            }

        }
    }



