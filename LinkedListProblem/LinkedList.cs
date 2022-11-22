using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data) // 56, 30, 70
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null) // while or else both will work
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void AddInReverseOrder(int data) // 70, 30, 56
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public Node InsertAtParticularPosition(int position, int data) // adding 30 in 1nd position
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        public void RemoveFirstNode() // 56 will be removed
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        public int Search(int value)
        {
            Node node = this.head;
            if (node == null)
                Console.WriteLine(value + " is not found");

            return -1;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of the Linkedlist is :- " + count);
        }
    }
}
