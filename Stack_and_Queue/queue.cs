﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class queue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(data + " is inserted in queue.");
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine(this.head.data + " is removed from queue.");
            this.head = this.head.next;

        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Queue is empty.");
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
