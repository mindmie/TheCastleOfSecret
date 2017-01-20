using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Floor2 : Floor
    {
        private Random random = new Random();
        private Room rSpider1, rSpider2, rSpider3,rHole1,rHole2,rMirror,rLadder,rTorch;

        public Floor2()
        {
            NumFloor = 2;
            NumDevil = 0;
            NumMirror = 1;
            NumHole = 2;
            NumSpider = 3;
            NumVampire = 0;
            NumCross = 0;
            NumTorch = 1;
            Board = BoardForF2();
        }

        public Board BoardForF2()
        {
            Board F2 = new Board();
            int m = random.Next(0, 7);
            int n = random.Next(0, 7);
            F2[m, n] = Board.RLADDER;
            rLadder = new Room(Board.RLADDER, Board.WVAMPIRE, m, n);
            F2.splash(rLadder);
            do
            {
                m = random.Next(0, 3);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RSPIDER;
            rSpider1 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(4, 7);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RSPIDER;
            rSpider2 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(2, 5);
                n = random.Next(2, 5);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RSPIDER;
            rSpider3 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(0, 3);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RHOLE;
            rHole1 = new Room(Board.RHOLE, Board.WHOLE, m, n);
            do
            {
                m = random.Next(4, 7);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RHOLE;
            rHole2 = new Room(Board.RHOLE, Board.WHOLE, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.RMIRROR;
            rMirror = new Room(Board.RMIRROR, Board.EMPTY, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F2[m, n] != 0);
            F2[m, n] = Board.TORCH;
            rTorch = new Room(Board.TORCH, Board.EMPTY, m, n);
            F2.splash(rSpider1);
            F2.splash(rSpider2);
            F2.splash(rSpider3);
            F2.splash(rHole1);
            F2.splash(rHole2);
            return F2;
        }
    }
}
