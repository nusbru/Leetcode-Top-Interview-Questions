using System.Runtime.CompilerServices;

namespace Leetcode;

public class RotateArray
{
    ///Given array of int, rotate array ti the right by k steps, where K is non-negative.

    /// input  = [1,2,3,4,5,6,7]
    /// k = 3
    /// output = [5,6,7,1,2,3,4]

    [Theory]
    [InlineData(3, new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(2, new[] { -1, -100, 3, 99 }, new[] { 3, 99, -1, -100 })]
    public async void Test1(int k, int[] array, int[] expected)
    {
       

        //Create a temporary array
        var tmp = new int[array.Length];

        //traverse over the array
        for (int i = 0; i < array.Length; i++)
        {
            //calculate the index to push to the right  
            var index = (i + k) % array.Length;
            //move the current value to new position
            tmp[index] = array[i];
        }


        //traverse over the temporary array
        for (int i = 0; i < tmp.Length; i++)
        {
            //move back to the original array.
            array[i] = tmp[i];
        }

        Assert.Equal(expected, array);
    }

    [Theory]
    [InlineData(3, new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(2, new[] { -1, -100, 3, 99 }, new[] { 3, 99, -1, -100 })]
    public async void Test2(int k, int[] array, int[] expected)
    {
        //calculate postions to push 
        k = k % array.Length;

        //reverse all the array
        Reverse(array, 0, array.Length -1);

        //reverse the first part    
        Reverse(array, 0, k -1);
        //rever the last part
        Reverse(array, k, array.Length -1);

        Assert.Equal(expected, array);
    }

    private void Reverse(int[] array,int head, int tail)
    {
        //while push head to next spot is bigger than pulling tail to previous spot
        while(head < tail)
        {
            //store value from head postion
            var tmp = array[head];
            //switch heand and tail 
            array[head] = array[tail];
            //place the head value in the tail position
            array[tail] = tmp;

            //move head one spot forward
            head++;
            //move tail one spot backward
            tail--;
        }
    }
}
