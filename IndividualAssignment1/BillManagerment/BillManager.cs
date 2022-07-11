using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Manager
{
    public class BillManager
    {
        private const double V = 2.5;
        private List<LocalCustomer> vnc = new List<LocalCustomer>();
        private List<ForeignCustomer> foreignCustomer = new List<ForeignCustomer>();
        public void CreateLocalCustomer()
        {
            decimal moneyPay = 0;
            int customerID = 0;
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Enter customer ID: ");
                customerID = int.Parse(Console.ReadLine());
                try
                {
                    if (CheckID(customerID) == true)
                    {
                        Console.WriteLine("ID = " + customerID + " is existed!");
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                catch (Exception)
                {
                }
            }
            Console.WriteLine("Enter customer name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string? address = Console.ReadLine();
            Console.WriteLine("Enter kind of customer: ");
            string? kindOfCustomer = Console.ReadLine();
            Console.WriteLine("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter unit price: ");
            decimal unitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter norm: ");
            int norm = int.Parse(Console.ReadLine());
            if (quantity <= norm)
            {
                moneyPay = quantity * unitPrice;
            }
            else
            {
                moneyPay = quantity * unitPrice * norm + ((quantity - norm) * unitPrice * (decimal)V);
            }
            vnc.Add(new LocalCustomer(customerID, name, address, quantity, unitPrice, moneyPay, kindOfCustomer, norm));
        }
        public void CreateForeignCustomer()
        {
            int customerID = 0;
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Enter customer ID: ");
                customerID = int.Parse(Console.ReadLine());
                try
                {
                    if (CheckID(customerID) == true)
                    {
                        Console.WriteLine("ID = " + customerID + " is existed!");
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                catch (Exception)
                {
                }
            }
            Console.WriteLine("Enter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter National: ");
            string national = Console.ReadLine();
            Console.WriteLine("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter unit price: ");
            decimal unitPrice = decimal.Parse(Console.ReadLine());
            decimal moneyPay = quantity * unitPrice;
            foreignCustomer.Add(new ForeignCustomer(customerID, name, address, quantity, unitPrice, moneyPay, national));
        }
        public bool getList()
        {
            bool check = false;
            foreach (LocalCustomer cus in vnc)
            {
                Console.WriteLine(cus.ToString());
                check = true;
            }
            foreach (ForeignCustomer FCus in foreignCustomer)
            {
                Console.WriteLine(FCus.ToString());
                check = true;
            }
            return check;
        }
        public int TotalKWOfVNC()
        {
            int totalKW = 0;
            foreach (LocalCustomer cus in vnc)
            {
                totalKW += cus.Quantity;
            }
            return totalKW;
        }
        public int TotalKWOfFC()
        {
            int totalKW = 0;
            foreach (ForeignCustomer cus in foreignCustomer)
            {
                totalKW += cus.Quantity;
            }
            return totalKW;
        }
        public int AvgMoneyPay()
        {
            decimal total = 0;
            int avgMoneyPay = 0;
            int count = 0;
            foreach (var cus in foreignCustomer)
            {
                total += cus.MoneyPay;
                count++;
            }
            return avgMoneyPay = (int)(total / count);
        }
        public void Delete(int id)
        {
            foreach (var cus in vnc)
            {
                if (cus.CustomerID == id)
                {
                    vnc.Remove(cus);
                }
            }
            foreach (var cus in foreignCustomer)
            {
                if (cus.CustomerID == id)
                {
                    foreignCustomer.Remove(cus);
                }
            }
        }
        public bool CheckID(int id)
        {
            bool check = false;
            foreach (var cus in vnc)
            {
                if (cus.CustomerID == id)
                {
                    check = true;
                }
            }
            foreach (var cus in foreignCustomer)
            {
                if (cus.CustomerID == id)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
