using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenerics_list
{
    class Program
    {

        public class Node<T>
        {
            public T Inf;
            public Node<T> Next;
            public Node(T Node)
            {
                Inf = Node;
            }

        }
        public class MineList<T>
        {
            int count;
            private Node<T> head;
            public Node<T> Head
            {
                get
                {
                    return head;
                }
            }
            private Node<T> tail;
            public Node<T> Tail
            {
                get
                {
                    return tail;
                }
            }
            public MineList()
            {
                count = 0;
                head = null;
                tail = null;
            }

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
        public static void Main()
        {
            MineList<int> Test = new MineList<int>();
            Test.Add(5);
            Test.Add(123);
            int a = Test.Head.Inf;
            Test.Delete(5);
            int b = Test.Tail.Inf;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}


