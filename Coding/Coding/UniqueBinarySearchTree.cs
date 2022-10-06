namespace Coding
{
    public sealed class UniqueBinarySearchTree
    {
        public UniqueBinarySearchTree()
        {
        }

        public IList<TreeNode> GenerateTrees(int n)
        {
            List<TreeNode> trees = Helper(start: 1, end: n + 1);
            return trees;
        }

        private List<TreeNode> Helper(int start, int end)
        {
            List<TreeNode> trees = new List<TreeNode>();
            if (start == end)
            {
                trees.Add(null);
                return trees;
            }

            for (int i = start; i < end; i++)
            {
                List<TreeNode> lefts = Helper(start, i);
                List<TreeNode> rights = Helper(i + 1, end);
                foreach (TreeNode left in lefts)
                {
                    foreach (TreeNode right in rights)
                    {
                        trees.Add(new TreeNode(i, left, right));
                    }
                }
            }

            return trees;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}