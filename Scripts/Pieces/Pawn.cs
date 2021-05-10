using System;
using System.Numerics;

public class Pawn : Piece {

    public Pawn (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        if ((to - from).Y != ((this.Color == Color.Black) ? 1 : -1))
            return false;

        if ((to - from).X == 0)
            return Board.Instance.PieceAt(to) == null;

        if (Math.Abs((to - from).X) == 1) {
            Piece piece = Board.Instance.PieceAt(to);
            return piece != null; // No need to check if the piece is of opposite color
        }

        //TODO: Move 2 squares on the first movement

        return false;
    }

    public override string ToString () {
        return "P";
    }
}