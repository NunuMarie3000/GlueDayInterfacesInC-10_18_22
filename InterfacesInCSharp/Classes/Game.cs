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
      // if numberOfTurns == 10, then its a draw...or ==9...

      //TODO: Complete this method and utilize the rest of the class structure to play the game.

      /*
       * Complete this method by constructing the logic for the actual playing of Tic Tac Toe. 
       * 
       * A few things to get you started:
      1. A turn consists of a player picking a position on the board with their designated marker. 

      // so for each turn...
      // check who's turn it is
      // player.isTurn == true? then they need to take their turn
      // so...player.getPosition(Board); // how would i make edits/add player.marker to the board? with the player.TakeTurn(Board) method,
      //so...
        // player.isTurn == true ?
          // player.TakeTurn(Board);
          // Position desiredCoordinate = player.GetPosition(Board);
          // Position position = player.PositionForNumber(desiredCoordinate); 
          // Board.DisplayBoard();
          // isThereAWinner = CheckForWinner(Board);

        // then switch player
        // game.SwitchPlayer();
        // game.NextPlayer() // returns player who's turn it is, so i can do 
          // player.TakeTurn(Board);

      2. Display the board after every turn to show the most up to date state of the game board.DisplayBoard():
      3. Once a Winner is determined, display the board one final time and return a winner
      Few additional hints:
          Be sure to keep track of the number of turns that have been taken to determine if a draw is required
          and make sure that the game continues while there are unmarked spots on the board. 
      Use any and all pre-existing methods in this program to help construct the method logic. 
       */

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
        if (PlayerOne.OpposingPowerLevel == 0) 
        {
          isWinner = true;
          Winner = PlayerOne;
        }
        else if(PlayerTwo.OpposingPowerLevel == 0)
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
    public Player NextPlayer()
    {
      return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
    }

    /// <summary>
    /// End one players turn and activate the other
    /// </summary>
    public void SwitchPlayer()
    {
      if (PlayerOne.IsTurn)
      {

        PlayerOne.IsTurn = false;


        PlayerTwo.IsTurn = true;
      }
      else
      {
        PlayerOne.IsTurn = true;
        PlayerTwo.IsTurn = false;
      }
    }


  }
}