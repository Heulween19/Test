using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construcotr_Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;

            Customer Huyen = new Customer("MS001", "HUyền");
            Console.WriteLine(Huyen.getCustomerID());
            Console.WriteLine(Huyen.getCustomerName());
            Huyen.setCustomerID("MS1902");
            Console.WriteLine("ID mới: "+ Huyen.getCustomerID());
        }
    }
}
