namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            BinarySearchTreee bst = new BinarySearchTreee();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);


            Console.WriteLine("Inorder Traversal:");
            bst.InorderTraversal();

            Console.WriteLine();

            Console.WriteLine("Preorder Traversal:");
            bst.PreorderTraversal();

            Console.WriteLine();

            Console.WriteLine("Postorder Traversal:");
            bst.PostorderTraversal();

            Console.WriteLine();

            Console.WriteLine("Searching for value 4: " + bst.Search(40));
            Console.WriteLine("Searching for value 9: " + bst.Search(9));


        }
    }
}