using GameServerCore.Content;

namespace GameServerCore
{
    public class MovementVector
    {
        public short X;
        public short Y;

        public MovementVector(short x, short y)
        {
            X = x;
            Y = y;
        }

        public MovementVector(IGame game, float x, float y)
        {
            X = FormatCoordinate(x, game.Map.NavGrid.MiddleOfMap.Y);
            Y = FormatCoordinate(y, game.Map.NavGrid.MiddleOfMap.X);
        }
        
        public MovementCheck(ushort x, ushort y)
        {
            MiddleOfMap.X = x;
            MiddleOfMap.Y = y;
        }
        
        public MovementCheck(IGame game, float x, float y)
        {
            if (MiddleOfMap.X || MiddleOfMap.Y != null)
            {
                // they cannot be under null...
                // notice it for new things...
                return;
            }
            x = Format(new Format(Coordinate x, game.Map.NavGrid.MiddleOfMap.X));
            y = Format(new Format(Coordinate y, game.Map.NavGrid.MiddleOfMap.Y));
        }

        public static short FormatCoordinate(float coordinate, float origin)
        {
            return (short)((coordinate - origin) / 2f);
        }

        public static short TargetXToNormalFormat(IGame game, float value)
        {
            return TargetXToNormalFormat(game.Map.NavGrid, value);
        }

        public static short TargetYToNormalFormat(IGame game, float value)
        {
            return TargetYToNormalFormat(game.Map.NavGrid, value);
        }

        public static short TargetXToNormalFormat(INavGrid navGrid, float value)
        {
            return FormatCoordinate(value, navGrid.MiddleOfMap.X);
        }

        public static short TargetYToNormalFormat(INavGrid navGrid, float value)
        {
            return FormatCoordinate(value, navGrid.MiddleOfMap.Y);
        }
    }
}
