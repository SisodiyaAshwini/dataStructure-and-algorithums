using System;

namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Console.WriteLine("List is: ");
                p = start;
                while(p != null)
                {
                    Console.WriteLine(p.info);
                    p = p.link;
                }
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int count = 0;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node p = start;
                while(p != null)
                {
                    count++;
                    p = p.link;
                }
                Console.WriteLine("Count is ", count);
            }
            
        }

        public bool Search(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return false;
            }
            else
            {
                int position = 1;
                Node p = start;
                while (p != null)
                {
                    if (p.info == x)
                        break;
                    p = p.link;
                    position++;
                }
                if(p==null)
                {
                    Console.WriteLine(x + "  is not found in the list");
                    return false;
                }
                else
                {
                    Console.WriteLine("{0} is found at {1} in the list", x, position);
                    return true;
                }
            }
        }

        public void FindLastNode()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node p = start;
                while(p!=null)
                {
                    p = p.link;
                }
                Console.WriteLine("Last node is {0}", p);
            }
        }

        public void SecondLastNode()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node p = start;
                while (p.link.link != null)
                {
                    p = p.link;
                }
                Console.WriteLine("Second Last node is {0}", p);
            }
        }

        public void PredecessorOfNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node p = start;
                while (p.link != null)
                {
                    if (p.link.info == x)
                        break;
                    p = p.link;
                }
                Console.WriteLine("Predecessor of x is {0}", p);
            }
        }

        public void ReferenceAtParticularPosition(int x)
        {
            Node p = start;
            for(int i=1; i<x && p!=null; i++)
            {
                p = p.link;
            }
            Console.WriteLine("Reference at position {0} is {1}",x, p);
        }

        public void InsertAtStart(int x)
        {
            Node p = start;
            Node temp = new Node(x);

            temp.link = start;
            start = temp;
        }

        public void InsertInEmptyList(int x)
        {
            Node temp = new Node(x);
            start = temp;
        }

        public void InsertAtEnd(int x)
        {
            Node temp = new Node(x);
            Node p;

            //Console.WriteLine("Out of curosity when start is null, when we are doing p=start, what is there in start? Obviously addess, as Node is reference valriable and info has {0} ", start.info);

            if(start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while(p.link != null)
            { 
                p = p.link;
            }

            p.link = temp;
        }

        public void InsertBetweenNodes(int nodeValue, int position)
        {
            Node temp = new Node(nodeValue);
            Node p = start;
            for (int i = 1; i < position-1 && p != null; i++)
            {
                p = p.link;
            }
            temp.link = p.link;
            p.link = temp;
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteOnlyNode()
        {
            start = null;
        }

        public void DeleteInBetweenNode(int position)
        {
            Node p = start;
            for(int i=0; i<position-1; i++)
            {
                p = p.link;
            }
            p = p.link.link;

        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if(start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while(p.link.link !=null)
            {
                p = p.link;
            }
            p.link = null;

        }

        public void ReverseList()
        {

        }

        public void CreateList()
        {
            int i, n, data;
            Console.WriteLine("Enter the number of nodes: ");
            n = Int32.Parse(Console.ReadLine());

            if (n == 0)
                return;

            for(i=1; i<=n; i++)
            {
                Console.WriteLine("Enter the element {0}: ",i);
                data = Int32.Parse(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
    }
}
