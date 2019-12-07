using Xunit;


namespace ValidateBSTTest
{
    public class ValidateBSTTest
    {
        [Fact]
        public void Test1()
        {
            var root = new ValidateBST.TreeNode(2);
            root.left = new ValidateBST.TreeNode(1);
            root.right = new ValidateBST.TreeNode(3);

            var actual = new ValidateBST.ValidateBSTCls().IsValidBST(root);
            Assert.True(actual);
        }
        [Fact]
        public void Test2()
        {
            var root = new ValidateBST.TreeNode(5);
            var root1 = new ValidateBST.TreeNode(1);
            var root2 = new ValidateBST.TreeNode(4);

            var root3 = new ValidateBST.TreeNode(3);
            var root4 = new ValidateBST.TreeNode(6);
            root2.left = root3;
            root2.right = root4;
            root.left = root1;
            root.right = root2;

            var actual = new ValidateBST.ValidateBSTCls().IsValidBST(root);
            Assert.False(actual);
        }
        [Fact]
        public void Test3()
        {
            var root = new ValidateBST.TreeNode(10);
            var root1 = new ValidateBST.TreeNode(5);
            var root2 = new ValidateBST.TreeNode(15);

            var root3 = new ValidateBST.TreeNode(6);
            var root4 = new ValidateBST.TreeNode(20);
            root2.left = root3;
            root2.right = root4;
            root.left = root1;
            root.right = root2;

            var actual = new ValidateBST.ValidateBSTCls().IsValidBST(root);
            Assert.False(actual);
        }
    }
}
