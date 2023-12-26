using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {




            bool check = true;
            do
            {

                check = true;

                Console.WriteLine("1: Toplama");

                Console.WriteLine("2: Cixma");

                Console.WriteLine("3: Vurma");

                Console.WriteLine("4: Bolme");

                Console.WriteLine("0: Emeliyyati bitir ");





                Console.WriteLine("eded daxil edin ");
                string  eded = Console.ReadLine();



                

                switch (eded)
                {

                    case "1":

                        Console.WriteLine("eded daxil edin ");
                        int a = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("eded daxil edin ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int result = a + b;

                        Console.WriteLine(result);

                        break;


                    case "2":

                        Console.WriteLine("eded daxil edin ");
                        int c = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("eded daxil edin ");
                        int d = Convert.ToInt32(Console.ReadLine());

                        int result1 = c - d;
                        Console.WriteLine(result1);
                        break;


                    case "3":
                        Console.WriteLine("eded daxil edin ");
                        int e = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("eded daxil edin ");
                        int f = Convert.ToInt32(Console.ReadLine());

                        int result2 = e*f;
                        Console.WriteLine(result2);
                        break;



                    case "4":

                        Console.WriteLine("eded daxil edin ");
                        int g = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("eded daxil edin ");
                        int h = Convert.ToInt32(Console.ReadLine());

                        if (h > 0)
                        {
                            int result3 = g / h;
                            Console.WriteLine(result3);

                        }
                        else Console.WriteLine("emeliyyat yanlishdir");
                        break;


                    case "0":
                        
                        break;


                    default:

                        Console.WriteLine("yanlish eded daxil edildi yeniden cehd edin ");

                        check = false;
                        break;





                }





            }
            while (check == false);
                
                
            




        }
    }
}
