using System;
using System.Collections.Generic;
using System.Numerics;

public enum Color {
    Black,
    White
}
// Black is at the bottom, White is at the top

public class Board {
    public Dictionary<Vector2, Type> InitialLayout = new Dictionary<Vector2, Type>() {
        {new Vector2(0,1), typeof(Pawn)},
        {new Vector2(1,1), typeof(Pawn)},
        {new Vector2(2,1), typeof(Pawn)},
        {new Vector2(3,1), typeof(Pawn)},
    };

    public Piece[,] Data = new Piece[8, 8];

    public Board () {
        // Data[2, 2].Print();
        foreach (var initPiece in InitialLayout) {
            // Data[(int) initPiece.Key.X, (int) initPiece.Key.Y] = initPiece.Value.();
        }

    }

    void MakePiece () { }
}