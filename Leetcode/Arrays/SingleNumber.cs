namespace Leetcode.Arrays;

public class SingleNumber
{
    //retunr the value that only appear once
    //input [1,2,3,3,4,4,5,3,5]
    //output 1

    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    public void Test1(int[] array, int expected)
    {
        var single = 0;
        foreach (var item in array)
        {
            //Using XOR to compare bits
            //sum the single in bits and the current item in bits  
            single ^= item;
        }

        Assert.Equal(expected, single);
    }

    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    public void Test2(int[] array, int expected)
    {
        var map = new HashSet<int>();
        foreach (var item in array){
            if(map.Contains(item)){
                map.Remove(item);
            }
            else{
                map.Add(item);
            }
        }

        Assert.Equal(expected, map.First());
    }
}
