using System;
using System.Numerics;

public class Rook : Piece {

    public Rook (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        return (to - from).IsStraight() && CheckEmptyLine(from, to);
    }

    public override string ToString () {
        return (Color == Color.Black) ? "\u265C" : "\u2656";
    }
}