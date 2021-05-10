using System;
using System.Numerics;

public class King : Piece {

    public King (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        return (to - from).MaxDistance() == 1;

        //TODO: Make a castling
    }

    public override string ToString () {
        return "K";
    }
}