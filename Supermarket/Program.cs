using Supermarket;
using System.Diagnostics;
using System.Xml.Linq;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            string keyWord = null;
            do
            {
                Console.Write("Do you want to stock more? (Yes/stocked): ");
                keyWord = Console.ReadLine();
                if (keyWord == "stocked")
                {

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    double quantity = double.Parse(Console.ReadLine());
                    Products product1 = new Products(name, price, quantity);
                    product1.QuantityPrice = product1.Quantity * product1.Price;
                    Products.Sum += product1.QuantityPrice;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name == name)
                        {
                            products.RemoveAt(i);
                        }
                    }
                    products.Add(product1);
                }

            } while (keyWord != "stocked");
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Pechat();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: {Products.Sum:F2}");
        }
    }
}
