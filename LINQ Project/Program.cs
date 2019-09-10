using System;
using System.Linq;

namespace LINQ_Project {

    class User {

        public string Name { get; set;}
        public bool isAdmin { get; set;}

    }
    class Program {
        static void Main(string[] args) {

            var users = new User[]
            {//Collection of users
                new User(){Name="Adam", isAdmin = false},
                new User(){Name ="Barb", isAdmin = true},
                new User(){Name ="Chris", isAdmin = false},
                new User(){Name ="Donna", isAdmin = true},
                new User(){Name ="Ed", isAdmin = false},
                new User(){Name ="Faith", isAdmin = true},
            };
            //Method syntax
            var admins = users.Where(u => u.isAdmin).OrderByDescending(u=> u.Name);

            //Query Syntax
            //var admins = from USR in users
            //             where USR.isAdmin == true
            //                orderby USR.Name descending;
            //             select USR;

            //user in the parameters is a Fred variable
            foreach(var user in admins)
            {
                Console.WriteLine($"Name is {user.Name} is  an admin");
            }

           // //array - collection of integars)
           // int[] ints = { 2, 4, 6, 8, 7, 5, 3, 1 };

           // //below Defined query against our variable but does not execute it! you have to reference it somewhere else in your code
           // //operation below is getting numbers from ints collection with only odd numbers under 7 in descending order
           // // get average (.Average(i=>i) using Lambda syntax

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
