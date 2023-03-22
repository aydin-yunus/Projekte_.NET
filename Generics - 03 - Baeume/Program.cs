namespace Generics___03___Baeume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree= new BinaryTree<int>();
            tree.Insert(50);
            tree.Insert(100);
            tree.Insert(25);
            tree.Insert(1);
            tree.Insert(10);
            tree.Insert(75);
            tree.Insert(65);
            tree.Insert(85);
            tree.Insert(61);
            tree.Insert(45);
            tree.Insert(35);
            tree.Insert(15);
            tree.Insert(10);
            tree.PrintInorder();
            tree.Delete(85);
            tree.PrintInorder();
        }
    }
}