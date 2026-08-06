static int getHeight(Node root)
{
    if (root == null)
    {
        return -1;
    }

    int leftHeight = getHeight(root.left);
    int rightHeight = getHeight(root.right);

    return Math.Max(leftHeight, rightHeight) + 1;
}