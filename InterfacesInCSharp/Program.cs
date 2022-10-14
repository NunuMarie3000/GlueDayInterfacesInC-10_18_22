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

    static void GameBoard(Animal one, Animal two)
    {
      Animal Winner;
      Console.WriteLine("***Battle sounds, an epic battle ensues***\nIt's very epic, believe me!");
      Console.ReadKey();
      Random num = new Random();
      if(num.Next(1,3) == 1)
      {
        Winner = one;
      }
      else
        Winner = two;
      Console.WriteLine($"*****WINNER: {Winner.Name}***");
      Winner.Taunt();
    }
    static void StartGame()
    {
      Animal Fido = CreateFido();
      Animal Neffertiti = CreateNeffertiti();
      Fido.OpposingPowerLevel = Neffertiti.PowerLevel;
      Neffertiti.OpposingPowerLevel = Fido.PowerLevel;
      Console.WriteLine($"***{Fido.Name} created!***\n***{Neffertiti.Name} created!***");
      Console.ReadKey();
      InitialTaunt(Fido, Neffertiti);
      Console.ReadKey();
      Console.WriteLine("3...2...1...FIGHT!");
      GameBoard(Fido, Neffertiti);
    }

    static void InitialTaunt(Animal one, Animal two)
    {
      Console.WriteLine($"{one.Name}: ");
      one.Taunt();
      Console.WriteLine();
      Console.WriteLine($"{two.Name}: ");
      two.Taunt();
    }

    static Animal CreateFido()
    {
      Animal Fido = new Animal("Fido", 3, 54, "Dog", "I'll *bark* you up!", "Bark bark barkdown!", "what?");
      return Fido;
    }
    static Animal CreateNeffertiti()
    {
      Animal Neffertiti = new Animal("Neffertiti", 1000, 93, "Sphynx", "Even the Egyptians couldn't kill my good looks!", "Pharoh's Rat Dance!", "what?");
      return Neffertiti;
    }
  }
}