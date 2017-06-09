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

      // CONSTRUCTOR METHOD
      public Book(string title, string author, string belongs)
      {
          Title = title;
          Author = author;
          BelongsTo = belongs;
      }

   }


}