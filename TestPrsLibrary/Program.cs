using PRSLibrary.Controllers;
using PRSLibrary.Models;
using System;
using System.Linq;

namespace TestPrsLibrary {

    class Program {

        static void Main(string[] args) {

            var context = new PrsDbContext();


            //// Users

            //// this statement is required for all methods in the UsersController
            //var userCtrl = new UsersController(context);

            //var user = userCtrl.Login("sa", "sa"); // will display Username if Username and Password are both correct
            //var user = userCtrl.Login("sa", "sax"); // will display "User not found" if Username and Password are not both correct
            //if (user is null) {
            //    Console.WriteLine("User not found");
            //} else {
            //    Console.WriteLine(user.Username);
            //}

            //var username = "gdoud";
            //var password = "password";
            //context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

            //var user = from u in context.Users
            //           where u.Username == username && u.Password == password
            //           select u;

            //// displays all users in the database
            //var users = userCtrl.GetAll();
            //foreach (var user in users) {
            //    Console.WriteLine($"{user.Id} {user.Firstname} {user.Lastname}");
            //}

            //// get by primary key method
            //// displays User 3
            //var user3 = userCtrl.GetByPk(3);
            //if (user3 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}");
            //}

            //// get by primary key method
            //// displays User not found!
            //var user33 = userCtrl.GetByPk(33);
            //if (user33 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            //}

            //// creates a new user in the database
            //var newUser = new User() {
            //    Id = 0, Username = "aa", Password = "xx",
            //    Firstname = "User", Lastname = "ZZ",
            //    Phone = "211", Email = "xx@user.com",
            //    IsReviewer = false, IsAdmin = false
            //};
            //userCtrl.Create(newUser);

            //// changes User Id 3 Lastname to User Three
            //var user3 = userCtrl.GetByPk(3);
            //user3.Lastname = "User Three";
            //userCtrl.Change(user3);

            //// removes User 10 from the database or throws exception if User 10 does not exist
            //userCtrl.Remove(10);



            //// Products

            //// this statement is required for all methods in the ProductsController
            //var prodCtrl = new ProductsController(context);

            //// displays all products in the database
            //var products = prodCtrl.GetAll();
            //foreach (var p in products) {
            //    Console.WriteLine($"{p.Id,-5} {p.PartNbr,-12} {p.Name,-12} {p.Price,10:c} {p.Vendor.Name,-15}"); // displays Name from Vendor class
            //}

            //// get by primary key method
            //// displays Product 2
            //var product = prodCtrl.GetByPk(2);
            //if (product is not null) {
            //    Console.WriteLine($"{product.Id,-5} {product.PartNbr,-12} {product.Name,-12} {product.Price,10:c} {product.Vendor.Name,-15}"); // displays Name from Vendor class
            //}



            //// Requests

            //// this statement is required for all methods in the ProductsController
            //var reqCtrl = new RequestsController(context);

            //// displays requests not owned by UserId 3 with Status of REVIEW
            //var reqs = reqCtrl.GetRequestsInReview(3);
            //foreach (var req in reqs) {
            //    Console.WriteLine($"{req.Description} {req.Status} { req.Total} {req.UserId}");
            //}

            //// sets status of Requests Id 5
            //var req = reqCtrl.GetByPk(5);
            //// to REVIEW if > 50 or APPROVED if <= 50
            //reqCtrl.SetReview(req);
            //// to REJECTED
            //reqCtrl.SetRejected(req);
            //// to APPROVED
            //reqCtrl.SetApproved(req);
            //// get by primary key method
            //// displays Request Id 5
            //req = reqCtrl.GetByPk(5);
            //Console.WriteLine($"{req.Description} {req.Status} {req.Total}");



            //// RequestLines

            //// this statement is required for all methods in the RequestLinesController
            //var requestLineCtrl = new RequestLinesController(context);

            //// changes RequestLines Quantity to 1 for Id 6
            //var reqCtrl = new RequestLinesController(context);
            //var reql = reqCtrl.GetByPk(6);
            //reql.Quantity = 1;
            //reqCtrl.Change(reql);

            //// displays all RequestLines in the database
            //var requestLines = requestLineCtrl.GetAll();
            //foreach (var rl in requestLines) {
            //    Console.WriteLine($"{rl.Id} {rl.Request.Description} {rl.Product.Name}");
            //}
        }
    }
}
