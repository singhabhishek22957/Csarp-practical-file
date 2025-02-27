using System;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; } // Discount in percentage
        
        public double GetTotal()
        {
            double total = Quantity * Price;
            double discountAmount = total * (Discount / 100);
            return total - discountAmount;
        }
    }

    static void Main()
    {
        List<Product> products = new List<Product>();
        Console.WriteLine("Welcome to the Billing System\n");
        
        while (true)
        {
            Product p = new Product();
            Console.Write("Enter product name (or type 'done' to finish): ");
            p.Name = Console.ReadLine();
            if (p.Name.ToLower() == "done") break;

            Console.Write("Enter quantity: ");
            p.Quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter price per unit: ");
            p.Price = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter discount (%): ");
            p.Discount = Convert.ToDouble(Console.ReadLine());
            
            products.Add(p);
            Console.WriteLine("Product added successfully!\n");
        }

        Console.WriteLine("\n------ Bill Summary ------");
        double grandTotal = 0;
        
        Console.WriteLine( "Product\t\t\tQuantity\tPrice\t\tDiscount\t\tTotal");
        Console.WriteLine("------------------------------------------------------------");
        
        foreach (var item in products)
        {
            double total = item.GetTotal();
            grandTotal += total;
            Console.WriteLine(item.Name+"\t\t\t"+item.Quantity+"\t\t"+ item.Price+"\t\t"+item.Discount + "%"+"\t\t"+total);
        }

        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Grand Total: Rs. " + grandTotal);
        Console.WriteLine("\nThank you for shopping!\n");
    }
}
