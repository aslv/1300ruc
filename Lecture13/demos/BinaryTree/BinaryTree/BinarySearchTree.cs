using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public BinarySearchTree(Node<int> root)
        {
            this.root = root;
        }
        private Node<int> root;
        private StringBuilder traverseResult;

        /// <summary>
        /// Add a node to one of the nodes of the tree.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when duplicate values are entered in the tree</exception>
        /// <param name="node">The node to add</param>    
        public void Add(int value)
        {
            Add(value, root);
        }

        private void Add(int value, Node<int> currentRoot)
        {
            if (value < currentRoot.Data)
            {
                if (currentRoot.Left==null)
                {
                    currentRoot.Left = new Node<int>(value);
                }
                else
                {
                    Add(value, currentRoot.Left);
                }
            }
            else if (value>currentRoot.Data)
            {                
                if (currentRoot.Right==null)
                {
                    currentRoot.Right = new Node<int>(value);
                }
                else
                {
                    Add(value, currentRoot.Right);
                }
            }
            else
            {
                throw new ArgumentException("Duplicated values");
            }
        }

        public string TraverseInorder()
        {
            traverseResult = new StringBuilder();
            TraverseInorder(root);
            traverseResult.Remove(traverseResult.Length - 1, 1);
            return traverseResult.ToString();
        }

        private void TraverseInorder(Node<int> root)
        {
            if (root.Left != null)
            {
                TraverseInorder(root.Left);
            }
            traverseResult.Append(root.Data);
            traverseResult.Append(" ");
            if (root.Right != null)
            {
                TraverseInorder(root.Right);
            }
        }

        public string TraversePostorder()
        {
            traverseResult = new StringBuilder();
            TraversePostorder(root);
            traverseResult.Remove(traverseResult.Length - 1, 1);
            return traverseResult.ToString();
        }

        private void TraversePostorder(Node<int> root)
        {
            if (root.Right != null)
            {
                TraversePostorder(root.Right);
            }
            traverseResult.Append(root.Data);
            traverseResult.Append(" ");
            if (root.Left != null)
            {
                TraversePostorder(root.Left);
            }
        }

    }
}
