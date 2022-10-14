using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InterfacesInCSharp.Classes;
using InterfacesInCSharp.Interfaces;

namespace InterfacesInCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Learning Interfaces, take 2!");
      StartGame();
      
    }

    // static void GameBoard(Animal one, Animal two)
    // {
    //   Animal Winner;
    //   Console.WriteLine("***Battle sounds, an epic battle ensues***\nIt's very epic, believe me!");
    //   Console.ReadKey();
    //   Random num = new Random();
    //   if(num.Next(1,3) == 1)
    //   {
    //     Winner = one;
    //   }
    //   else
    //     Winner = two;
    //   Console.WriteLine($"*****WINNER: {Winner.Name}***");
    //   Winner.Taunt();
    // }

    static void StartGame()
    {
      // Animal Fido = CreateFido();
      // Animal Neffertiti = CreateNeffertiti();
      Animal playerOne = CreatePlayer();
      Animal playerTwo = CreatePlayer();

      // Fido.OpposingPowerLevel = Neffertiti.PowerLevel;
      // Neffertiti.OpposingPowerLevel = Fido.PowerLevel;
      playerOne.OpposingPowerLevel = playerTwo.PowerLevel;
      playerTwo.OpposingPowerLevel = playerOne.PowerLevel;
      
      // Console.WriteLine($"***{Fido.Name} created!***\n***{Neffertiti.Name} created!***");
      Console.WriteLine($"***{playerOne.Name} created!***\n***{playerTwo.Name} created!***");
      Console.ReadKey();

      // InitialTaunt(Fido, Neffertiti);
      InitialTaunt(playerOne, playerTwo);
      Console.ReadKey();

      Console.WriteLine("3...2...1...FIGHT!");

      // var Game = new Game(Fido, Neffertiti);
      var Game = new Game(playerOne, playerTwo);
      Animal winner = Game.Play();
    }

    static void EndGame(Animal winner)
    {
      Console.WriteLine($"{winner.Name} is the Winner!");
      Console.WriteLine("Thanks for playing!");
    }

    static void InitialTaunt(Animal one, Animal two)
    {
      Console.WriteLine($"{one.Name}: ");
      one.Taunt();
      Console.WriteLine();
      Console.WriteLine($"{two.Name}: ");
      two.Taunt();
    }

    static Animal CreatePlayer()
    {
      Console.WriteLine("What's your character's name?");
      string name = Console.ReadLine();
      Console.WriteLine("Age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Power Level: ");
      int powerlevel = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("What type of animal are they?");
      string animaltype = Console.ReadLine();
      Console.WriteLine($"What's {name}'s catchphrase?");
      string catchphrase = Console.ReadLine();
      Console.WriteLine("What's their signature move?");
      string signaturemove = Console.ReadLine();
      string alternate = "what";
      Animal newAnimal = new Animal(name, age, powerlevel, animaltype, catchphrase, signaturemove, alternate);
      return newAnimal;
    }

    // static Animal CreateFido()
    // {
    //   Animal Fido = new Animal("Fido", 3, 54, "Dog", "I'll *bark* you up!", "Bark bark barkdown!", "what?");
    //   return Fido;
    // }
    // static Animal CreateNeffertiti()
    // {
    //   Animal Neffertiti = new Animal("Neffertiti", 1000, 93, "Sphynx", "Even the Egyptians couldn't kill my good looks!", "Pharoh's Rat Dance!", "what?");
    //   return Neffertiti;
    // }
  }
}