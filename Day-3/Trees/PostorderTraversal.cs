static void postOrder(Node root)
{
    if (root == null)
    {
        return;
    }

    postOrder(root.left);
    postOrder(root.right);
    Console.Write(root.data + " ");
}