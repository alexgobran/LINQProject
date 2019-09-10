using System;
using System.Linq;
using CSharp2SqlLibrary;
using ExtensionMethods;

namespace LINQ_Project {

  
    class Program {
        void Run() {
            //Create connection use @ to allow \ to be used , open connection
            var Connection = new Connection(@"localhost\sqlexpress","PRS");
            Connection.Open();
            User.Connection = Connection;
            Vendor.Connection = Connection;
            Product.Connection = Connection;



           



            //var states = new State[]
            //{
            //    new State
            //}
           

            var users = from u in User.GetAll()
                        where u.Username.Contains("2")
                        select u;


            var admins = from u in User.GetAll()
                         //use .Equals when referring to string instead of ==
                         where u.Username.Equals("ABC")
                         select u;

            var reviewers = from r in User.GetAll()
                            where r.IsReviewer
                            select r;

            var vendors = from v in Vendor.GetAll()
                          orderby v.Name descending
                            select v;
            

            #region Print Method/Product Join with Vendor 
            //print class contains print method which is an extension method
            Product.Connection = Connection;
        var products = Product.GetAll();
            foreach (var product in products)
            {
                product.PrintBrief();

            }

            //Vendor.Connection = Connection;
            //var Vendors = Vendor.GetAll();
            //Vendors.Print();
            //#endregion


            //Product.Connection = Connection;
            //var products = from p in Product.GetAll()
            //               join v in Vendor.GetAll()
            //               on p.VendorId equals v.Id
            //               select new
            //               {
            //                   Product = p.Name,
            //                   Price = p.Price,
            //                   Vendor = v.Name,

            //               };
            //foreach (var p in products)
            //{
            //    Console.WriteLine($"{p.Product} priced at {p.Price} is from {p.Vendor}");
            //}
        }


        #endregion

        #region Total all products prices
        //Products.Connection = Connection;
        //  var totalAllProducts = (jfrom p in Product.GetAll())
        #endregion

        //var admins = from u in User.GetAll()4
        //                 where u.IsAdmin
        //                select u;

        //    foreach (var user in admins)
        //        {
        //            Console.WriteLine($"{user.Firstname}{user.Lastname} is an Admin");
        //        }
        //        Connection.Close();

        //    foreach( var v in vendors)
        //    {
        //        Console.WriteLine(v);
        //    }
        //}






        static void Main(string[] args) {

            var pgm = new Program();
            pgm.Run();

            //var users = new User[]
            //{//Collection of users
            //    new User(){Name="Adam", isAdmin = false},
            //    new User(){Name ="Barb", isAdmin = true},
            //    new User(){Name ="Chris", isAdmin = false},
            //    new User(){Name ="Donna", isAdmin = true},
            //    new User(){Name ="Ed", isAdmin = false},
            //    new User(){Name ="Faith", isAdmin = true},
            //};
            ////Method syntax
            //var admins = users.Where(u => u.isAdmin).OrderByDescending(u=> u.Name);

            ////Query Syntax
            ////var admins = from USR in users
            ////             where USR.isAdmin == true
            ////                orderby USR.Name descending;
            ////             select USR;

            ////user in the parameters is a Fred variable
            //foreach(var user in admins)
            //{
            //    Console.WriteLine($"Name is {user.Name} is  an admin");
            //}

           // //array - collection of integars)
           // int[] ints = { 2, 4, 6, 8, 7, 5, 3, 1 };

           // //below Defined query against our variable but does not execute it! you have to reference it somewhere else in your code
           // //operation below is getting numbers from ints collection with only odd numbers under 7 in descending order
           // get average (.Average(i=>i) using Lambda syntax

           // //Query syntax

           // var asInts = (from i in ints
           //               where i % 2 == 1 && i < 7
           //               orderby i descending
           //               select i);

           // //Method syntax
           // var avg = asInts.Average(i => i);

           // Console.WriteLine($"Average of odds less than 7 is {avg}");

        

           ////referencing the defined query above
           // foreach (var i in asInts)
           // {
           //     Console.Write($" {i}" );
           // }
        }
    }
}
