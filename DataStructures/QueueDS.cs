using System.Collections.Generic;

namespace DataStructures
{
    class QueueDS<T>
    {
        private List<T> list;
        int index;
        public QueueDS() {
            list = new List<T>();
            index = -1;
        }

        public int count
        {
            get { return list.Count; }
        }

        public void push(T element) {
            list.Add(element);
            index++;
        
        }

        public T pop() {
            if (list.Count > 0)
            {
                T element = list[0];
                list.RemoveAt(0);
                return element;
            }
            else return default(T);
        }

        public T peak()
        {
            if (list.Count > 0)
                return list[0];
            
            else return default(T);
        }

        public void clear() {
            index = -1;
            list.Clear();
        }
        

    }
}
