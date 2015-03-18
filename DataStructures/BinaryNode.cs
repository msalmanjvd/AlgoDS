using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryNode<T> {
        private T Value;

        public T value
        {
            get { return this.Value; }
        }
        private List<BinaryNode<T>> Neighbours;

        public BinaryNode<T> right
        {
            get { return this.Neighbours[1]; }
            set { Neighbours[1] = value; }
        }

        public BinaryNode<T> left
        {
            get { return Neighbours[0]; }
            set { this.Neighbours[0] = value; }
        }

        public BinaryNode(T data) : this(data, null, null) { }
        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.Neighbours = new List<BinaryNode<T>>(2);
            Neighbours.Add(left);
            Neighbours.Add(right);
            this.Value = data;
         }



        
    
    }
   
}
