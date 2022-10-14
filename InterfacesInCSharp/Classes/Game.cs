namespace InterfacesInCSharp.Classes
{
  public class Game
  {
    public Animal PlayerOne { get; set; }
    public Animal PlayerTwo { get; set; }
    public Animal Winner { get; set; }

    /// <summary>
    /// Require 2 players and a board to start a game. 
    /// </summary>
    /// <param name="p1">Player 1</param>
    /// <param name="p2">Player 2</param>
    public Game(Animal p1, Animal p2)
    {
      PlayerOne = p1;
      PlayerTwo = p2;
    }

    /// <summary>
    /// Activate the Play of the game
    /// </summary>
    /// <returns>Winner</returns>
    public Animal Play()
    {
      bool isThereAWinner = false;
      Animal whoseTurn = PlayerOne;

      while (!isThereAWinner)
      {
        // this is essentially the loop i gotta do to play the game
        whoseTurn.TakeTurn();
        SwitchPlayer();
        isThereAWinner = CheckForWinner();
        whoseTurn = NextPlayer();
      }
      // display player stats at the end
      Console.WriteLine($"\n{PlayerOne.Name}: {PlayerTwo.OpposingPowerLevel}\n{PlayerTwo}: {PlayerOne.OpposingPowerLevel}");
      //this is gonna return a winner, instance of player
      return Winner;
    }


    /// <summary>
    /// Check if winner exists
    /// </summary>
    /// <returns>if winner exists</returns>
    public bool CheckForWinner()
    {
      bool isWinner;
      // if either player gets 0, game is over
      if (PlayerOne.OpposingPowerLevel <= 0)
      {
        isWinner = true;
        Winner = PlayerOne;
      }
      else if (PlayerTwo.OpposingPowerLevel <= 0)
      {
        isWinner = true;
        Winner = PlayerTwo;
      }
      else isWinner = false;

      return isWinner;
    }


    /// <summary>
    /// Determine next player
    /// </summary>
    /// <returns>next player</returns>
    public Animal NextPlayer()
    {
      return (PlayerOne.isTurn) ? PlayerOne : PlayerTwo;
    }

    /// <summary>
    /// End one players turn and activate the other
    /// </summary>
    public void SwitchPlayer()
    {
      if (PlayerOne.isTurn)
      {

        PlayerOne.isTurn = false;


        PlayerTwo.isTurn = true;
      }
      else
      {
        PlayerOne.isTurn = true;
        PlayerTwo.isTurn = false;
      }
    }
  }
}