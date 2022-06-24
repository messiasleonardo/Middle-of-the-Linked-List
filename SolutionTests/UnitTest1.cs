using Middle_of_the_Linked_List;
using Xunit;

namespace SolutionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {1,2,3,4,5}, new int[] {3,4,5})]
        [InlineData(new int[] {1,2,3,4,5,6}, new int[] {4,5,6})]
        [InlineData(new int[] {1,2,3,4,5,6,7}, new int[] {4,5,6,7})]
        [InlineData(new int[] {1,2,3,4,5,6,7,8}, new int[] {5,6,7,8})]
        public void Test1(int[] head, int[] expected)
        {
            Solution solution = new Solution();

            int[] actual = solution.MiddleNodeArrayList(head);

            Assert.Equal(expected, actual);
        }
    }
}