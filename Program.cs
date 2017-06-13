using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using console_library.Models;
using console_library.Models.Trash;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {

      var room = new Room();
      room.Exits.Add("north", new Room());
      Room x = null;
      room.Exits.TryGetValue("north", out x);
      // WHERE THE APPLICATION RUNS OR STARTS AKA (Entry Point)

      var bpl = new Library("BPL");
      var jakesBooks = new Library("Jake");
      var mobyDick = new Book("Moby Dick", "Herman Melville", "BPL", true);


      var petStore = new List<Animal>();


      var fido = new Dog()
      {
        Name = "Fido"
      };


      fido.Sleep("2");
      Console.WriteLine(fido.Legs);
      petStore.Add(fido);

      var garfield = new Cat()
      {
        IsEvil = false,
        Legs = 2
      };
      garfield.Breath();
      petStore.Add(garfield);

      var joey = new Kangaroo()
      {
        ChampionBoxer = true
      };

      joey.Cute = true;

      petStore.Add(joey);


      foreach (var x in petStore)
      {
        x.Sleep("8");
      }




      Book wow = new Book("War of the Worlds", "HG Wells", "BPL", true);
      bpl.Books.Add(mobyDick);
      bpl.Books.Add(wow);
      jakesBooks.Books.Add(new Book("Head First with C#", "That one dude", "Jake"));

      var playing = true;

      while (playing)
      {
        Console.Clear();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine(@"
          1. Go To BP Library
          2. Look at your own books
          3. Quit
        ");

        var userChoice = Console.ReadLine();


        if (userChoice == "1")
        {
          bpl.Checkout(jakesBooks);
        }
        if (userChoice == "2")
        {
          jakesBooks.Checkout(bpl);
        }
        if (userChoice == "3")
        {
          playing = false;
        }
        if (userChoice == "4")
        {
          Console.WriteLine("Congrats you've activated skynet... Prepare to Die");
          Thread.Sleep(1000);
          Console.Beep();
          Console.WriteLine("3");
          Thread.Sleep(1000);
          Console.Beep();
          Console.WriteLine("2");
          Thread.Sleep(1000);
          Console.Beep();
          Console.WriteLine("1");
          Thread.Sleep(1000);
          Console.Beep();
          Console.WriteLine("Goodbye");
          Console.BackgroundColor = ConsoleColor.Red;
          Console.ForegroundColor = ConsoleColor.White;
          var i = 0;
          while (i < 50)
          {
            Console.WriteLine(@"
                    HAHAHA 
                              HAHAHA 
                  HAHAHA
            ");
            Thread.Sleep(300);
            i++;
          }
          playing = false;
        }
      }







      // Console.WriteLine("Okay here we go");
      // List<int> nums1 = new List<int>(); // LEARN ABOUT THIS LATER BOXING UNBOXING
      // int[] nums2 = new int[100000000];


      // var stopwatch = new Stopwatch();
      // stopwatch.Start();

      // for(var i = 0; i < nums2.Length; i++)
      // {
      //   nums2[i] = i;
      //   // Console.WriteLine(nums2[i]);
      // }
      // stopwatch.Stop();
      // Console.WriteLine($"That only took {stopwatch.ElapsedMilliseconds}");




    }
  }
}