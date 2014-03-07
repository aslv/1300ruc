using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree;
using System.Collections.Generic;


namespace BinarySearchTreeTest
{
    [TestClass]
    public class BinarySearchTreeTest
    {

        [TestMethod]
        public void TraverseInorderTest()
        {            
            //Setup
            BinarySearchTree tree = CreateTree();

            //Act
            string output = tree.TraverseInorder();

            //Assert
            Assert.AreEqual("5 10 12 14 18 25",output,"TraverseInorder didn't sort the elements in ascending order");

        }
        [TestMethod]
        public void TraversePostorderTest()
        {
            //Setup
            BinarySearchTree tree = CreateTree();

            //Act
            string result = tree.TraversePostorder();

            //Assert
            Assert.AreEqual( "25 18 14 12 10 5",result);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void AddExistingValue()
        {
            //Setup
            Node<int> root = new Node<int>(25);
            BinarySearchTree tree = new BinarySearchTree(root);

            //Act
            tree.Add(25);
        }

        [TestMethod]
        public void AddNonExistingValue()
        {
            //Setup
            Node<int> root = new Node<int>(25);
            BinarySearchTree tree = new BinarySearchTree(root);

            //Act
            tree.Add(21);
        }
        private BinarySearchTree CreateTree()
        {
            Node<int> root = new Node<int>(25);
            BinarySearchTree tree = new BinarySearchTree(root);
            tree.Add(5);
            tree.Add(10);
            tree.Add(12);
            tree.Add(18);
            tree.Add(14);
            return tree;
        }
    }
}
