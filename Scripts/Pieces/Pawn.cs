using System;
using System.Numerics;

public class Pawn : Piece {

    public Pawn (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        return false;
    }

}