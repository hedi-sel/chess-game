using System;
using System.Numerics;

public class King : Piece {
    public King (Color color) : base(color) { }

    public override bool CanMove (Vector2 from, Vector2 to) {
        if ((to - from).MaxNorm() == 1)
            return true;

        //Castling
        if (!HasMoved && to.Y == from.Y && (to.X == 1 || to.X == 6) && CheckEmptyLine(from, to)) {
            Vector2 rookPos = new Vector2((to.X == 1) ? 0 : 7, to.Y);
            Piece rook = Board.Instance.PieceAt(rookPos);
            if (rook != null && rook is Rook && !rook.HasMoved) {
                return Board.Instance.TryMovePiece(rookPos, 2 * to - rookPos);
            }
        }

        return false;
    }

    public override string ToString () {
        return (Color == Color.Black) ? "\u265A" : "\u2654";
    }
}