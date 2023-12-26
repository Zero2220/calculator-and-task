using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verilmiş yazının sonundaki boşluları silinmiş yeni bir yazı düzəldən proqram yazırsınız

            Console.WriteLine("yazini daxil edin ");

            string text = Console.ReadLine();


            string new_text = text ;

            
            int endIndex = text.Length - 1 ;  
            

            while(endIndex >=0 &&endIndex != ' ') 
            {
             
             endIndex--;
            
            
            }



            for(int i = endIndex ;i >= 0;i--)
            {

                new_text += text[i];


            }


            Console.WriteLine(new_text);
        }
    }
}
