using System;
using System.Numerics;

public class Bishop : Piece {

    public Bishop (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        return (to - from).IsDiagonal() && CheckEmptyLine(from, to);
    }

    public override string ToString () {
        return (Color == Color.Black) ? "\u265D" : "\u2657";
    }
}