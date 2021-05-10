using System;
using System.Numerics;

public class Queen : Piece {

    public Queen (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        Vector2 movement = (to - from);
        if (!movement.IsDiagonal() && !movement.IsStraight())
            return false;

        return CheckEmptyLine(from, to);
    }

    public override string ToString () {
        return "Q";
    }
}