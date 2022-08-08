using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConstructors
{
    class Program
    {
        static void Main(string[] args)
        {


            //this creates a new instance of the class - this is called an object and can now be used similar to a variable
            Book book1 = new Book("Harry Potter", "J.K. Rowling", 400);


            // we are able to assign values this way without declaring the property of the object because we have made a constructor for this object's class. 
            Book book2 = new Book("Lord of the Rings", "J.R.R. Tolkien", 650);


            Console.WriteLine(book1.title);



            Console.ReadLine();

        }
    }
}