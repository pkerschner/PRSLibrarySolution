using PRSLibrary.Controllers;
using PRSLibrary.Models;
using System;
using System.Linq;

namespace TestPrsLibrary {

    class Program {

        static void Main(string[] args) {

            var context = new PrsDbContext();



            // RequestLines

            //var reqCtrl = new RequestLinesController(context);

            //var reql = reqCtrl.GetByPk(6);
            //reql.Quantity = 1;
            //reqCtrl.Change(reql);



            // Requests

            //var reqCtrl = new RequestsController(context);

            //var reqs = reqCtrl.GetRequestsInReview(3);

            //foreach(var req in reqs) {
            //    Console.WriteLine($"{req.Description} {req.Status} { req.Total} {req.UserId}");
            //}

            //var req = reqCtrl.GetByPk(5);

            ////reqCtrl.SetReview(req);
            //reqCtrl.SetRejected(req);
            ////reqCtrl.SetApproved(req);

            //req = reqCtrl.GetByPk(5);

            //Console.WriteLine($"{req.Description} {req.Status} {req.Total}");


            // Users

            //var userCtrl = new UsersController(context);

            //var user = userCtrl.Login("sa", "sa");

            ////var user = userCtrl.Login("sa", "sax"); // will display "User not found"

            //if (user is null) {
            //    Console.WriteLine("User not found");
            //} else {
            //    Console.WriteLine(user.Username);
            //}



            //var username = "gdoud";
            //var password = "password";
            //context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

            //var user = from u in context.Users
            //        where u.Username == username && u.Password == password
            //        select u;



            // RequestLines

            //var requestLineCtrl = new RequestLinesController(context);

            //var requestLines = requestLineCtrl.GetAll();
            //foreach (var rl in requestLines) {
            //    Console.WriteLine($"{rl.Id} {rl.Request.Description} {rl.Product.Name}");
            //}



            // Products

            //var prodCtrl = new ProductsController(context);

            //var products = prodCtrl.GetAll();

            //foreach(var p in products) {
            //    Console.WriteLine($"{p.Id,-5} {p.PartNbr,-12} {p.Name,-12} {p.Price,10:c} {p.Vendor.Name,-15}"); // displays Name from Vendor class
            //}               



            //var product = prodCtrl.GetByPk(2);

            //if(product is not null) {
            //    Console.WriteLine($"{product.Id,-5} {product.PartNbr,-12} {product.Name,-12} {product.Price,10:c} {product.Vendor.Name,-15}"); // displays Name from Vendor class
            //}


            // Users

            //var userCtrl = new UsersController(context);

            //var newUser = new User() {
            //    Id = 0, Username = "zz", Password = "xx", 
            //    Firstname = "User", Lastname = "ZZ", 
            //    Phone = "211", Email = "xx@user.com",
            //    IsReviewer = false, IsAdmin = false
            //};


            //// creates a new user in the database
            ////userCtrl.Create(newUser);
            ///

            //var user3 = userCtrl.GetByPk(3);

            //if(user3 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}");
            //}



            //user3.Lastname = "User3";
            //userCtrl.Change(user3);

            //var user33 = userCtrl.GetByPk(33);

            //if (user33 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            //}


            //// removes a user from the database
            ////userCtrl.Remove(6);


            //var users = userCtrl.GetAll();

            //foreach(var user in users) {
            //    Console.WriteLine($"{user.Id} {user.Firstname} {user.Lastname}");
            //}
        }
    }
}
