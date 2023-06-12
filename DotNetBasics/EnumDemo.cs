using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class EnumDemo
    {
        enum Direction
        {
            North,
            East,
            West,
            South
        };
        public void EnumMethod()
        {
            Direction myDirection = Direction.South;
            Console.WriteLine("My Initial Direction  : " + myDirection);

            Direction currentDirection = Direction.North;
            Console.WriteLine("MY Current Direction : " + currentDirection);
        }
    }
}
