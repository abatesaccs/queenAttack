using System;

class QueenAttack 
{
    static void Main()
    {
      Console.WriteLine("Please enter pawn coordinates in this format: x:y with max 8:8 ");
      string pawnCoords = Console.ReadLine();
      int pawnX = int.Parse(pawnCoords.Substring(0, 1)); 
      int pawnY = int.Parse(pawnCoords.Substring(2));

      Console.WriteLine("Please enter queen coordinates in this format: x:y with max 8:8 ");
      string queenCoords = Console.ReadLine();
      int queenX = int.Parse(queenCoords.Substring(0, 1)); 
      int queenY = int.Parse(queenCoords.Substring(2));

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