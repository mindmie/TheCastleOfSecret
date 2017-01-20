using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class JAMGameModel : Model
    {
        private Board board;
        private Actor girl;
        private Random random;
        private Location temp;

        public const int UP = 0;
        public const int DOWN = 1;
        public const int LEFT = 2;
        public const int RIGHT = 3;

        private int[,] openmap = new int[,] {
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
        };

        public int[,] OpenMap
        {
            get { return openmap; }
        }
        internal Board Board
        {
            get { return board; }
            set { board = value; }
        }

        public Random Random
        {
            get { return random; }
            set { random = value; }
        }

        internal Actor Girl
        {
            get { return girl; }
            set { girl = value; }
        }

        public JAMGameModel()
        {
            Board = new Floor1().Board;
            girl = new Actor();
            RandomActor();  
        }

        public void Update()
        {
            NotifyAll();
        }

        public void RandomActor()
        {
            random = new Random();
            do
            {
                temp = new Location(Random.Next(0, Board.GetWidth()), Random.Next(0, Board.GetHeight()));
                girl.Location = temp;
            } while (board[girl.Location.X, girl.Location.Y] != 0);
            openmap[Girl.Location.X, Girl.Location.Y] = 1;
        }

        public string Warming()
        {
            string text = " ";
            switch (Board.At(Girl.Location))
            {
                //Room
                case Board.EMPTY:
                    text = "Empty";
                    break;
                case Board.RHOLE:
                    Girl.Stage--;
                    Girl.Torch = 0;
                    Girl.Cross = 0;
                    text = "Sorry, You fall to level" + Girl.Stage ;
                    text += "\nPress any key to continus" + Girl.Stage;
                    break;
                case Board.RSPIDER:
                    if (Girl.Torch >= 1)
                    {
                        Girl.Torch -= 1;
                        text = "You can protect yourself from the giant spider. You lose one torch.";
                    }
                    else
                    {
                        Girl.MoveAble = false;
                        text = "Dead";
                        Girl.Stage = 1;
                    }   
                    break;   
                case Board.RDEVIL:
                    if (Girl.Cross >= 1)
                    {
                        Girl.Cross -= 1;
                        text = "You can protect yourself from the devil. You lose one cross.";
                    }
                    else
                    {
                        Girl.MoveAble = false;
                        text = "Dead";
                        Girl.Stage = 1;
                    }
                    break;
                case Board.RVAMPIRE:
                    text = "You find Vampire.";
                    break;               
                case Board.RLADDER:
                    Girl.Stage++;
                    text = "Congratulation! you can go to the next level.";
                    break;
                case Board.RMIRROR:
                    text = "You are sent to new room by mirror.";
                    RandomActor();
                    Update();
                    break;
                //Item
                case Board.TORCH:
                    Girl.Torch += 1;
                    board[Girl.Location.X, Girl.Location.Y] = 0;
                    text = "You are so lucky.You get one torch";
                    break;
                case Board.CROSS:
                    Girl.Cross += 1;
                    board[Girl.Location.X, Girl.Location.Y] = 0;
                    text = "You are so lucky.You get one cross";
                    break;
                //Warming(1)
                case Board.WSPIDER:
                    text = "Watch out! the giant spider is near this room";
                    break;
                case Board.WHOLE:
                    text = "Walk careful,the floor is dilapidated.\nIt has the hole near this room.";
                    break;
                case Board.WVAMPIRE:
                    text = "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WBLOOD:
                    text = "Beware! the devil is near this room.";
                    break;
                //Warming(2)
                case Board.WSPIDER + Board.WVAMPIRE:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WSPIDER + Board.WHOLE:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Walk careful,the floor is dilapidated.\nIt has the hole near this room.";
                    break;
                case Board.WSPIDER + Board.WBLOOD:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Beware! the devil is near this room.";
                    break;
                case Board.WHOLE + Board.WBLOOD:
                    text = "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    text += "Beware! the devil is near this room.";
                    break;
                case Board.WHOLE + Board.WVAMPIRE:
                    text += "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WBLOOD + Board.WVAMPIRE:
                    text = "Beware! the devil is near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                //Warming(3)
                case Board.WSPIDER + Board.WVAMPIRE + Board.WHOLE:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WHOLE + Board.WBLOOD + Board.WVAMPIRE:
                    text = "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    text += "Beware! the devil is near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WSPIDER + Board.WVAMPIRE + Board.WBLOOD:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Beware! the devil is near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
                case Board.WSPIDER + Board.WBLOOD + Board.WHOLE:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Beware! the devil is near this room.\n";
                    text += "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    break;
                //Warming(4)
                case Board.WSPIDER + Board.WVAMPIRE + Board.WHOLE + Board.WBLOOD:
                    text = "Watch out! the giant spider is near this room\n";
                    text += "Walk careful,the floor is dilapidated.\nIt has the hole near this room.\n";
                    text += "Beware! the devil is near this room.\n";
                    text += "Fighting! you get closr to Vampire more and more";
                    break;
            }
            return text;
        }

        public void MoveGirl(int direction)
        {
            if (Girl.MoveAble)
            {
                int xx = Girl.Location.X;
                int yy = Girl.Location.Y;
                switch (direction)
                {
                    case UP:
                        Girl.Location.Y = yy - 1;
                        break;
                    case DOWN:
                        Girl.Location.Y = yy + 1;
                        break;
                    case LEFT:
                        Girl.Location.X = xx - 1;
                        break;
                    case RIGHT:
                        Girl.Location.X = xx + 1;
                        break;
                }
                openmap[Girl.Location.X, Girl.Location.Y] = 1;
            }
            NotifyAll();
        }

        public void ChangeStage(int num)
        {
            openmap = new int[,] {
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0 },
                };
            switch (num)
            { 
                case 1:
                    Girl.MoveAble = true;
                    Board = new Floor1().Board;
                    RandomActor();
                    break;
                case 2:
                    Board = new Floor2().Board;
                    RandomActor();
                    break;                  
                case 3:
                    Board = new Floor3().Board;
                    RandomActor();
                    break;                 
                case 4:
                    Board = new Floor4().Board;
                    RandomActor();
                    break;
                case 5:
                    Board = new Floor5().Board;
                    RandomActor();
                    break;             
            }
        }
    }
}
