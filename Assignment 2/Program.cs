using System;
using System.Runtime.InteropServices.ObjectiveC;

namespace MyFirstApp
{
    class Book
    {
        public string?Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            #region
           // Create a Book object
           //Book book1 = new Book();

           // // Store Book object in an object variable
           // object obj = book1;
           // Console.WriteLine(obj);

            #endregion
            //Q2
            #region

            //Console.WriteLine(obj.ToString());
            //Console.WriteLine(obj.GetType());
            //Console.WriteLine(obj.Equals(book1));
            //Console.WriteLine(obj.GetHashCode());
            #endregion
            //Q3                
            #region

            //int pages = "464";                    
            //Compile Time Error 
            //int page = 454;
            #endregion
            //Q4
            #region

            //try
            //{
            //    int x = 10;
            //    int y = 0;

            //    int result = x / y;

            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            //Q5
            #region
            //int pages = 300;

            //double totalPages = pages;

            //Console.WriteLine(totalPages);
            #endregion
            //Q6
            #region
            //double price = 49.99;

            //int newPrice = (int)price;

            //Console.WriteLine(newPrice);
            #endregion
            //Q7
            #region
            //string pagesText = "464";

            //int pages = Convert.ToInt32(pagesText);

            //Console.WriteLine(pages);
            #endregion
            //Q8        
            #region
            //string yearText = "2023";

            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //// TryParse example
            //string badText = "abc";

            //if (int.TryParse(badText, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            //Q9        
            #region
            //int pages = 464;

            //string pagesText = pages.ToString();

            //Console.WriteLine(pagesText);
            //Console.WriteLine(pagesText.GetType());
            #endregion
            //Q10
            #region
            //int copies = 100;

            //// Boxing
            //object obj = copies;

            //// Unboxing
            //int newCopies = (int)obj;

            //Console.WriteLine(obj);
            //Console.WriteLine(newCopies);
            #endregion
        }
    }
}
