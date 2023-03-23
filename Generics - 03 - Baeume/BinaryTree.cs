using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Generics___03___Baeume
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> rootNode;
        private BinaryTreeNode<T> previousNode;

        public void Clear()
        {
            this.rootNode = null;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        }

        public void Insert(T value)
        {
            if (rootNode == null)
            {
                rootNode = new BinaryTreeNode<T>(value);
            }
            else
            {
                InsertNode(rootNode, new BinaryTreeNode<T>(value));
            }
        }
        private void InsertNode(BinaryTreeNode<T> node, BinaryTreeNode<T> nodeToInsert)
        {
            if (node.Data.CompareTo(nodeToInsert.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = nodeToInsert;
                }
                else
                {
                    InsertNode(node.Left, nodeToInsert);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = nodeToInsert;
                }
                else
                {
                    InsertNode(node.Right, nodeToInsert);
                }
            }
        }
        public bool Contains(T value)
        {
            return Search(value)!=null;
        }
        public BinaryTreeNode<T> Search (T value)
        {
            return Search(value, rootNode);
        }
        private BinaryTreeNode<T> Search(T value, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                if (Equals(node.Data, value))
                {
                    return node;
                }
                else
                {
                    if (node.Data.CompareTo(value) == 1)
                    {
                        previousNode = node;
                        return Search(value, node.Left);
                    }
                    else
                    {
                        previousNode= node;
                        return Search(value, node.Right);
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public void PrintInorder()
        {
            PrintInorder(rootNode);
            Console.WriteLine();
        }
        public void PrintInorder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PrintInorder(node.Left);
                Console.WriteLine(node.Data);
                PrintInorder(node.Right);
            }
        }
        public void Delete(T value)
        {
            BinaryTreeNode<T> nodeToDelete=Search(value);
            
            if (nodeToDelete != null)
            {
                if (nodeToDelete.Left != null && nodeToDelete.Right != null)
                {
                    if (nodeToDelete==rootNode)
                    {
                        rootNode = nodeToDelete.Left;
                        InsertNode(rootNode, nodeToDelete.Right);
                    }
                    else
                    {
                        bool currentNodeIsLeftNode = nodeToDelete.Data.CompareTo(previousNode.Data) == -1;
                        if (currentNodeIsLeftNode)
                        {
                            previousNode.Left= nodeToDelete.Left;
                        }
                        else
                        {
                            previousNode.Right= nodeToDelete.Left;
                        }
                        InsertNode(previousNode, nodeToDelete.Right);
                    }
                }
                else 
                {
                    DeleteNodeWithOneOrZeroChildNodes(nodeToDelete) ;
                }
            }
        }
        private void DeleteNodeWithOneOrZeroChildNodes( BinaryTreeNode<T> nodeToDelete)
        {
            if (nodeToDelete.Left != null)
            {
                InsertNode(previousNode, nodeToDelete.Left);
            }
            else if (nodeToDelete.Right != null)
            {
                InsertNode(previousNode, nodeToDelete.Right);
            }
            else
            {
                previousNode.Left = previousNode.Right = null;
            }
        }
    }
}
