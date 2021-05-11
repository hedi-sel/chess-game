using System;
using System.Numerics;

public abstract class Piece {
    public Color Color;
    public bool HasMoved = false; //Set this to true, the first time the piece moves

    public Piece (Color color) {
        // Position = position;
        Color = color;
    }

    public abstract bool CanMove (Vector2 from, Vector2 to);

    public abstract new string ToString ();

    public static bool CheckEmptyLine (Vector2 from, Vector2 to) {
        Vector2 increment = (to - from) / (to - from).MaxNorm();
        for (Vector2 position = from + increment ; position != to ; position += increment) {
            if (Board.Instance.PieceAt(position) != null)
                return false;
        }

        return true;
    }
}