static void preOrder(Node root)
{
    if (root == null)
    {
        return;
    }

    Console.Write(root.data + " ");
    preOrder(root.left);
    preOrder(root.right);
}