using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemos
{
    /// <summary>
    /// Represents a tree node
    /// </summary>
    /// <typeparam name="T">the type of the values in nodes</typeparam>
    public class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TreeNode<T>> children;

        /// <summary>
        /// Constructs a tree node
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when a null value is tried to be entered in the tree</exception>
        /// <param name="value">the value of the node</param>
        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        /// <summary>
        /// The value of the node
        /// </summary>
        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// The number of node's children
        /// </summary>
        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        /// <summary>
        /// Adds child to the node
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when a null value is tried to be added as a child</exception>
        /// <exception cref="ArgumentException">Thrown when an "adobted" node is tried to be added as a child</exception>
        /// <param name="child">the child to be added</param>
        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary>
        /// Gets the child of the node at given index
        /// </summary>
        /// <param name="index">the index of the desired child</param>
        /// <returns>the child on the given position</returns>
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
