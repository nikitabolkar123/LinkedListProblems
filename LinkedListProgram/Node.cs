﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    internal class Node
    {

        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}