using System;
using System.Collections.Generic;
using System.Numerics;

public static class Geometry {

    public static Vector2 Opposite (this Vector2 vector) {
        return new Vector2(7 - vector.X, 7 - vector.Y);
    }

    public static bool IsDiagonal (this Vector2 vector) {
        return Math.Abs(vector.X) == Math.Abs(vector.Y) && vector != Vector2.Zero;
    }

    public static bool IsStraight (this Vector2 vector) {
        return (vector.X == 0 || vector.Y == 0) && vector != Vector2.Zero;
    }

    public static float MaxNorm (this Vector2 vector) {
        return Math.Max(Math.Abs(vector.X), Math.Abs(vector.Y));
    }
}