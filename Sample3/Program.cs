using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    abstract class PopularCategories
    {
        //default steps
        public void SearchItem()
        {
            Console.WriteLine("Needed items are serached.");
        }

        //steps that will be overidden by subclass
        public abstract void AddToCart();

        //default step
        public void ByItem()
        {
            Console.WriteLine("Pay with online or offline.");
        }

        //template method
        public void AddCart()
        {
            this.SearchItem();
            this.AddToCart();
            this.ByItem();
        }
    }

    class Wristwatche : PopularCategories
    {
        public override void AddToCart()
        {
            Console.WriteLine("Select item and add to cart.");
        }
    }
    class Sneakers : PopularCategories
    {
        public override void AddToCart()
        {
            Console.WriteLine("Select item and add to cart.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Popular Category - Wristwatche ----");
            PopularCategories fromCustomer = new Wristwatche();
            fromCustomer.AddCart();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("---- Popular Category - Sneakers ----");
            fromCustomer = new Sneakers();
            fromCustomer.AddCart();

            Console.ReadLine();
        }
    }
}
