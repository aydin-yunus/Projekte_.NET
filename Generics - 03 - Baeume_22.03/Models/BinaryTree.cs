using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Baeume_22._03.Models
{
    public class BinaryTree<T>:IBinaryTree<T> where T :IComparable<T>
    {
        private BinaryTreeNode<T> rootNode;
        private BinaryTreeNode<T> previousNode;

        public void Clear()
        {
            this.rootNode = null; 
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public void Delete(T value)
        {
            throw new NotImplementedException();
        }

        public void Insert(T value)
        {
            if (rootNode==null)
            {
                rootNode = new BinaryTreeNode<T>(value);
            }
            else
            {
                InsertNode(rootNode, new BinaryTreeNode<T>(value));
            }
        }

        public void PrintInorder()
        {
            throw new NotImplementedException();
        }

        public BinaryTreeNode<T> Search(T value)
        {
            throw new NotImplementedException();
        }
    }
}
