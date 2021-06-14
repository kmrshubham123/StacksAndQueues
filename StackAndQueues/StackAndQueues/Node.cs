using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{
    public class Node
    {    // Variables
        public int data;// actual data that has to be store in list = data
        public Node next;// refer to the next node of the list
        /// <summary>
        /// constructor to initillize data
        /// </summary>
        /// <param int="data"></param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
