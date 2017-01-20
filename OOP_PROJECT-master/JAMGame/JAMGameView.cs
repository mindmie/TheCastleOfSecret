using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JAMGame
{
    public partial class JAMGameView : Form, View
    {
        private JAMGameController gameController;
        private JAMGameModel gameModel;
        PictureBox[,] pb;
        private bool cheat = false;
        //Board temp;
        //Actor
        Image girl = Image.FromFile("../../GirlF.png");
        //Room
        Image block = Image.FromFile("../../block.png");
        Image empty = Image.FromFile("../../emptyG.jpg");
        Image rock = Image.FromFile("../../HOLE.png");
        Image blood = Image.FromFile("../../BLOOD.jpg");
        Image bat = Image.FromFile("../../BAT.jpg");
        Image spider = Image.FromFile("../../SPIDER.png");
        Image vampire = Image.FromFile("../../VAMPIRE.png");
        Image ladder = Image.FromFile("../../LADDER.jpg");
        Image mirror = Image.FromFile("../../MIRROR.png");
        //Item
        Image torch = Image.FromFile("../../TORCH.png");
        Image cross = Image.FromFile("../../CROSS.png");
        //Warming
        //Warming(1)
        Image wspider = Image.FromFile("../../wSpider1.jpg");
        Image wbat = Image.FromFile("../../wBat1.jpg");
        Image whole = Image.FromFile("../../wRock1.jpg");
        Image wdevil = Image.FromFile("../../wDevil1.jpg");
        //Warming(2)
        Image wspiderandbat = Image.FromFile("../../spiderANDbat1.jpg");
        Image wspiderandrock = Image.FromFile("../../spiderANDrock1.jpg");
        Image wspideranddevil = Image.FromFile("../../wspiderANDdevil1.jpg");
        Image wdevilandhole = Image.FromFile("../../wdevilANDrock1.jpg");
        Image wbatandrock = Image.FromFile("../../wbatANDrock1.jpg");
        Image wbatanddevil = Image.FromFile("../../wbatANDdevil1.jpg");
        //Warming(3)
        Image wspiderandbatandrock = Image.FromFile("../../spiderANDbatANDrock1.jpg");
        Image wholeanddevilandbat = Image.FromFile("../../wholeANDdevilANDbat1.jpg");
        Image wspiderandbatandblood = Image.FromFile("../../wspiderANDbatANDblood1.jpg");
        Image wspiderandbloodandrock = Image.FromFile("../../wspiderANDbloodANDrock1.jpg");
        //Warming(4)
        Image warmingall = Image.FromFile("../../wall1.jpg");
        //Screen
        Image Loading = Image.FromFile("../../loading.gif");
        Image StartGame = Image.FromFile("../../first.png");
        Image SSpider = Image.FromFile("../../spiderEnd.jpg");
        Image SDevil = Image.FromFile("../../ghostEnd.jpg");
        Image play = Image.FromFile("../../Play.png");
        Image howto = Image.FromFile("../../how.png");
        //Howto
        Image arrow = Image.FromFile("../../arrow.png");
        Image how1 = Image.FromFile("../../Howtoplaycastle.png");
        Image how2 = Image.FromFile("../../Item.png");
        //Story
        Image story1 = Image.FromFile("../../story1.png");
        Image story2 = Image.FromFile("../../story2.png");
        Image story3 = Image.FromFile("../../story3.png");
        Image story4 = Image.FromFile("../../story4.png");
        Image story5 = Image.FromFile("../../story5.png");
        Image story6 = Image.FromFile("../../story6.png");
        Image story7 = Image.FromFile("../../story7.png");
        //Sound
        public SoundPlayer click = new SoundPlayer("../../click.wav");
        public SoundPlayer bg = new SoundPlayer("../../background.wav");
        public SoundPlayer ss = new SoundPlayer("../../storysound.wav");

        public JAMGameView()
        {

            InitializeComponent();

            pb = new PictureBox[7, 7];
            for (int i = 0; i != 7; i++)
            {
                for (int j = 0; j != 7; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Width = 120;
                    pb[i, j].Height = 120;
                    pb[i, j].Location = new Point(50 + (120 * i), 80 + (120 * j));
                    pb[i, j].Visible = true;
                    //pb[i, j].Visible = false;
                    this.Controls.Add(pb[i, j]);
                }
            }

            gameModel = new JAMGameModel();
            gameModel.AttachObserver(this);

            gameController = new JAMGameController();
            gameController.AddModel(gameModel);

            ScreenShot.Enabled = true;
            ScreenShot.Height = 990;
            ScreenShot.Width = 1500;
            ScreenShot.Enabled = true;
            ScreenShot.Location = new Point(0, 0);
            ScreenShot.Visible = true;



            ScreenShot.Height = 990;
            ScreenShot.Width = 1500;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ss.PlayLooping();
            await Task.Delay(5000);
            ScreenShot.Image = Loading;
            await Task.Delay(3500);
            ScreenShot.Image = story1;
            await Task.Delay(3500);
            ScreenShot.Image = story2;
            await Task.Delay(3500);
            ScreenShot.Image = story3;
            await Task.Delay(3500);
            ScreenShot.Image = story4;
            await Task.Delay(3500);
            ScreenShot.Image = story5;
            await Task.Delay(3500);
            ScreenShot.Image = story6;
            await Task.Delay(3500);
            ScreenShot.Image = story7;
            await Task.Delay(3500);
            ScreenShot.Image = Loading;
            await Task.Delay(3500);
            bg.PlayLooping();
            ScreenShot.Image = StartGame;
            Playgame.Visible = true;
            Playgame.Height = 150;
            Playgame.Width = 500;
            Playgame.Image = play;
            Playgame.Location = new Point(475, 700);
            Warming.Enabled = true;
            Warming.Visible = true;
            this.Height = 990;
            this.Width = 1500;
            numTorch.Visible = false;
            numCross.Visible = false;
            Level.Visible = false;
            gameController.ActionPerformed(99);
            

        }

        public void Notify(Model m)
        {
            printBoard();
            pb[gameModel.Girl.Location.X, gameModel.Girl.Location.Y].Image = girl;
            Warming.Text = gameModel.Warming();
            int xx = gameModel.Board.At(gameModel.Girl.Location);
            Level.Text = "" + gameModel.Girl.Stage;
            numCross.Text = "" + gameModel.Girl.Cross;
            numTorch.Text = "" + gameModel.Girl.Torch;
        }

        private void printBoard()
        {
            int[,] openMap = gameModel.OpenMap;

            for (int i = 0; i != 7; i++)
            {
                for (int j = 0; j != 7; j++)
                {
                    if (openMap[i, j] == 0 && cheat == false)
                    {
                        pb[i, j].Image = block;
                    }
                    //Room
                    else if (gameModel.Board[i, j] == Board.EMPTY)
                    {
                        pb[i, j].BackgroundImage = empty;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RHOLE)
                    {
                        pb[i, j].BackgroundImage = rock;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RSPIDER)
                    {
                        pb[i, j].BackgroundImage = spider;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RDEVIL)
                    {
                        pb[i, j].BackgroundImage = blood;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RVAMPIRE)
                    {
                        pb[i, j].BackgroundImage = bat;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RLADDER)
                    {
                        pb[i, j].BackgroundImage = ladder;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.RMIRROR)
                    {
                        pb[i, j].BackgroundImage = mirror;
                        pb[i, j].Image = null;
                    }
                    //Item
                    else if (gameModel.Board[i, j] == Board.TORCH)
                    {
                        pb[i, j].BackgroundImage = torch;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.CROSS)
                    {
                        pb[i, j].BackgroundImage = cross;
                        pb[i, j].Image = null;
                    }
                    //Warming(1)
                    else if (gameModel.Board[i, j] == Board.WSPIDER)
                    {
                        pb[i, j].BackgroundImage = wspider;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WHOLE)
                    {
                        pb[i, j].BackgroundImage = whole;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WVAMPIRE)
                    {
                        pb[i, j].BackgroundImage = wbat;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WBLOOD)
                    {
                        pb[i, j].BackgroundImage = wdevil;
                        pb[i, j].Image = null;
                    }
                    //Warming(2)
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WVAMPIRE)
                    {
                        pb[i, j].BackgroundImage = wspiderandbat;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WHOLE)
                    {
                        pb[i, j].BackgroundImage = wspiderandrock;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WBLOOD)
                    {
                        pb[i, j].BackgroundImage = wspideranddevil;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WHOLE + Board.WBLOOD)
                    {
                        pb[i, j].BackgroundImage = wdevilandhole;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WHOLE + Board.WVAMPIRE)
                    {
                        pb[i, j].BackgroundImage = wbatandrock;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WBLOOD + Board.WVAMPIRE)
                    {
                        pb[i, j].BackgroundImage = wbatanddevil;
                        pb[i, j].Image = null;
                    }
                    //Warming(3)
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WVAMPIRE + Board.WHOLE)
                    {
                        pb[i, j].BackgroundImage = wspiderandbatandrock;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WVAMPIRE + Board.WBLOOD)
                    {
                        pb[i, j].BackgroundImage = wspiderandbatandblood;
                        pb[i, j].Image = null;
                    }
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WBLOOD + Board.WHOLE)
                    {
                        pb[i, j].BackgroundImage = wspiderandbloodandrock;
                        pb[i, j].Image = null;
                    }
                    //Warming(4)
                    else if (gameModel.Board[i, j] == Board.WSPIDER + Board.WVAMPIRE + Board.WHOLE + Board.WBLOOD)
                    {
                        pb[i, j].BackgroundImage = warmingall;
                        pb[i, j].Image = null;
                    }
                }
            }

        }

        private async void JAMGameView_KeyDown(object sender, KeyEventArgs e)
        {
            if (ScreenShot.Visible == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    gameController.ActionPerformed(JAMGameController.UP);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    gameController.ActionPerformed(JAMGameController.DOWN);
                }
                else if (e.KeyCode == Keys.Right)
                {
                    gameController.ActionPerformed(JAMGameController.RIGHT);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    gameController.ActionPerformed(JAMGameController.LEFT);
                }
                else if (e.KeyCode == Keys.C)
                {
                    cheat = !cheat;
                    gameController.ActionPerformed(99);
                }
            }
            if (gameModel.Board.At(gameModel.Girl.Location) != Board.EMPTY)
            {
                if (gameModel.Board.At(gameModel.Girl.Location) == Board.RSPIDER && !gameModel.Girl.MoveAble)
                {
                    await Task.Delay(1000);
                    ScreenShot.Image = SSpider;
                    ScreenShot.Visible = true;          
                }
                if (gameModel.Board.At(gameModel.Girl.Location) == Board.RDEVIL && !gameModel.Girl.MoveAble)
                {
                    await Task.Delay(1000);
                    ScreenShot.Image = SDevil;
                    ScreenShot.Visible = true;
                }
                if (gameModel.Board.At(gameModel.Girl.Location) == Board.RLADDER)
                {
                    await Task.Delay(1000);
                    click.PlaySync();
                    gameModel.ChangeStage(gameModel.Girl.Stage);
                    gameController.ActionPerformed(99);
                }
                if (gameModel.Board.At(gameModel.Girl.Location) == Board.RHOLE)
                {
                    await Task.Delay(1000);
                    click.PlaySync();
                    gameModel.ChangeStage(gameModel.Girl.Stage);
                    gameController.ActionPerformed(99);
                }
            }

        }

        private void Playgame_Click(object sender, EventArgs e)
        {
            numTorch.Visible = true;
            numCross.Visible = true;
            Level.Visible = true;
            ScreenShot.Visible = false;
            Playgame.Visible = false;
            Playgame.Enabled = false;
            HWP.Visible = true;
        }

        
        

        private void ScreenShot_Click(object sender, EventArgs e)
        {
            click.PlaySync();
            if (!gameModel.Girl.MoveAble)
            {
                gameModel.ChangeStage(gameModel.Girl.Stage);
                gameController.ActionPerformed(99);
                ScreenShot.Visible = false;
            }
            bg.Play();
        }

        private void Warming_Click(object sender, EventArgs e)
        {

        }

        private void HWP_Click(object sender, EventArgs e)
        {
            Next.Visible = true;
            ScreenShot.Visible = true;
            button1.Visible = true;
            ScreenShot.Image = how1;
            ScreenShot.BackgroundImage = how1;
            Level.Visible = numCross.Visible = numTorch.Visible = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(ScreenShot.Image == how1)
            {
                ScreenShot.Image = how2;
            }
            else
            {
                ScreenShot.Image = how1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level.Visible = numCross.Visible = numTorch.Visible = true;
            Next.Visible = false;
            button1.Visible = false;
            ScreenShot.Visible = false;
        }
    }
}
