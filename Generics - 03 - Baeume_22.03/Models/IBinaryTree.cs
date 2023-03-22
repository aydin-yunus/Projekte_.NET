﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___03___Baeume_22._03.Models
{
    interface IBinaryTree<T> where T : IComparable<T>
    {
        void Clear();
        void Insert(T value);
        void Delete(T value);
        bool Contains(T value);
        BinaryTreeNode<T> Search(T value);
        void PrintInorder();
    }
}
