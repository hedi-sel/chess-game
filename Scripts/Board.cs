using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public enum Color {
    Black,
    White
}
// Black is at the bottom, White is at the top

public class Board {
    public static Board Instance { get; private set; } // Keeping an instance instead of using a static class allows to manage several

    public Board (Dictionary<Vector2, Type> blackLayout, Dictionary<Vector2, Type> whiteLayout) {
        foreach (var initPiece in blackLayout) {
            MakePiece(initPiece.Key, initPiece.Value, Color.Black);
        }
        foreach (var initPiece in whiteLayout) {
            MakePiece(initPiece.Key.Opposite(), initPiece.Value, Color.White);
        }
        Instance = this;
    }

    public Piece PieceAt (Vector2 position) {
        if (position.X < 0 || position.X >= Data.GetLength(0) || position.Y < 0 || position.Y >= Data.GetLength(1))
            throw new IndexOutOfRangeException($"Position {position} is outside the range of the board");

        return Data[(int) position.X, (int) position.Y];
    }

    public bool TryMovePiece (Vector2 from, Vector2 to) {
        Piece movePiece = PieceAt(from);
        if (movePiece == null)
            throw new KeyNotFoundException($"Piece not found at position {from}");

        if (PieceAt(to) != null && PieceAt(to).Color == movePiece.Color) {
            Console.WriteLine("You cannot take one of your own pieces!");
            return false;
        }

        if (!movePiece.CanMove(from, to)) {
            Console.WriteLine("This movement is illegal!");
            return false;
        }

        Data[(int) to.X, (int) to.Y] = movePiece;
        Data[(int) from.X, (int) from.Y] = null;

        return true;
        //TODO: memeorize the pieces that have been taken
    }

    public void Print () {
        Console.WriteLine("# # # # # # # # # #");
        for (int j = 7 ; j >= 0 ; j--) {
            Console.Write("# ");
            for (int i = 0 ; i < 8 ; i++) {
                Piece piece = Data[i, j];
                if (piece == null)
                    Console.Write("  ");
                else
                    Console.Write(piece.ToString() + " ");
            }
            Console.WriteLine("#");
        }
        Console.WriteLine("# # # # # # # # # #");
    }

    Piece[,] Data = new Piece[8, 8];

    void MakePiece (Vector2 position, Type type, Color color) {
        Data[(int) position.X, (int) position.Y] = (Piece) Activator.CreateInstance(type, color);
    }

}