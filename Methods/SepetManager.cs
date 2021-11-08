using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //if there is any pharenthesis, it works methods
        public void Add( Product product)
        {
            Console.WriteLine("Congrats! Added to cart  : " + product.Name);
        }

        public void Add2 (string productName, string expression, double price, int amountofStock  ) 
        {
            Console.WriteLine("Congrats! Added to cart  : " + productName);
        
        }
    }
}
