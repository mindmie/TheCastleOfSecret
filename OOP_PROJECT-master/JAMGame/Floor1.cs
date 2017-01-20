using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class Floor1 : Floor
    {
        private Random random = new Random();
        private Room rSpider1, rSpider2, rSpider3, rSpider4,rMirror,rLadder,rTorch;

        public Floor1()
        {
            NumFloor = 1;
            NumDevil = 0;
            NumMirror = 1;
            NumHole = 0;
            NumSpider = 4;
            NumVampire = 0;
            NumCross = 0;
            NumTorch = 1;
            Board = BoardForF1();
        }

        public Board BoardForF1()
        {
            Board F1 = new Board();
            int m = random.Next(0, 7);
            int n = random.Next(0, 7);
            F1[m, n] = Board.RLADDER;
            rLadder = new Room(Board.RLADDER, Board.WVAMPIRE, m, n);
            F1.splash(rLadder);
            do
            {
                m = random.Next(0, 3);
                n = random.Next(0, 3);
            } while (F1[m, n] != 0);
            F1[m,n] = Board.RSPIDER;
            rSpider1 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(0, 3);
                n = random.Next(3, 7);
            } while (F1[m, n] != 0);
            F1[m, n] = Board.RSPIDER;
            rSpider2 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(3, 7);
                n = random.Next(0, 3);
            } while (F1[m, n] != 0);
            F1[m, n] = Board.RSPIDER;
            rSpider3 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(3, 7);
                n = random.Next(3, 7);
            } while (F1[m, n] != 0);
            F1[m, n] = Board.RSPIDER;
            rSpider4 = new Room(Board.RSPIDER, Board.WSPIDER, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F1[m, n] != 0);
            F1[m, n] = Board.RMIRROR;
            rMirror = new Room(Board.RMIRROR, Board.EMPTY, m, n);
            do
            {
                m = random.Next(0, 7);
                n = random.Next(0, 7);
            } while (F1[m, n] != 0);
            F1[m, n] = Board.TORCH;
            rTorch = new Room(Board.TORCH, Board.EMPTY, m, n);
            F1.splash(rSpider1);
            F1.splash(rSpider2);
            F1.splash(rSpider3);
            F1.splash(rSpider4);
            return F1;
        }
    }
}
