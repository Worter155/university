namespace PL_04
{
    public class LinkedListVector : IVectorable
    {
        class Node
        {
            public int value;
            public Node next;

            public Node(int v)
            {
                value = v;
                next = null;
            }
            public Node() : this(0) { }
        }

        Node head;

        public LinkedListVector(int n)
        {
            if (n > 0)
            {
                head = new Node();
                Node node = head;
                for (int i = 1; i < n; i++)
                {
                    node.next = new Node();
                    node = node.next;
                }
            }
            else
            {
                throw new Exception("Число должно быть больше 0");
            }
        }
        public LinkedListVector() : this(5) { }

        public int Length
        {
            get
            {
                int n = 0;
                Node node = head;
                while (node != null)
                {
                    node = node.next;
                    n++;

                }
                return n;
            }
        }

        public int this[int index]
        {
            get
            {
                try
                {
                    Node current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    return current.value;
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
            }
            set
            {
                try
                {
                    Node current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    current.value = value;
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
            }
        }

        public double GetNorm()
        {
            double s = 0;
            Node current = head;
            for (int i = 0; i < Length; i++)
            {
                s += Math.Pow(current.value, 2);
                current = current.next;
            }
            return Math.Sqrt(s);
        }

        public void AddToEnd(int p)
        {
            Node current = head;
            for (int i = 1; i < Length; i++)
            {
                current = current.next;
            }
            current.next = new Node(p);
        }

        public void AddToStart(int p)
        {
            Node node = new Node(p);
            node.next = head;
            head = node;
        }

        public void Add(int index, int p)
        {
            if (index == 0)
            {
                AddToStart(p);
            }
            else if (index == Length)
            {
                AddToEnd(p);
            }
            else
            {
                try
                {
                    Node current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    Node node = new Node(p);
                    node.next = current;
                    current = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
            }
        }

        public void RemoveEnd()
        {
            Node current = head;
            for (int i = 1; i < Length - 1; i++)
            {
                current = current.next;
            }
            current.next = null;
        }

        public void RemoveHead()
        {
            head = head.next;
        }

        public void Remove(int index)
        {
            if (index == Length - 1)
            {
                RemoveEnd();
            }
            else if (index == 0)
            {
                RemoveHead();
            }
            else
            {
                try
                {
                    Node current = head;
                    Node node;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    node = current.next;
                    current = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
            }
        }

        public override string ToString()
        {
            string s = $"{Length}: ";
            for (int i = 0; i < Length; i++)
            {
                s += $"{this[i]} ";
            }

            return s;
        }

        public override bool Equals(object obj)
        {
            if (ToString() == obj.ToString()) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVectorable v = obj as IVectorable;
            if (v != null)
            {
                if (v.Length < Length) return -1;
                else if (v.Length > Length) return 1;
                else return 0;
            }
            else throw new Exception();
        }

        public object Clone()
        {
            LinkedListVector llv = new LinkedListVector(Length);
            for (int i = 0; i < Length; i++)
            {
                llv[i] = this[i];
            }
            return llv;
        }
    }
}