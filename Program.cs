using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      // WHERE THE APPLICATION RUNS OR STARTS AKA (Entry Point)

      var bpl = new Library("BPL");
      var jakesBooks = new Library("Jakes Books");
      var mobyDick = new Book("Moby Dick", "Herman Melville", "BPL");
      Book wow = new Book("War of the Worlds", "HG Wells", "BPL");
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
          var book = bpl.Checkout();
        }
        if (userChoice == "2")
        {
          var book = jakesBooks.Checkout();
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
          while(i < 50){
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
