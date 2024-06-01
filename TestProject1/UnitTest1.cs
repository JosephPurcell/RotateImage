namespace TestProject1
{
    using RotateImage;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int[][] expected = [[7, 4, 1], [8, 5, 2], [9, 6, 3]];
            Solution solution = new Solution();
            solution.Rotate(matrix);
            CollectionAssert.Equals(matrix, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
            int[][] expected = [[15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]];
            Solution solution = new Solution();
            solution.Rotate(matrix);
            CollectionAssert.Equals(matrix, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[][] matrix = [[5]];
            int[][] expected = [[5]];
            Solution solution = new Solution();
            solution.Rotate(matrix);
            CollectionAssert.Equals(matrix, expected);
        }
    }
}