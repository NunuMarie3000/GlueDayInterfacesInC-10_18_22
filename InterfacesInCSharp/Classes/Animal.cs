using InterfacesInCSharp.Interfaces;

namespace InterfacesInCSharp.Classes
{
  public class Animal : IAttack
  {
    public int OpposingPowerLevel { get; set; }
    public bool isTurn { get; set; }

    public string TauntPhrase { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int PowerLevel { get; set; }
    public string AnimalType { get; set; }
    public Animal(string name, int age, int powerlevel, string animaltype, string taunt, string sigmove, string alt)
    {
      Name = name;
      Age = age;
      PowerLevel = powerlevel;
      AnimalType = animaltype;
      TauntPhrase = taunt;
      SignatureMove = sigmove;
      Alternate = alt;
    }

    public string SignatureMove { get; set; }
    public string Alternate { get; set; }

    public int LightAttack()
    {
      int Damage = 12;
      Console.WriteLine($"{Name} attacked you with a Light Attack. You lost {Damage} points ");
      OpposingPowerLevel -= Damage;
      return Damage;
    }
    public void Taunt()
    {
      Console.WriteLine(TauntPhrase);
    }
    public int StrongAttack()
    {
      int Damage = 21;
      Console.WriteLine($"{Name} attacked you with a Strong Attack. You lost {Damage} points ");
      OpposingPowerLevel -= Damage;
      return Damage;
    }
    public int Jump()
    {
      int Damage = 32;
      Console.WriteLine($"{Name} attacked you with a Jump Attack. You lost {Damage} points ");
      OpposingPowerLevel -= Damage;
      return Damage;
    }
    public int Parry()
    {
      int Damage = 9;
      Console.WriteLine($"{Name} attacked you with a Parry Attack. You lost {Damage} points ");
      OpposingPowerLevel -= Damage;
      return Damage;
    }
    public string GetDesiredMove()
    {
      string desiredMove = null;

      while (desiredMove == null)
      {
        Console.WriteLine("Please select a move\nLight Attack: 12 damage\nStrong Attack: 21 damage\nJumpAttack: 32 damage\nParry: 9 damage");
        // this is where the bug is i need to check if the tryparse fails or not. if it fails, then that means the spot is already occupied
        // i have no clue why this loop is repeating when the user types in an answer the first time
        Console.ReadLine();
      }
      return desiredMove;
    }
    public void TakeTurn()
    {
      {
        isTurn = true;

        Console.WriteLine($"{Name} it is your turn\n");

        string desiredMove = GetDesiredMove();

        if (desiredMove != "light attack" || desiredMove != "strong attack" ||desiredMove != "jump attack" ||desiredMove != "parry")
        {
          Console.WriteLine("Not a valid move! Try again");
          TakeTurn();
        }
        else
        {
          switch (desiredMove)
          {
            case "light attack":
              LightAttack();
              break;
            case "strong attack":
              StrongAttack();
              break;
            case "jump attack":
              Jump();
              break;
            case "parry":
              Parry();
              break;
            default:
              break;
          }
        }
      }
    }
  }
}