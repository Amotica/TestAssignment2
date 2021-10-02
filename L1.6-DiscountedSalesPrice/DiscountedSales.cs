using System;

namespace L1._6_DiscountedSalesPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product name.");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter discount offered.");
            int discount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter original sales Price.");
            decimal orignalPrice = decimal.Parse(Console.ReadLine());

            decimal discountPrice = orignalPrice - ((discount/100m) * orignalPrice);

            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Original Price: " + orignalPrice.ToString(C2));
            Console.WriteLine("At a discount of " + discount + "%, the discounted Price is " + discountPrice.ToString("C2"));
        }
    }
}
