using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConstructors
{

    //this is a class that has been assigned properties - these properties can have values assigned to them.
    internal class Book
    {
        public string title;
        public string author;
        public int pages;


        //whenever we mention something like public followed by the name of the class this is what is known as a constructor... so now we dont have to assignn values to the properties of the object manually every single time. The program will now know to accept the values and apply them to the object without having to specify which property the value is for.
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
