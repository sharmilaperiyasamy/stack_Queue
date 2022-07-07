using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class queue
    {
        Node top;
        public void Stack_Queue()
        {
            this.top = null;
        }
        public void add_Data(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("Data added to the top: " + data);
        }
    }
}
