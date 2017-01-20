using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMGame
{
    class JAMGameController : Controller
    {
        public const int UP = 0;
        public const int DOWN = 1;
        public const int LEFT = 2;
        public const int RIGHT = 3;

        public override void ActionPerformed(int action)
        {
            foreach (JAMGameModel m in mList)
            {
                if (action == UP || action == DOWN || action == LEFT || action == RIGHT)
                {
                    m.MoveGirl(action);
                }
                else
                {
                    m.Update();
                }
            }
        }
    }
}
