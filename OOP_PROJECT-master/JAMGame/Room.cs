using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Room
    {
        private int SpectialR;
        private int WSpectialR;
        Location locationR ;

        public int SR
        {
            get { return SpectialR; }
            set { SpectialR = value; }
        }

        public int WSR
        {
            get { return WSpectialR; }
            set { WSpectialR = value; }
        }

        public Location Location
        {
            get { return locationR; }
            set { locationR = value; }
        }
        
        public int XX
        {
            get { return locationR.X; }
            set 
            {
                if (value < 0) { locationR.X = 0; }
                else if (value > 6) { locationR.X = 6; }
                else { locationR.X = value; }
            }
        }

        public int YY
        {
            get { return locationR.Y; }
            set 
            {
                if (value < 0) { locationR.Y = 0; }
                else if (value > 6) { locationR.Y = 6; }
                else { locationR.Y = value; }
            }
        }

        public Room(int sr)
        {
            SpectialR = sr;
        }

        public Room(int x,int y)
        {
            locationR = new Location(x, y);
        }

        public Room(int sr,int x, int y)
        {
            SpectialR = sr;
            locationR = new Location(x, y);
        }

        public Room(int sr, int wsr, int x, int y)
        {
            SpectialR = sr;
            WSpectialR = wsr;
            locationR = new Location(x ,y);
        }
    }
}
