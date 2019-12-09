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
    }

    static void checkHorizontal()
    {

    }

    static void checkVertical() 
    {

    }


}