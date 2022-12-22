// See https://aka.ms/new-console-template for more information
TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);

Solution s = new Solution();
var answer = s.SumNumbers(root);
Console.WriteLine(answer);


public class TreeNode
{
  public int val;
  public TreeNode left;
  public TreeNode right;
  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
  {
    this.val = val;
    this.left = left;
    this.right = right;
  }
}

public class Solution
{
  public int SumNumbers(TreeNode root)
  {
    int sum = 0;

    void Dfs(TreeNode root, int? current)
    {
      if (root == null) return;

      if (root.left == null && root.right == null) sum += current.Value;
      Dfs(root.left, ((current * 10) + root.left?.val));
      Dfs(root.right, ((current * 10) + root.right?.val));
      current -= root.val;
    }

    Dfs(root, root.val);
    return sum;
  }
}