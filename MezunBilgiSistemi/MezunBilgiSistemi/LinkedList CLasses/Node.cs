﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MezunBilgiSistemi
{
    public class Node
    {

        public  object Data;

        public Node Next;

        public Node()
        {

        }

        public Node(object Data)
        {
            this.Data = Data;
        }
    }
}