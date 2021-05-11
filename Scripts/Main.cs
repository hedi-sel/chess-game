using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

public class Program {

    static Dictionary<Vector2, Type> BlackLayout = new Dictionary<Vector2, Type>() {
        {new Vector2(0,0), typeof(Rook)},
        {new Vector2(1,0), typeof(Knight)},
        {new Vector2(2,0), typeof(Bishop)},
        {new Vector2(3,0), typeof(King)},
        {new Vector2(4,0), typeof(Queen)},
        {new Vector2(5,0), typeof(Bishop)},
        {new Vector2(6,0), typeof(Knight)},
        {new Vector2(7,0), typeof(Rook)},
        {new Vector2(0,1), typeof(Pawn)},
        {new Vector2(1,1), typeof(Pawn)},
        {new Vector2(2,1), typeof(Pawn)},
        {new Vector2(3,1), typeof(Pawn)},
        {new Vector2(4,1), typeof(Pawn)},
        {new Vector2(5,1), typeof(Pawn)},
        {new Vector2(6,1), typeof(Pawn)},
        {new Vector2(7,1), typeof(Pawn)},
    };

    public static void Main () {
        ConsoleHelper.SetCurrentFont("Consolas", 14);

        Dictionary<Vector2, Type> WhiteLayout = BlackLayout.Keys.ToDictionary(_ => _, _ => BlackLayout[_]);
        WhiteLayout[new Vector2(3, 0)] = typeof(Queen);
        WhiteLayout[new Vector2(4, 0)] = typeof(King);

        Board Board = new Board(BlackLayout, WhiteLayout);
        Board.Print();

        Console.Clear();
        Board.TryMovePiece(new Vector2(2, 0), new Vector2(5, 3)); // Illegal move
        Board.Print();
        Console.Read();

        Console.Clear();
        Board.TryMovePiece(new Vector2(3, 1), new Vector2(3, 3)); //Move Pawn
        Board.Print();
        Console.Read();

        Console.Clear();
        Board.TryMovePiece(new Vector2(2, 0), new Vector2(5, 3)); //Move Bishop
        Board.Print();
        Console.Read();
    }
}