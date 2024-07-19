using System;

namespace PharmacyManagementSystem
{
    class Program
    {
        static string[] inventoryItems = new string[100];
        static int[] inventoryQuantities = new int[100];
        static int inventoryCount = 0;

        static string[] salesItems = new string[100];
        static int[] salesQuantities = new int[100];
        static decimal[] salesPrices = new decimal[100];
        static int salesCount = 0;

        static string[] prescriptionDetails = new string[100];
        static string[] prescriptionPatients = new string[100];
        static int prescriptionCount = 0;

        static string[] supplierNames = new string[100];
        static string[] supplierOrders = new string[100];
        static int supplierCount = 0;

        static string[] userNames = new string[100];
        static string[] userRoles = new string[100];
        static int userCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pharmacy Management System");
                Console.WriteLine("1. Inventory Management");
                Console.WriteLine("2. Sales and Billing");
                Console.WriteLine("3. Prescription Management");
                Console.WriteLine("4. Supplier Management");
                Console.WriteLine("5. Reporting and Analytics");
                Console.WriteLine("6. User Management");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ManageInventory();
                        break;
                    case 2:
                        ManageSales();
                        break;
                    case 3:
                        ManagePrescriptions();
                        break;
                    case 4:
                        ManageSuppliers();
                        break;
                    case 5:
                        GenerateReports();
                        break;
                    case 6:
                        ManageUsers();
                        break;
                    case 7:
                        return;
                    default:

                        Console.WriteLine("=======================================================================================");

                        Console.WriteLine("Invalid option. Please try again.");

                        Console.WriteLine("=======================================================================================");
                        break;
                }
            }
        }

        static void ManageInventory()
        {
            Console.WriteLine("Inventory Management");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter item name: ");
                inventoryItems[inventoryCount] = Console.ReadLine();
                Console.Write("Enter quantity: ");
                inventoryQuantities[inventoryCount] = int.Parse(Console.ReadLine());
                inventoryCount++;
            }
            else if (option == 2)
            {


                
                Console.WriteLine("Current Inventory:");

                Console.WriteLine();
                for (int i = 0; i < inventoryCount; i++)
                {


                    Console.WriteLine("==========================================================CurrentItem===================================================");
                    Console.WriteLine($"Item: {inventoryItems[i]}, Quantity: {inventoryQuantities[i]}");
                    Console.WriteLine("=====================================================================================================================");
                
                
                }
            }
            else
            {
                Console.WriteLine("=======================================================================================");

                Console.WriteLine("Invalid option. Please try again.");

                Console.WriteLine("=======================================================================================");
            }
        }

        static void ManageSales()
        {
            Console.WriteLine("Sales and Billing");
            Console.WriteLine("1. Add Sale");
            Console.WriteLine("2. View Sales");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter item name: ");
                salesItems[salesCount] = Console.ReadLine();
                Console.Write("Enter quantity: ");
                salesQuantities[salesCount] = int.Parse(Console.ReadLine());
                Console.Write("Enter price: ");
                salesPrices[salesCount] = decimal.Parse(Console.ReadLine());
                salesCount++;
            }
            else if (option == 2)
            {
                Console.WriteLine("Sales History:");
                for (int i = 0; i < salesCount; i++)
                {

                    Console.WriteLine("============================================Sales History=====================================");
                    
                    Console.WriteLine($"Item: {salesItems[i]}, Quantity: {salesQuantities[i]}, Price: {salesPrices[i]}");

                    Console.WriteLine("=================================================================================");

                }
            }
            else
            {
                Console.WriteLine("=======================================================================================");


                Console.WriteLine("Invalid option. Please try again.");

                Console.WriteLine("=======================================================================================");
            }
        }

        static void ManagePrescriptions()
        {
            Console.WriteLine("Prescription Management");
            Console.WriteLine("1. Add Prescription");
            Console.WriteLine("2. View Prescriptions");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter prescription details: ");
                prescriptionDetails[prescriptionCount] = Console.ReadLine();
                Console.Write("Enter patient's name: ");
                prescriptionPatients[prescriptionCount] = Console.ReadLine();
                prescriptionCount++;
            }
            else if (option == 2)
            {
                Console.WriteLine("Prescriptions:");
                for (int i = 0; i < prescriptionCount; i++)
                {

                    Console.WriteLine("===========================================Prescription================================");

                    Console.WriteLine($"Prescription: {prescriptionDetails[i]}, Patient: {prescriptionPatients[i]}");

                    Console.WriteLine("====================================================================================");
                }
            }
            else
            {

                Console.WriteLine("=======================================================================================");

                Console.WriteLine("Invalid option. Please try again.");

                Console.WriteLine("=======================================================================================");
            }
        }

        static void ManageSuppliers()
        {
            Console.WriteLine("Supplier Management");
            Console.WriteLine("1. Add Supplier");
            Console.WriteLine("2. View Suppliers");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter supplier's name: ");
                supplierNames[supplierCount] = Console.ReadLine();
                Console.Write("Enter purchase order: ");
                supplierOrders[supplierCount] = Console.ReadLine();
                supplierCount++;
            }
            else if (option == 2)
            {
                Console.WriteLine("Suppliers:");
                for (int i = 0; i < supplierCount; i++)
                {

                    Console.WriteLine("===============================Supplier Name===================================");

                   
                    Console.WriteLine($"Supplier: {supplierNames[i]}, Purchase Order: {supplierOrders[i]}");

                    Console.WriteLine("==================================================================================");

                
                }
            }
            else
            {


                Console.WriteLine("=======================================================================================");

                Console.WriteLine("Invalid option. Please try again.");

                Console.WriteLine("=======================================================================================");


            }
        }

        static void GenerateReports()
        {
            Console.WriteLine("Reporting and Analytics");
            Console.WriteLine("1. Inventory Report");
            Console.WriteLine("2. Sales Report");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Inventory Report:");
                for (int i = 0; i < inventoryCount; i++)
                {
                    Console.WriteLine($"Item: {inventoryItems[i]}, Quantity: {inventoryQuantities[i]}");
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Sales Report:");
                decimal totalSalesValue = 0;
                for (int i = 0; i < salesCount; i++)
                {

                    Console.WriteLine("=============================================Sales Item==========================================");


                    Console.WriteLine($"Item: {salesItems[i]}, Quantity: {salesQuantities[i]}, Price: {salesPrices[i]}");
                    totalSalesValue += salesQuantities[i] * salesPrices[i];

                    Console.WriteLine("=======================================================================================");


                }
                Console.WriteLine($"Total Sales Value: {totalSalesValue}");
            }
            else
            {

                Console.WriteLine("=======================================================================================");

                Console.WriteLine("Invalid option. Please try again.");


                Console.WriteLine("=======================================================================================");

            }
        }

        static void ManageUsers()
        {
            Console.WriteLine("User Management");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. View Users");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter username: ");
                userNames[userCount] = Console.ReadLine();
                Console.Write("Enter role: ");
                userRoles[userCount] = Console.ReadLine();
                userCount++;
            }
            else if (option == 2)
            {
                Console.WriteLine("Users:");
                for (int i = 0; i < userCount; i++)
                {


                    Console.WriteLine("===========================================User Name============================================");


                    Console.WriteLine($"Username: {userNames[i]}, Role: {userRoles[i]}");


                    Console.WriteLine("=======================================================================================");


                }
            }
            else
            {

                Console.WriteLine("=======================================================================================");


                Console.WriteLine("Invalid option. Please try again.");


                Console.WriteLine("=======================================================================================");


            }
        }
    }
}
