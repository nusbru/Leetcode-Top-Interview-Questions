
namespace Leetcode;

public class RemoveDuplicatesFromArray
{
    // return number of unique items
    //input  [1,2,3,4,4,4,5,6,7,8,9,0]
    //output 10  [1,2,3,4,5,6,7,8,9,0,_,_]


    [Fact]
    public void Test1()
    {
        var nums = new int[] { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9, 20, 22, 22 };
        var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 22 };

        var result = RemoveDuplicatesFromSortedArray(nums);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void Test2()
    {
        var nums = new int[] { 1, 1, 2 };
        var expected = new int[] { 1, 2 };

        var result = RemoveDuplicatesFromSortedArray(nums);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    // Time complexity O(n) -> check all the itens  
    // Espace complexity O(1) -> no usage of auxiliar struture
    // Pointer tecnique. 
    public int[] RemoveDuplicatesFromSortedArray(int[] nums)
    {
        //return empty array if nums is null or empty.
        if (nums == null || nums.Length == 0)
            return Array.Empty<int>();

        //count the number of unique items
        var counter = 0;

        // traverser all the original array.
        for (int position = 0; position < nums.Length; position++)
        {
            //cheker if is the first loop or if the value in the current position is bigger than the previous one (position -1). 
            if (position < 1 || nums[position] > nums[position - 1])
            {
                //move the currente value to the postion represented by the counter
                nums[counter] = nums[position];
                //move the pointer to the next array position
                counter++;
            }
        }

        //Return array without duplicates.
        return nums;
    }
}