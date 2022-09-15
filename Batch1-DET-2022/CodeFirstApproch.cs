using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BATCH1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    public class CodeFirstApproch
    {

        public static void Main()
        {
            //AddNewBook();
            //RemoveNewBook();
            //UpdateBook();
            //RemoveBook();
            //GetBooks();
            //Addnewcustomerandorder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            Console.ReadLine();
        }





        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 1;
        //    book.BookName = "EF Core";
        //    book.author = "Jack";
        //    book.price = 100;


        //book.BookID = 2;
        //book.BookName = "Multimedia";
        //book.author = "Anthony";
        //book.price = 300;

        //book.BookID = 3;
        //book.BookName = "Magnetic flux";
        //book.author = "Jhone";
        //book.price = 400;

        //book.BookID = 4;
        //book.BookName = "Grandmas bag of stories";
        //book.author = "suda murty";
        //book.price = 250;

        //book.BookID = 5;
        //book.BookName = "The inteligent investor";
        //book.author = "Benjamin ";
        //book.price = 450;

        //try
        //{
        //    ctx.Books.Add(book);
        //    ctx.SaveChanges();
        //    Console.WriteLine("New Book Added Successfully");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.InnerException.Message);
        //}

        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();

        //    books.author = "shekspre";
        //    ctx.Update(books);
        //    ctx.SaveChanges();
        //    Console.WriteLine("updated");


        //}

        //private static void RemoveBook()
        //{
        //    var ctx = new BookContext();
        //    var books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();

        //    books.author = "shekspre";
        //    ctx.Remove(books);
        //    ctx.SaveChanges();
        //    Console.WriteLine("remove");


        //}
        //private static void GetBooks()
        //{
        //    try
        //    {
        //        var ctx = new BookContext();
        //        var books = ctx.Books;
        //        foreach (var book in books)
        //        {
        //            Console.WriteLine(book.BookID + " " + book.BookName + " " + book. author + " " + book.price);
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //private static void Addnewcustomerandorder()
        //{
        //    var ctx = new BookContext();

        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "sam";
        //    customer.Age = 25;

        //    Order ord = new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;

        //    //List<Order> myorder = new List<Order>();
        //    //myorders.Add(ord);
        //    //customer.Orders = myorders;

        //    ord.cust = customer;
        //    try
        //    {
        //        // ctx.Customers.Add(customer);//orders
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and order is created");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.ToString());
        //    }

            //private static void GetAllCustomersWithOrder_EagerLoading()
            //{
            //    //Eager loading means that the related data is loaded 
            //    //from the database as part of the initial query.
            //    var ctx = new BookContext();
            //    try
            //    {
            //        var customers = ctx.Customers.Include("Orders");

            //        //var customers = ctx.Customers.Include(o => o.Orders);                   

            //        foreach (var customer in customers)
            //        {
            //            Console.WriteLine(customer.Name);
            //            Console.WriteLine("----->");


            //            foreach (var order in customer.Orders)
            //            {
            //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
            //            }
            //            Console.WriteLine("-----");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //private static void GetAllCustomersWithOrder_ExplicitLoading()
            //{
            //    //Explicit loading means that the related data is
            //    //explicitly loaded from the database at a later time.
            //    //Needs MARS to be set to TRUE in connection string
            //    var ctx = new BookContext();
            //    try
            //    {
            //        var customers = ctx.Customers;

            //        foreach (var customer in customers)
            //        {
            //            Console.WriteLine(customer.Name);
            //            Console.WriteLine("----->");

            //            ctx.Entry(customer).Collection(o => o.Orders).Load();

            //            foreach (var order in customer.Orders)
            //            {
            //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

            //            }
            //            Console.WriteLine("-----");

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            private static void Disconnectedarchitecture()
            {
                var ctx = new BookContext();

                var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

                ctx.Dispose();

                UpdateCustomerName(customer);

            }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }
        }
        


    

    


