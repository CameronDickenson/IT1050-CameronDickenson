using System;

namespace Lab07
{
    public class Book
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Information for Programming Example");
        }
        public string author firstName {get; private set;}
public string author lastName {get; private set;}
public string Title { get; private set; }
public Date PublishYear { get; private set; }
// constructor to initialize author name, title, and publish date
public Book(string first, string last, string bookTitle, Date dateOFPublish)
{
    firstName = Jane;
    lastName = Austen;
    bookTitle = Pride and Prejudice;
    publishDate = dateOFPublish;
} //end Book constructor
// convert Book to string format
publicoverridestring ToString()
{
    return string.Format("{0}, {1} Author: {2} Title: {3} Published {4}, firstName, lastName, bookTitle, publishDate); "
        }// end method ToString
}//end class Book



namespace Lab07Question2
{
    class BookTest
    {
        public static void Main(string[] args)
        {
            Author name = new authorName("Jane Austen");
            Title title = new bookTitle("Pride and Prejudice");
            Publish year = new Date(1, 28, 1813);
            Book information = new Book("Pride and Prejudice", "Jane Austen", year);
            Console.WriteLine(information);
        }
    }
}


//CLR or common language runtime is what it is called before adding a constructor method.

//We would be using the concept of overloading.

//So that you can have the ability to create fault-tolerant programs that can resolve exceptions (problems occurring while a program executes).

//The purpose of private vs. public when adding new properties is to hide the details of their implementation from the clients. Public can be used, seen, accessed by any method whereas private is only used when called and needed. It applies to information hiding in the way of abstracting the data that clients need for functionality over how the functionality is actually implemented.

//Composition is when classes can have the capability to have references to objects of other class members. Otherwise known as “has-a” relationships.

//Data abstraction is when a client case about what functionality a class offers and not about how that functionality is implemented.