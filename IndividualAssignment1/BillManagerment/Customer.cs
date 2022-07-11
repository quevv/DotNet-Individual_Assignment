using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal MoneyPay { get; set; }

        public Customer(int customerID, string name, string address, int quantity, decimal unitPrice, decimal moneyPay)
        {
            CustomerID = customerID;
            Name = name;
            Address = address;
            Quantity = quantity;
            UnitPrice = unitPrice;
            MoneyPay = moneyPay;
        }
    }
}
