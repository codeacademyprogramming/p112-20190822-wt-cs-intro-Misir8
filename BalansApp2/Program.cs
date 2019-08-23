using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalansApp2
{
    class Program
    {
        class Person
        {
            public string Name { get; private set; }
            public string Surname { get; private set; }
            public string Id { get; private set; }
            public double Amount { get; private set; }

            public Person(string name, string surname, string id)
            {
                Name = name;
                Surname = surname;
                Id = id;
            }

            public string IncreaseAmount(double count)
            {
                Amount += count;
                return "Mebleg artirildi";
            }

            public string DecreaseAmount(double count)
            {
                if (count <= Amount)
                {
                    Amount -= count;
                    return "Mebleg cixildi";
                }
                else
                {
                    return "balansinda kifayrt qeder mebleg yoxdur";
                }
            }
        }

        static string ChangePersonInfo(ref Person person)
        {
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            if (String.IsNullOrEmpty(name)) return "Empty name";

            Console.WriteLine("Soyadinizi daxil edin: ");
            string surname = Console.ReadLine();
            if (String.IsNullOrEmpty(surname)) return "Empty surname";

            Console.WriteLine("Sexsiyyet vesiqesinin seriya nomresin daxil et");
            string IdNumber = Console.ReadLine();
            if (String.IsNullOrEmpty(IdNumber)) return "Empty IdNumber";

            person = new Person(name, surname, IdNumber);

            return "Ok";
        }

        static void Main(string[] args)
        {
            Person person = null;
            bool running = true;

            while (running)
            {
                if (person == null)
                {
                    Console.WriteLine(ChangePersonInfo(ref person));
                }
                else
                {
                    Console.WriteLine("1 - Balansa bax");
                    Console.WriteLine("2 - Balans artir");
                    Console.WriteLine("3 - Balansdan cixaris");
                    Console.WriteLine("4 - Hesab melumatlarin deyis");
                    Console.WriteLine("0 - cixis");

                    string balansBax = Console.ReadLine();

                    switch (Convert.ToInt32(balansBax))
                    {
                        case 1:
                            Console.WriteLine("balans " + person.Amount);
                            break;
                        case 2:
                            Console.WriteLine("Mebleg daxil et: ");
                            if (Double.TryParse(Console.ReadLine(), out double amount))
                            {
                                Console.WriteLine(person.IncreaseAmount(amount));
                            }
                            else
                            {
                                Console.WriteLine("Parse error");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Mebleg daxil et: ");
                            if (Double.TryParse(Console.ReadLine(), out amount))
                            {
                                Console.WriteLine(person.DecreaseAmount(amount));
                            }
                            else
                            {
                                Console.WriteLine("Parse error");
                            }

                            break;
                        case 4:
                            Console.WriteLine(ChangePersonInfo(ref person));
                            break;
                        case 0:
                            running = false;
                            break;
                    }
                }
            }
        }
    }
}
