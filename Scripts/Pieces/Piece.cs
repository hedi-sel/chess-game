using System;
using System.Numerics;

public abstract class Piece {

    Color Color;

    public Piece (Color color) {
        // Position = position;
        Color = color;
    }

    public abstract bool CanMove (Vector2 from, Vector2 to);

}