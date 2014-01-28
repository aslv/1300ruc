using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(10);
            //Node<int> node1 = new Node<int>(5);
            //Node<int> node2 = new Node<int>(8);
            //Node<int> node3 = new Node<int>(7);
            //BinaryTree<int> tree = new BinaryTree<int>(root);
            //tree.Add(root, node1);
            //tree.Add(root, node2);
            //tree.Add(node1, node3);
            //tree.TraverseInorder();
            BinarySearchTree bst = new BinarySearchTree(root);
            bst.Add(5);
            bst.Add(8);
            bst.Add(12);
            bst.Add(11);
            bst.Add(32);
            bst.TraversePostorder();
        }
    }
}
