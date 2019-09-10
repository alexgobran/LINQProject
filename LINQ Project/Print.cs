using System;
using System.Collections.Generic;
using System.Text;
using CSharp2SqlLibrary;

namespace ExtensionMethods {
    static class MyExtensionMethods {



        // has to be public , static , and void
        public static void PrintBrief(this Product product) {
            Console.WriteLine($"Product name is {product.Name}");
        }
        //    public static void Print(this List<Product> products) {

        //    foreach (var product in products)
        //        Console.WriteLine(product);
        //}

        //public static void Print(this List<Vendor> Vendors) {

        //    foreach (var vendor in Vendors)
        //    {
        //        Console.WriteLine(vendor);
        //    }



        //}



    }

}



