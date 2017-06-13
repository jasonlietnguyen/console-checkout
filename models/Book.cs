namespace console_library.Models
{
  /**
  SCHEMA
   */
   public class Book
   {
      public string Title;
      public string Author;
      public string BelongsTo;

      public bool Rentable = false;

      // CONSTRUCTOR METHOD
      public Book(string title, string author, string belongs, bool rentable = false)
      {
          Title = title;
          Author = author;
          BelongsTo = belongs;
          Rentable = rentable;

          /*
          THREE PILLARS OF OOP
          Inheritance
          Interface
           */


      }

   }


}