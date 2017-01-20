using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Floor
    {
        private int numFloor;
        private int numDevil;
        private int numMirror;
        private int numHole;
        private int numSpider;
        private int numVampire;
        private int numCross;
        private int numTorch;
        private Board board;

        public int NumFloor
        {
            get { return numFloor; }
            set { numFloor = value; }
        }

        public int NumHole
        {
            get { return numHole; }
            set { numHole = value; }
        }

        public int NumMirror
        {
            get { return numMirror; }
            set { numMirror = value; }
        }

        public int NumDevil
        {
            get { return numDevil; }
            set { numDevil = value; }
        }

        public int NumSpider
        {
            get { return numSpider; }
            set { numSpider = value; }
        }

        public int NumVampire
        {
            get { return numVampire; }
            set { numVampire = value; }
        }
        public int NumCross
        {
            get { return numCross; }
            set { numCross = value; }
        }
        public int NumTorch
        {
            get { return numTorch; }
            set { numTorch = value; }
        }

        public Board Board
        {
            get { return board; }
            set { board = value; }
        }
    }
}
