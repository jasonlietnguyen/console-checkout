using System;
using System.Collections.Generic;

namespace console_library.Models.Trash
{


  public class Animal
  {

    public bool Cute;

    public void Eat(string food)
    {
      Console.WriteLine($"Now Eating {food}");
    }

    public void Breath()
    {
      Console.WriteLine($"Now breathing");
    }

    public void Sleep(string hours)
    {
      Console.WriteLine($"has slept {hours}");
    }

  }


  public class Quadraped : Animal
  {
    public int Legs = 4;
  }

  public class Biped : Animal
  {
    public int Legs = 2;
  }

  public class Kangaroo : Biped
  {
    public bool ChampionBoxer = false;
  }

  public class Dog : Quadraped
  {
    public string Name;
  }

  public class Cat : Quadraped
  {
    public bool IsEvil = true;
  }

  public class Bird : Biped
  {
    public void Fly()
    {
      Console.WriteLine("I am flying");
    }
  }

  public class Folder
  {

    public Folder Parent;
    public List<string> Files = new List<string>();
    public List<Folder> Folders = new List<Folder>();


  }


  public class House
  {
    public House Country;
    public House State;
    public House City;
    public int Bed { get; set;}
    public int Bath;
    public int Price;
    public List<Room> Rooms = new List<Room>();
  }

  public class Room
  {
    public Dictionary<string, Room> Exits = new Dictionary<string, Room>();
  }

  public class Kitchen : Room
  {

  }


}