using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    public class SinglyLinkedList
    {
        public Node head;

        public void InsertFront(SinglyLinkedList singlyList, int newData)
        {
            Node newnode = new Node(newData);
            newnode.next = singlyList.head;
            singlyList.head = newnode;
        }

        public void InsertLast(SinglyLinkedList singlyList,int newData)
        {
            Node newnode = new Node(newData);
            if(singlyList.head!=null)
            {
                singlyList.head = newnode;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = newnode;
        }

        public void InsertAfter(Node prevNode,int newData)
        {
            if(prevNode!=null)
            {
                Node n = new Node(newData);
                n.next = prevNode.next;
                prevNode.next = n;
            }
            else
            {
                Console.WriteLine("Node cannot be null");
                return;
            }
        }

        public Node GetLastNode(SinglyLinkedList sl)
        { 
            Node temp = sl.head;
            while(temp.next !=null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void GetNthNode(SinglyLinkedList sl,int nodeData)
        {
            LinkedList<int> linkedlist = new LinkedList<int>();
            
            Node temp = sl.head;
            while(temp.next!=null)
            {

                linkedlist.AddFirst(temp.data);
                temp = temp.next;
            }
            if(temp.next == null)
            {
                linkedlist.AddFirst(temp.data);
            }
            
            foreach (int i in linkedlist)
            {
                Console.WriteLine(i + "\n");
            }
        }

        public void DeleteNodebyKey(SinglyLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void ReverseLinkedList(SinglyLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            singlyList.head = prev;
        }
    }

    public class DoublyLinkedList
    {
        public DNode head;
    }



    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sl1 = new SinglyLinkedList();
            sl1.InsertFront(sl1, 5);
            sl1.InsertFront(sl1, 6);
            sl1.InsertFront(sl1, 7);
            sl1.InsertFront(sl1, 8);
            sl1.ReverseLinkedList(sl1);
            sl1.GetNthNode(sl1, 7);

            Node lastNode = sl1.GetLastNode(sl1);
            Console.WriteLine(lastNode.data);

            sl1.InsertLast(sl1, 8);
            lastNode = sl1.GetLastNode(sl1);
            Console.WriteLine(lastNode.data);

            Console.ReadLine();
        }
    }
}
