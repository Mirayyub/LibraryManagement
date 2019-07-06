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
            #region Seed for Teacher
            //    Costumer cost1 = new Costumer
            //    {
            //        FirstName = "Fuad",
            //        LastName = "Ismayilov",
            //        PhoneNo = "+994505005050",
            //        Email = "fuadigmail.com"
            //    };

            //    context.Costumers.Add(cost1);
            //    context.SaveChanges();

            //    Costumer cost2 = new Costumer
            //    {
            //        FirstName = "Afshan",
            //        LastName = "Aliyeva",
            //        PhoneNo = "+994702220091",
            //        Email = "aff@box.az"
            //    };

            //    context.Costumers.Add(cost2);
            //    context.SaveChanges();

            //    Costumer cost3 = new Costumer
            //    {
            //        FirstName = "Nərgiz",
            //        LastName = "Əliyeva",
            //        PhoneNo = "+994702330033",
            //        Email = "nar@gmail.az"
            //    };

            //    context.Costumers.Add(cost3);
            //    context.SaveChanges();



            //    User user1 = new User
            //    {
            //        FirstName = "Admin",
            //        LastName = "administrator",
            //        UserName = "admin",
            //        Email = "admin@library.az",
            //        Password = "admin"
            //    };

            //    context.Users.Add(user1);
            //    context.SaveChanges();

            //    User user2 = new User
            //    {
            //        FirstName = "Fuad",
            //        LastName = "Mehmanov",
            //        UserName = "user",
            //        Email = "user@mail.ru",
            //        Password = "fuad"
            //    };

            //    context.Users.Add(user2);
            //    context.SaveChanges();



            //    Book book1 = new Book
            //    {
            //        Name = "Yenisey",
            //        Count = 21,
            //        Price = 11
            //    };

            //    context.Books.Add(book1);
            //    context.SaveChanges();

            //    Book book2 = new Book
            //    {
            //        Name = "Uçurtma",
            //        Count = 32,
            //        Price = 12
            //    };

            //    context.Books.Add(book2);
            //    context.SaveChanges();

            //    Book book3 = new Book
            //    {
            //        Name = "Fizika",
            //        Count = 4,
            //        Price = 3
            //    };

            //    context.Books.Add(book3);
            //    context.SaveChanges();

            //    Book book4 = new Book
            //    {
            //        Name = "Qisas Gecəsi",
            //        Count = 11,
            //        Price = 22
            //    };

            //    context.Books.Add(book4);
            //    context.SaveChanges();

            //    Book book5 = new Book
            //    {
            //        Name = "Hər Şey Snlə Başlar",
            //        Count = 3,
            //        Price = 1
            //    };

            //    context.Books.Add(book5);
            //    context.SaveChanges();


            //    Order order1 = new Order
            //    {
            //        Costumer = cost1,
            //        CreatedDate = DateTime.Now,


            //    };

            //    context.Orders.Add(order1);
            //    context.SaveChanges();


            //    OrderItem orit1 = new OrderItem
            //    {
            //        Book = book1,
            //        Count = 22,
            //        PayPrice = 22,
            //        ReturnDate = DateTime.Now,
            //        Order = order1
            //    };
            //    context.OrderItems.Add(orit1);
            //    context.SaveChanges();
            //
            #endregion
        }
    }
}
