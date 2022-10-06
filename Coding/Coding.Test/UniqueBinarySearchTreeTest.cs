namespace Coding.Test
{
    using TreeNode = Coding.UniqueBinarySearchTree.TreeNode;

    [TestClass]
    public sealed class UniqueBinarySearchTreeTest
    {
        [TestMethod]
        public void ShouldGenerateTreesWithOneNode()
        {
            UniqueBinarySearchTree app = new UniqueBinarySearchTree();
            app.GenerateTrees(1).Should().BeEquivalentTo(new List<TreeNode>()
            {
                new TreeNode(1),
            });
        }

        [TestMethod]
        public void ShouldGenerateTreesWithManyNodes()
        {
            UniqueBinarySearchTree app = new UniqueBinarySearchTree();
            app.GenerateTrees(3).Should().BeEquivalentTo(new List<TreeNode>()
            {
                new TreeNode(1, null, new TreeNode(3, new TreeNode(2))),
                new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3))),
                new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                new TreeNode(3, new TreeNode(2, new TreeNode(1))),
                new TreeNode(3, new TreeNode(1, null, new TreeNode(2))),
            });
        }
    }
}
