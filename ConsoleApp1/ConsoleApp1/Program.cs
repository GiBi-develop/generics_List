using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{

    public class Node<T>
    {
        public T Inf { get; set; }
        public Node<T> Next { get; set; }
        public Node(T Node)
        {
            Inf = Node;
        }

    }
    public class List<T> 
    {
        int count;
        Node<T> head; 
        Node<T> tail;  

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null) { head = node; }
            else { tail.Next = node; }
            tail = node;
            count++;
        }
        public bool Delete(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Inf.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }
    }
}
