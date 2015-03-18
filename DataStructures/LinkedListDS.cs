
namespace DataStructures
{

    class Node<T>
    {

        public Node(T val, Node<T> next)
        {
            this.value = val;
            this.next = next;

        }
        private T value;
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private Node<T> next;

        public Node<T> Next
        {
            get { return this.next; }
            set { next = value; }
        }





    }
    class LinkedListDS<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedListDS()
        {
            head = null;
            tail = null;
        }

        public void pushback(T value)
        {
            if (head != null)
            {
                Node<T> e = new Node<T>(value, null);
                tail.Next = e;
                tail = e;
            }
            else
            {
                head = new Node<T>(value, null);
                tail = head;
            }


        }

        public void insert(T value, int index) { 
            Node<T> traverser = head;
            int i = 1;
            while (i != index - 1 && traverser.Next != null) {
                traverser = traverser.Next;
                i++;
            }
            Node<T> prenext = traverser.Next;
            traverser.Next = new Node<T>(value, prenext); 
        
        
        }

        public int size()
        {
            Node<T> traverser = head;
            int cnt = 0;
            while (traverser.Next != null)
            {
                cnt++;
                traverser = traverser.Next;
            }
            return cnt;
        }
    }
}
