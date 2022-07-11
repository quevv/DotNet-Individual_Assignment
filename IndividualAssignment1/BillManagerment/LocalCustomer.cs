using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager
{
    public class LocalCustomer : Customer
    {


        public string CustomerType { get; set; }
        //định mức
        public int Norm { get; set; }

        public LocalCustomer(int customerID, string name, string address, int quantity, decimal unitPrice,
            decimal moneyPay, string customerType, int norm) :
            base(customerID, name, address, quantity, unitPrice, moneyPay)
        {
            CustomerType = customerType;
            Norm = norm;
        }

        public override string? ToString()
        {
            return $"Customer ID: {CustomerID}, Name: {Name}, Address: {Address},Type of Customer: {CustomerType}, Quantity: {Quantity}, " +
                $"Unit price: {UnitPrice}, Norm: {Norm}, Money Pay: {MoneyPay}";
        }
    }
}
