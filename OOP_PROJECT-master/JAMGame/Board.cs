using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Board
    {
        public const int EMPTY = 0;
        //Room
        public const int RHOLE = 2;
        public const int RSPIDER = 3;
        public const int RDEVIL = 4;
        public const int RMIRROR = 5;
        public const int RVAMPIRE = 6;
        public const int RLADDER = 7;
        //Item
        public const int TORCH = 8 ;
        public const int CROSS = 9;
        //Warming
        public const int WMIRROR = 1;
        public const int WSPIDER = 10;
        public const int WHOLE = 100;
        public const int WBLOOD = 1000;
        public const int WVAMPIRE = 10000;

        private int[,] board;
        Random random = new Random();

        public int this[int x,int y]
        {
            get { return board[x, y]; }
            set { board[x, y] = value; }
        }

        public Board()
        {
            board = new int[,] {
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
            };
        }

        public int[,] GetBoard()
        {
            return board;
        }

        public int GetWidth()
        {
            return 7;
        }

        public int GetHeight()
        {
            return 7;
        }

        public int Value(Location loc)
        {
            return board[loc.X,loc.Y];
        }

        public int At(Location location)
        {
            return board[location.X, location.Y];
        }

        public bool IsRome(Location location)
        {
            if ( (location.X < 0) || (location.X > 6) || (location.Y < 0) || (location.Y > 6))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*
        public bool IsRome(int x,int y)
        {
            if ((x < 0) || (x > 6) || (y < 0) || (y > 6))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        */

        public bool CanWarm(int x, int y,Room r)
        {
            if (x <= -1 || y <= -1 || x >= 7 || y >= 7)
            {
                return false;
            }
            else if (board[x, y] >= 1 && board[x, y] <= 9)
            {
                return false;
            }
            else if (board[x, y] < r.WSR)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void splash(Room SpectialRoom)
        {
            //int[] ran = new[] { 0, 0 };
            int c, d;
            List<Location> R = new List<Location>();
            if (SpectialRoom.XX - 1 >= 0 && CanWarm(SpectialRoom.XX - 1, SpectialRoom.YY,SpectialRoom)) 
            {
                R.Add(new Location(SpectialRoom.XX - 1, SpectialRoom.YY));
            }
            if (SpectialRoom.XX + 1 < GetWidth() && CanWarm(SpectialRoom.XX + 1, SpectialRoom.YY, SpectialRoom))
            {
                R.Add(new Location(SpectialRoom.XX + 1, SpectialRoom.YY));
            }
            if (SpectialRoom.YY - 1 >= 0 && CanWarm(SpectialRoom.XX, SpectialRoom.YY - 1, SpectialRoom))
            {
                R.Add(new Location(SpectialRoom.XX, SpectialRoom.YY - 1));
            }
            if (SpectialRoom.YY + 1 < GetHeight() && CanWarm(SpectialRoom.XX, SpectialRoom.YY + 1, SpectialRoom))
            {
                R.Add(new Location(SpectialRoom.XX, SpectialRoom.YY + 1));
            }
            if (R.Count() >= 2)
            {
                do
                {
                    c = random.Next(0, R.Count());
                    d = random.Next(0, R.Count());
                } while (c == d);
                board[R[c].X, R[c].Y] += SpectialRoom.WSR;
                board[R[d].X, R[d].Y] += SpectialRoom.WSR;
            }
            else if (R.Count() == 1)
            {
                c = random.Next(0, R.Count());
                board[R[c].X, R[c].Y] += SpectialRoom.WSR;
            }
        }
       
    }
}
