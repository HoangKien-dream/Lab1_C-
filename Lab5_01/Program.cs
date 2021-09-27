using System;
using Customer;
using Order;

namespace Customer
{
    class Cust_details
    {
        public string strName;

        public void getName()
        {
            Console.WriteLine("Enter your name: ");
            strName = Console.ReadLine();
        }
    }
}

namespace Order
{
    class Grocery_items
    {
        public void Ord_grocery()
        {
            Cust_details objCust1 = new Cust_details();
            objCust1.getName();
            Console.WriteLine("Hello {0}", objCust1.strName);
            Console.WriteLine("You have order grocery items");
        }
    }

    class Bakery_items
    {
        public void Ord_Bakery()
        {
            Cust_details objCust2 = new Cust_details();
            objCust2.getName();
            Console.WriteLine("Hello {0}",objCust2.strName);
            Console.WriteLine("You have order bakery items");
        }
        
    }
}

class OrderTest
{
    public static void Main(string[] args)
    {
        string choice;
        Console.WriteLine("What would you like to order? 1-Grocery Items, 2-Bakery Items");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            Grocery_items groceryItems = new Grocery_items();
            groceryItems.Ord_grocery();
        }
        else
        {
            if (choice == "2")
            {
                Bakery_items bakeryItems = new Bakery_items();
                bakeryItems.Ord_Bakery();
            }
            else
            {
                Console.WriteLine("Enter either 1 or 2");
            }
        }

        Console.ReadLine();
    }
}