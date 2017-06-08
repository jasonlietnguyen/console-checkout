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

    public void ShowBooks()
    {
      Console.WriteLine("Welcome to {0} ", Name);
      foreach (var book in Books)
      {
        Console.WriteLine(book.Title + " - " + book.Author);
      }
    }
  }

}