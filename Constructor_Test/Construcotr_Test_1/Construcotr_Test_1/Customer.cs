using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construcotr_Test_1
{
    internal class Customer
    {
        private string CustomerID;

        private string CustomerName;
        

        public Customer(string iD,string name)
        {
            this.CustomerID=iD;
            this.CustomerName=name; 
        }
        public string getCustomerID()
        {
            return CustomerID;
        }
        public void setCustomerID(string newID)
        {
            if(CustomerID==null && CustomerID.Length>=10)
            {
                Console.WriteLine("ID không hợp lệ!");
                Console.WriteLine("Nhập ID: ");
                CustomerID =Console.ReadLine();
            }
            else
            {
                CustomerID = newID;
            }
        }

        public string getCustomerName()
        {
            return CustomerName;
        }
        public void setCustomerName( string newName)
        {
            if (CustomerName == null && CustomerName.Length >= 50)
            {
                Console.WriteLine("Tên không hợp lệ!");
                Console.WriteLine("Nhập tên: ");
                CustomerName = Console.ReadLine();
            }
            else
            {
                CustomerName = newName;
            }
        }

       
    }
}
