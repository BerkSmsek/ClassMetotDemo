using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // iki tür yazım yapabiliriz 1. si aşağıdaki gibi 
            Product product1 = new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsStock = 3;
            // ikinci tür yazım aşağıdaki gibi
            Product product2 = new Product { Id = 2, CategoryId = 3,
                ProductName = "Televizyon", UnitPrice = 1300,UnitsStock=5 };
            ProductManager productManager = new ProductManager();
            // Prdouct manager classında bir x(productManager) tanımladık
            // = bu da yeni bir ProductManagerdır.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            
                                //return burası oluyor.
            //int toplamaSonucu = productManager.Topla(3, 6);

        }
    }
}