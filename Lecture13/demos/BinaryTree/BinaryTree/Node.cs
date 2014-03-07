using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        public Node()
        {
        }
        public Node(T data) {
            this.data = data;
        }
        private T data;

        private Node<T> left;

        private Node<T> right;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }
        
    }
}
