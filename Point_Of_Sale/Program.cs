using System;
using System.IO;


namespace Point_Of_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Inventory productsInStock = new Inventory();
            Customer c = new Customer();
            
            PopulateMenu(productsInStock);

            productsInStock.ListProducts();


            while (keepGoing)
            {
                Console.WriteLine("Please select a choice");
                int choice = int.Parse(Console.ReadLine());
                foreach (Product p in productsInStock.Products)
                {
                    if (p.Id == choice)
                    {
                        Console.WriteLine("How many?");
                        int quant = int.Parse(Console.ReadLine());
                        c.AddToCart(p, quant);
                    }
                }
                Console.WriteLine("Would you like anything else? y/n");
                if(Console.ReadLine()=="y")
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
            }
            Console.WriteLine(c.GetSubTotal(c));
            Console.WriteLine(c.GetTotal(c));
            Console.WriteLine("How much moneys you givin?");
            double.TryParse(Console.ReadLine(), out double tenderInput);

            Console.WriteLine($"Your change is {c.GetChange(tenderInput)}");


            static void PopulateMenu(Inventory productsInStock)
            {
                StreamReader SR = new StreamReader(@"menuItems.txt");
                while (SR.Peek() >= 0)
                {
                    string str;
                    string[] strArray;

                    str = SR.ReadLine();
                    strArray = str.Split(';');

                    productsInStock.AddProduct(new Product(strArray[0], strArray[1], strArray[2], double.Parse(strArray[3])));
                }

            }
            Console.WriteLine("Thank you. Come again.");
            Console.ReadLine();
        }
    }
}
