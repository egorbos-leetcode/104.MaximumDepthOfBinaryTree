namespace Solution;

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}


public static class Solution
{
    public static TreeNode BuildTree(int?[] values)
    {
        if (values is null || values.Length == 0 || values[0] is null) return null;

        var root = new TreeNode((int)values[0]!);
        var queue = new Queue<TreeNode?>([root]);

        var i = 1;
        
        while (i < values.Length)
        {
            var current = queue.Dequeue();
            
            if (current is null) continue;

            if (i < values.Length)
            {
                var value = values[i++];
                current.left = value.HasValue ? new TreeNode(value.Value) : null;
                queue.Enqueue(current.left);
            }
            if (i < values.Length)
            {
                var value = values[i++];
                current.right = value.HasValue ? new TreeNode(value.Value) : null;
                queue.Enqueue(current.right);
            }
        }

        return root;
    }

    public static int MaxDepth(TreeNode root) {
        if (root is null) return 0;
        
        var left = MaxDepth(root.left);
        var right = MaxDepth(root.right);
        
        return 1 + Math.Max(left, right);
    }
}