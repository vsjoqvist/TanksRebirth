﻿using Microsoft.Xna.Framework;
using System;
using TanksRebirth.Internals.Common.Utilities;

namespace TanksRebirth.GameContent.Systems.Coordinates
{
    public struct CubeMapPosition
    {
        public const int MAP_WIDTH = 22;
        public const int MAP_HEIGHT = 17;

        public static implicit operator CubeMapPosition(Vector3 position) => ConvertFromVector3(position);
        public static implicit operator Vector2(CubeMapPosition position) => Convert2D(position);
        public static implicit operator Vector3(CubeMapPosition position) => Convert3D(position);

        public int X;
        public int Y;

        public CubeMapPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
        public CubeMapPosition(int xy)
        {
            X = xy;
            Y = xy;
        }

        public static Vector2 Convert2D(CubeMapPosition pos)
        {
            // (0, 0) == (MIN_X, MIN_Y)

            var orig = new Vector2(MapRenderer.CUBE_MIN_X, MapRenderer.CUBE_MIN_Y);

            var real = new Vector2(orig.X + (pos.X * Block.FULL_BLOCK_SIZE), orig.Y + (pos.Y * Block.FULL_BLOCK_SIZE) - 110);

            return real;
        }

        public static Vector3 Convert3D(CubeMapPosition pos)
        {
            // (0, 0) == (MIN_X, MIN_Y)

            var orig = new Vector3(MapRenderer.CUBE_MIN_X, 0, MapRenderer.CUBE_MIN_Y);

            var real = new Vector3(orig.X + (pos.X * Block.FULL_BLOCK_SIZE) + 1f, 0, orig.Y + (pos.Y * Block.FULL_BLOCK_SIZE) - 43);

            return real;
        }

        /// <summary>
        /// Literally doesn't work in the slightest. Do NOT USE
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static CubeMapPosition ConvertFromVector3(Vector3 position)
        {
            // convert position into a CubeMapPosition, and grid lock it
            var invarX = (int)MathF.Round(position.X % Block.FULL_BLOCK_SIZE, 1);
            var invarY = (int)MathF.Round(position.Z % Block.FULL_BLOCK_SIZE, 1);
            var invar = new CubeMapPosition(invarX, invarY);

            return invar;

        }
        public static CubeMapPosition ConvertFromVector2(Vector2 position)
        {
            // convert position into a CubeMapPosition, and grid lock it
            var invarX = (int)MathF.Round(position.X % Block.FULL_BLOCK_SIZE, 1);
            var invarY = (int)MathF.Round(position.Y % Block.FULL_BLOCK_SIZE, 1);
            var invar = new CubeMapPosition(invarX, invarY);

            return invar;

        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder()
                .Append("{ ")
                .Append($"X: {X} | Y: {Y}")
                .Append(" }");

            return sb.ToString();
        }
    }
}
