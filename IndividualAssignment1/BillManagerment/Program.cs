namespace Bill_Manager;

class Program
{
    public static void Main()
    {
        BillManager BillManager = new BillManager();
        int choice = 0;
        
        do
        {
            Console.WriteLine("Choose: ");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Calculate the total amount of KW consumed");
            Console.WriteLine("4. Average money of foreign customers");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("----------------ADD CUSTOMER----------------");
                    Console.WriteLine("Choose customer's area:");
                    Console.WriteLine("1. Local customer");
                    Console.WriteLine("2. Foreign customer");
                    int choice2 = int.Parse(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        BillManager.CreateLocalCustomer();
                    }
                    else
                    {
                        BillManager.CreateForeignCustomer();
                    }
                    break;
                case 2:
                    if (BillManager.getList() == true)
                    {
                        Console.WriteLine("----------------DISPLAY----------------");
                        BillManager.getList();
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 3:
                    if (BillManager.getList() == true)
                    {
                        Console.WriteLine("----------------TOTAL OF KW----------------");
                        Console.WriteLine($"Total amount of KW consumed of Viet Nam Customer: " + BillManager.TotalKWOfVNC());
                        Console.WriteLine($"Total amount of KW consumed of Foriegn Customer: " + BillManager.TotalKWOfFC());
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 4:
                    if (BillManager.getList() == true)
                    {
                        Console.WriteLine("----------------AVERAGE----------------");
                        Console.WriteLine($"Average money of foreign customers: " + BillManager.AvgMoneyPay());
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
                case 5:
                    if (BillManager.getList() == true)
                    {
                        Console.WriteLine("----------------DELETE----------------");
                        Console.WriteLine($"Enter the id of customer: ");
                        int id = int.Parse(Console.ReadLine());
                        BillManager.Delete(id);
                    }
                    else
                    {
                        Console.WriteLine("There are no Customer!");
                    }
                    break;
            }
        } while (choice != 6);
    }

}