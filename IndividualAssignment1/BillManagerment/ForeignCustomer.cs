using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager
{
    public class ForeignCustomer : Customer
    {
        public string National { get; set; }
        public ForeignCustomer(int customerID, string name, string address, int quantity, decimal unitPrice, decimal moneyPay, string national) :
            base(customerID, name, address, quantity, unitPrice, moneyPay)
        {
            National = national;
        }

        public override string? ToString()
        {
            return $"Customer ID: {CustomerID}, Name: {Name}, Address: {Address},Nation: {National},Quantity: {Quantity}, " +
                $"Unit price: {UnitPrice}, Money Pay: {MoneyPay}";
        }
    }
}
