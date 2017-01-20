using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Actor
    {
        private Location location;
        //private Random random;
        private int torch = 0;
        private int cross = 0;
        private bool moveable = true;
        private int stage = 1;

        public Actor()
        {
            //random = new Random();
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Torch
        {
            get { return torch; }
            set { torch = value; }
        }

        public int Cross
        {
            get { return cross; }
            set { cross = value; }
        }

        public bool MoveAble
        {
            get { return moveable; }
            set { moveable = value; }
        }

        public int Stage
        {
            get { return stage; }
            set { stage = value; }
        }

    }
}
