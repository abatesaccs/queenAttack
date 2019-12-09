using System;

class QueenAttack 
{
    static void Main()
    {
      Console.WriteLine("Please choose an x coordiante for your pawn between 1 and 8: ");
      int pawnX = int.Parse(Console.ReadLine());
      Console.WriteLine("Please Choose a y coordinate for your pawn between 1 and 8: ");
      int pawnY = int.Parse(Console.ReadLine());

      Console.WriteLine("Please choose an x coordiante for the queen between 1 and 8: ");
      int queenX = int.Parse(Console.ReadLine());
      Console.WriteLine("Please Choose a y coordinate for the queen between 1 and 8: ");
      int queenY = int.Parse(Console.ReadLine());

      Console.WriteLine(checkWinner(pawnX, pawnY, queenX, queenY));
    }

    static bool checkHorizontalAndVertical(int pawnX, int pawnY, int queenX, int queenY)
    {
      if (pawnX == queenX || pawnY == queenY)
      {
        return true;
      }
      else
      {
        return false;
      }
    } 

    static bool checkDiagonal(int pawnX, int pawnY, int queenX, int queenY) 
    {
      if (Math.Abs(queenX - pawnX) == Math.Abs(queenY - pawnY))   
      {
        return true;
      } 
      else 
      {
        return false;
      }
    }

    static string checkWinner(int pawnX, int pawnY, int queenX, int queenY)
    {
      if (checkHorizontalAndVertical(pawnX, pawnY, queenX, queenY) || checkDiagonal(pawnX, pawnY, queenX, queenY)) 
      {
        return "Looks like you are the loser!";
      }
      else
      {
        return "You are the best chess player ever!!!";
      }
    }

}