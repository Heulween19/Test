using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Test
{
    internal class Program
    { enum Month
        {
            January=1,    //0
            February,  //1 
            March,      //2
            April,      //3
            May,        //4
            June,       //5
            July,       //6
            August,     //7
            September,   //8
            October,     //9
            November,   //10
            December    //11

        }
        static void Main(string[] args)
        { 
        Console.InputEncoding=Encoding.UTF8;
        Console.OutputEncoding=Encoding.UTF8;
            int eMonth;
            Console.WriteLine("Nhap so thang");
            eMonth = int.Parse(Console.ReadLine());
            
            switch (eMonth)
            {
                case 1:
                    Console.WriteLine(Month.January);
                    break;
                case 2:
                    Console.WriteLine(Month.February);
                    break;
                case 3:
                    Console.WriteLine(Month.March);
                    break;
                default:
                    Console.WriteLine("Sai dinh dang");
                    break;

            }

            int eMonth1;
            Console.WriteLine("Nhap so thang");
            eMonth1 = int.Parse(Console.ReadLine());
            if (eMonth1 == 1)
            {
                Console.WriteLine("Ban vua chon thang: " + (Month)1);
            }


            if (eMonth1 == (int)Month.February)
            {
                Console.WriteLine("Ban vua chon thang: " + (Month)2);
            }




            Console.ReadKey();
        
        } 
           


    
        
        
    }
}
