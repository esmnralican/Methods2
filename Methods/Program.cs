using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string productName1 = "Apple";
            double price = 12;
            string expression = "Apple of Amasya";*/

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 12;
            product1.Expression = "Apple of Amasya";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 90;
            product2.Expression = "Watermelon of Diyarbakır";

            Product[] products = new Product[] { product1, product2 };

            //type safe
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Expression);
                Console.WriteLine("**************");
            }

            Console.WriteLine("           METHODS");
            //iinstance

            // encapsulation : Normalde ayrı ayrı olarak yazılmakta olan bir yapıyı tek bir ana başlık altında toplamak gibi düşünülebilir
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Peach", "Green color", 12, 9);
            sepetManager.Add2("Apple", "Red color", 13, 0);
            sepetManager.Add2("Banana", "Yellow color", 21, 9);
        }
    }
}
