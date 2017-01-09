﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JAMGame
{
    class Controller 
    {
        protected ArrayList mList;

        public Controller()
        {
            mList = new ArrayList();
        }

        public void AddModel(Model m)
        {
            mList.Add(m);
        }

        // virtual keyword allow the method to be overriden
        public virtual void ActionPerformed(int action)
        {
            throw new NotImplementedException();
        }
    }
}
