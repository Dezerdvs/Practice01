using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    public class Wind
    {
        public WindDirection Direction { get; set; }
        public double Power { get; set; }

        public Wind() : this(new WindDirection(), 0) { }

        public Wind(WindDirection direction, double power)
        {
            Direction = direction;
            Power = power;
        }

        public static string GetDirectionString(WindDirection direction)
        {
            switch (direction)
            {
                case WindDirection.North: return "Північ";
                case WindDirection.South: return "Південь";
                case WindDirection.West: return "Захід";
                case WindDirection.East: return "Схід";
                default: return "";
            }
        }

        public override string ToString()
        {
            return $"Напрямок: {GetDirectionString(Direction)}. Швидкість: {Math.Round(Power, 2)} м/c.";
        }
    }

    public enum WindDirection
    {
        North,
        South,
        West,
        East
    }
}