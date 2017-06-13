using System;
using System.Collections.Generic;

namespace console_library.Models
{

  public class Library
  {
    public List<Book> Books = new List<Book>();
    public string Name;

    public Library(string name)
    {
      Name = name;
    }

    public Book SelectBook(int i)
    {
      if (i > -1)
      {
        var book = Books[i];
        Books.Remove(book);
        return book;
      }
      return null;
    }

    public int ValidateUserChoice(string choice)
    {
      var i = -1;
      int.TryParse(choice, out i);
      i -= 1;

      if (i > -1 && i < Books.Count)
      {
        return i;
      }
      return -1;
    }

    public void Checkout(Library otherLib)
    {
      var browsing = true;
      Book selectedBook = null;
      while (browsing)
      {
        ShowBooks();
        string userChoice = GetUserChoice();
        if (userChoice == "leave")
        {
          browsing = false;
          return;
        }
        var i = ValidateUserChoice(userChoice);
        selectedBook = SelectBook(i);
        if (selectedBook != null)
        {
          browsing = false;
        }
      }
      if (selectedBook.Rentable)
      {
        otherLib.Books.Add(selectedBook);
      }
      else
      {
        Books.Add(selectedBook);
      }
    }

    public string GetUserChoice()
    {
      Console.WriteLine("Please Select a book by its number or type 'LEAVE'");
      var userChoice = Console.ReadLine().ToLower();
      return userChoice;
    }

    public void ShowBooks()
    {
      Console.WriteLine("Welcome to {0} ", Name);
      Console.WriteLine("Here is a list of our available books");
      for (var i = 0; i < Books.Count; i++)
      {
        var book = Books[i];
        Console.WriteLine($"{i + 1}: {book.Title} by {book.Author}");
      }
    }
  }

}