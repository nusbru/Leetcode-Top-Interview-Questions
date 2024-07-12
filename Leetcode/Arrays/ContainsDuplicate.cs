namespace Leetcode;

///Given array of int, return if any values appears at least twice and false if every element is distinct
/// input  = [1,2,3,4,5,6,7]
/// output false
public class ContainsDuplicate
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 4 }, true)]
    public void Test1(int[] array, bool expected)
    {
        var uniques = new HashSet<int>(array);
        var result = uniques.Count != array.Length;

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 4 }, true)]
    public void Test2(int[] array, bool expected)
    {
        //Use the hashset data structure to remove duplicates
        var uniques = new HashSet<int>(array);
        //Compare the size of both arrays. If the size is equal the array contais only distinct values. 
        var result = uniques.Count != array.Length;

        Assert.Equal(expected, result);
    }
}
