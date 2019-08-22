using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalansApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        Label1:
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyanidizi daxil edin: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Sexsiyyet Vesiqesinin seriyasi");
            string IdNumber = Console.ReadLine();

        Label:
            Console.WriteLine("1 - Balansa bax");
            Console.WriteLine("2 - Balans artir");
            Console.WriteLine("3 - Balansdan cixaris");
            Console.WriteLine("4 - Hesab melumatlarini deyis");
            Console.WriteLine("0 - Cixis");

            string balansBax = Console.ReadLine();

            double mebleg;

            /* if (Convert.ToInt32(balansBax) == 1)
             {
                 Console.WriteLine("balansiniz 0");
             }
             if (Convert.ToInt32(balansBax) == 2)
             {
                 Console.WriteLine("Mebleg daxil edin: ");
                 mebleg = Convert.ToDouble(Console.ReadLine());

                 goto Label; 
             }
             if (Convert.ToInt32(balansBax) == 3)
             {
                 Console.WriteLine("Mebleg daxil edin: ");
                 double cixilanMebleg = Convert.ToDouble(Console.ReadLine());
                 if(mebleg - cixilanMebleg < 0)
                 {
                     Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                 }
             } */
            switch (Convert.ToInt32(balansBax))
            {
                case 1:
                    Console.WriteLine("balansiniz 0");
                    break;
                case 2:
                    Console.WriteLine("Mebleg daxil edin: ");
                    mebleg = Convert.ToDouble(Console.ReadLine());
                    goto Label;
                    break;
                case 3:
                    Console.WriteLine("Mebleg daxil edin: ");
                    double cixilanMebleg = Convert.ToDouble(Console.ReadLine());
                    if (cixilanMebleg < 0)
                    {
                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");

                    }
                    goto Label;
                    break;
                case 4:
                    goto Label1;
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }


            Console.ReadKey();
        }
    }
}
