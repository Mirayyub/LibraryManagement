namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LibraryManagement.Model;
    using LibraryManagement.DAL;
    using LibraryManagement.Forms;


    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManagement.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryManagement.DAL.LibraryContext context)
        {
            #region Seed 
            Costumer cost1 = new Costumer
            {
                FirstName = "Fuad",
                LastName = "Ismayilov",
                PhoneNo = "+994505005050",
                Email = "fuadigmail.com"
            };

            context.Costumers.Add(cost1);
            context.SaveChanges();

            Costumer cost2 = new Costumer
            {
                FirstName = "Afshan",
                LastName = "Aliyeva",
                PhoneNo = "+994702220091",
                Email = "aff@box.az"
            };

            context.Costumers.Add(cost2);
            context.SaveChanges();

            Costumer cost3 = new Costumer
            {
                FirstName = "Nərgiz",
                LastName = "Əliyeva",
                PhoneNo = "+994702330033",
                Email = "nar@gmail.az"
            };

            context.Costumers.Add(cost3);
            context.SaveChanges();



            User user1 = new User
            {
                FirstName = "Admin",
                LastName = "administrator",
                UserName = "admin",
                Email = "admin@library.az",
                Password = "admin"
            };

            context.Users.Add(user1);
            context.SaveChanges();

            User user2 = new User
            {
                FirstName = "Fuad",
                LastName = "Mehmanov",
                UserName = "user",
                Email = "user@mail.ru",
                Password = "fuad"
            };

            context.Users.Add(user2);
            context.SaveChanges();



            Book book1 = new Book
            {
                Name = "Yenisey",
                Count = 21,
                Price = 11
            };

            context.Books.Add(book1);
            context.SaveChanges();

            Book book2 = new Book
            {
                Name = "Uçurtma",
                Count = 32,
                Price = 12
            };

            context.Books.Add(book2);
            context.SaveChanges();

            Book book3 = new Book
            {
                Name = "Fizika",
                Count = 4,
                Price = 3
            };

            context.Books.Add(book3);
            context.SaveChanges();

            Book book4 = new Book
            {
                Name = "Qisas Gecəsi",
                Count = 11,
                Price = 22
            };

            context.Books.Add(book4);
            context.SaveChanges();

            Book book5 = new Book
            {
                Name = "Hər Şey Snlə Başlar",
                Count = 3,
                Price = 1
            };

            context.Books.Add(book5);
            context.SaveChanges();


            Order order1 = new Order
            {
                Costumer = cost1,
                CreatedDate = DateTime.Now,


            };

            context.Orders.Add(order1);
            context.SaveChanges();


            OrderItem orit1 = new OrderItem
            {
                Book = book1,
                Count = 2,
                PayPrice = 22,
                ReturnDate = DateTime.Now,
                Order = order1
            };
            context.OrderItems.Add(orit1);
            context.SaveChanges();

            Order order2 = new Order
            {
                Costumer = cost2,
                CreatedDate = DateTime.Now,


            };

            context.Orders.Add(order2);
            context.SaveChanges();


            OrderItem orit2 = new OrderItem
            {
                Book = book2,
                Count = 3,
                PayPrice = 11,
                ReturnDate = DateTime.Now,
                Order = order2
            };
            context.OrderItems.Add(orit2);
            context.SaveChanges();

            Order order3 = new Order
            {
                Costumer = cost3,
                CreatedDate = DateTime.Now,


            };

            context.Orders.Add(order3);
            context.SaveChanges();


            OrderItem orit3 = new OrderItem
            {
                Book = book3,
                Count = 3,
                PayPrice = 32,
                ReturnDate = DateTime.Now,
                Order = order3
            };
            context.OrderItems.Add(orit3);
            context.SaveChanges();
            #endregion
        }
    }
}
