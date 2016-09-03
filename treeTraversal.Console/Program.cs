namespace treeTraversal.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Build Tree
            Tree theTree = new Tree();
            theTree.Insert(42);
            theTree.Insert(51);
            theTree.Insert(55);
            theTree.Insert(18);
            theTree.Insert(19);
            theTree.Insert(50);
            theTree.Insert(87);
            theTree.Insert(67);
            theTree.Insert(4);
            theTree.Insert(12);
            theTree.Insert(10);
            theTree.Insert(16);



            System.Console.WriteLine("InOrder traversal resulting tree sort:");
            theTree.InOrder(theTree.returnRoot());
            System.Console.WriteLine(" ");

            System.Console.WriteLine("PreOrder traversal result TreeSort:");
            theTree.PreOrder(theTree.returnRoot());
            System.Console.WriteLine("  ");

            System.Console.WriteLine("PostOrder Traversal result tree sort:");
            theTree.PostOrder(theTree.returnRoot());
            System.Console.WriteLine("   ");



            System.Console.ReadLine();
        }
    }

    public class Node
    {
        public int value { get; set; }
        public Node rightChildNode { get; set; }
        public Node leftChildNode { get; set; }

        public void PrintContents()
        {
            System.Console.Write('[');
            System.Console.Write(value);
            System.Console.Write(']');
        }
    }

    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public Node returnRoot()
        {
            return root;
        }

        public void Insert(int x)
        {
            var newNode = new Node();
            newNode.value = x;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parentNode;
                while (true)
                {
                    parentNode = current;
                    if (x < current.value)
                    {
                        current = current.leftChildNode;

                        if (current == null)
                        {
                            parentNode.leftChildNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChildNode;
                        if (current == null)
                        {
                            parentNode.rightChildNode = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void PreOrder(Node Root)
        {
            if (Root != null)
            {
                System.Console.Write(Root.value + " ");
                PreOrder(Root.leftChildNode);
                PreOrder(Root.rightChildNode);
            }
        }

        public void InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.leftChildNode);
                System.Console.Write(Root.value + " ");
                InOrder(Root.rightChildNode);
            }
        }

        public void PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.leftChildNode);
                PostOrder(Root.rightChildNode);
                System.Console.Write(Root.value + " ");
            }
        }
    }
}
