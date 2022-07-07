using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class stack
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
        public void peak_data()
        {
            if (this.top == null)
                Console.WriteLine("Stack is Empty.");
            else
                Console.WriteLine("Data at the peak of stack is: " + this.top.data + "\n");
        }
        public void pop_data()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty.");
                return;
            }
            Console.WriteLine(this.top.data + " is popped from stack.\n");
            this.top = this.top.next;
            peak_data();
        }
    }
}
