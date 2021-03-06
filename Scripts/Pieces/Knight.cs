using System;
using System.Numerics;

public class Knight : Piece {

    public Knight (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        Vector2 movement = (to - from);
        return movement.MaxNorm() == 2 && !movement.IsDiagonal() && !movement.IsStraight();
    }

    public override string ToString () {
        return (Color == Color.Black) ? "\u265E" : "\u2658";
    }
}