using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      // WHERE THE APPLICATION RUNS OR STARTS AKA (Entry Point)

      var x = new Library("BPL");
      var jakesBooks = new Library("Jakes Books");
      var mobyDick = new Book("Moby Dick", "Herman Melville");
      Book wow = new Book("War of the Worlds", "HG Wells");


      x.Books.Add(mobyDick);
      x.Books.Add(wow);
      x.ShowBooks();
      jakesBooks.Books.Add(new Book("Head First with C#", "That one dude"));
      jakesBooks.ShowBooks();




      Console.ReadLine();



    }
  }
}
