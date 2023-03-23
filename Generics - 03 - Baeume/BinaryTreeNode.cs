using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Baeume
{
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
