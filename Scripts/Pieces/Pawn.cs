using System;
using System.Numerics;

public class Pawn : Piece {

    public Pawn (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {

        switch ((to - from).Y * ((this.Color == Color.Black) ? 1 : -1)) {
            case 1:
                break;
            case 2:
                if (HasMoved)
                    return false;
                break;
            default:
                return false;
        }

        if ((to - from).X == 0)
            return Board.Instance.PieceAt(to) == null;

        if (Math.Abs((to - from).X) == 1) {
            Piece piece = Board.Instance.PieceAt(to);
            return piece != null; // No need to check if the piece is of opposite color
        }

        return false;
    }

    public override string ToString () {
        return (Color == Color.Black) ? "\u265F" : "\u2659";
    }
}