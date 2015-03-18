using System.Collections.Generic;

namespace DataStructures
{
    public class StackDS<T>
    {
        private List<T> list;

        public int count
        {
            get { return list.Count; }
        }
        
        int lastindex = -1;
        public StackDS() {
            list = new List<T>();
        }

        public void push(T element) {
            list.Add(element);
            lastindex ++;
        }

        public T pop() {
            if (list.Count > 0)
            {
                T element = list[lastindex];
                list.RemoveAt(lastindex);
                lastindex --;
                return element;
            }
            else return default(T);
        }

        public T peak()
        {

            if (lastindex > 0)
            {
                T element = list[lastindex];
                return element;
            }
            else return default(T);

        }

        public void clear(){
        list.Clear();
        lastindex = -1;
        }


    }
}
