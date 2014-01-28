using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T>
    {
        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }
        private Node<T> root;
        /// <summary>
        /// Add a node to one of the nodes of the tree.
        /// </summary>
        /// <param name="root">The root to add to</param>
        /// <param name="node">The node to add</param>
        public void Add(Node<T> root,Node<T> node)
        {
            if (root.Left == null)
            {
                root.Left = node;
            }
            else if(root.Right==null)
            {
                root.Right = node;
            }
            else
            {
                throw new ArgumentException("Can't add another node to this root");
            }
        }

        public void TraverseInorder()
        {
            TraverseInorder(root);
        }

        private void TraverseInorder(Node<T> root)
        {
            if (root.Left!=null)
            {
                TraverseInorder(root.Left);
            }
            Console.WriteLine(root.Data);
            if (root.Right!=null)
            {
                TraverseInorder(root.Right);
            }
        }

        public void TraversePostorder()
        {

        }

        private void TraversePostorder(Node<T> root)
        {
            if (root.Right != null)
            {
                TraverseInorder(root.Right);
            }
            Console.WriteLine(root.Data);
            if (root.Left != null)
            {
                TraverseInorder(root.Left);
            }
        }
    }
}
