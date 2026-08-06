static void inOrder(Node root)
{
    if (root == null)
    {
        return;
    }

    inOrder(root.left);
    Console.Write(root.data + " ");
    inOrder(root.right);
}