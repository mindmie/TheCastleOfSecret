using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Floor3 : Floor
    {
        private Random random = new Random();
        private Room rSpider1, rSpider2, rHole1, rHole2, rDevil1,rDevil2, rMirror, rLadder, rTorch,rCross;
        public Floor3()
        {
            NumFloor = 3;
            NumDevil = 2;
            NumMirror = 1;
            NumHole = 2;
            NumSpider = 2;
            NumVampire = 0;
            NumCross = 1;
            NumTorch = 1;
            Board = BoardForF3();
        }

        public Board BoardForF3()
        {
            Board F3 = new Board();
            int m = random.Next(0, 7);
            int n = random.Next(0, 7);
            F3[m, n] = Board.RLADDER;
            rLadder = new Room(Board.RLADDER, Board.WVAMPIRE, m, n);
            F3.splash(rLadder);
            do
            {
                m = random.Next(0, 5);
                n = random.Next(0, 5);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RSPIDER;
            rSpider1 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(4, 7);
                n = random.Next(4, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RSPIDER;
            rSpider2 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(4, 7);
                n = random.Next(0, 5);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RHOLE;
            rHole1 = new Room(Board.RHOLE, Board.WHOLE, m, n);
            do
            {
                m = random.Next(0, 5);
                n = random.Next(4, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RHOLE;
            rHole2 = new Room(Board.RHOLE, Board.WHOLE, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RDEVIL;
            rDevil1 = new Room(Board.RDEVIL, Board.WBLOOD, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RDEVIL;
            rDevil2 = new Room(Board.RDEVIL, Board.WBLOOD, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.RMIRROR;
            rMirror = new Room(Board.RMIRROR, Board.EMPTY, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.TORCH;
            rTorch = new Room(Board.TORCH, Board.EMPTY, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F3[m, n] != 0);
            F3[m, n] = Board.CROSS;
            rCross = new Room(Board.CROSS, Board.EMPTY, m, n);
            F3.splash(rSpider1);
            F3.splash(rSpider2);
            F3.splash(rHole1);
            F3.splash(rHole2);
            F3.splash(rDevil1);
            F3.splash(rDevil2);
            return F3;
        }
    }
}
