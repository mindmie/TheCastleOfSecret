using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Location
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)  { x = 0; }
                else if (value > 6) { x = 6; }
                else { x = value; }
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0) { y = 0; }
                else if (value > 6) { y = 6; }
                else { y = value; }
            }
        }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Location location1, Location location2)
        {
            return (location1.X == location2.X && location1.Y == location2.Y);
        }

        public static bool operator !=(Location location1, Location location2)
        {
            return (location1.X != location2.X || location1.Y != location2.Y);
        }
    }
}
