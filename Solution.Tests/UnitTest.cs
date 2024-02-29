namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        Assert.Equal(3, Solution.MaxDepth(Solution.BuildTree([3, 9, 20, null, null, 15, 7])));
        Assert.Equal(2, Solution.MaxDepth(Solution.BuildTree([1, null, 2])));
        Assert.Equal(3, Solution.MaxDepth(Solution.BuildTree([1, 2, 3, 4, null, null, 5])));
        Assert.Equal(4, Solution.MaxDepth(Solution.BuildTree([0, 2, 4, 1, null, 3, -1, 5, 1, null, 6, null, 8])));
    }
}