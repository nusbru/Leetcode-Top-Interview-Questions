
namespace Leetcode;

public class BestTimeToBuyAndSellStocks
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] {1,2,3,4,5}, 4)]
    [InlineData(new int[] {7,6,4,3,1}, 0)]
    public void Test1(int[] stocks, int profit)
    {
        var result = BestTimeToBuyAndSell(stocks);
        Assert.Equal(profit, result);

    }

    // Time complexity O(n) -> check all the itens  
    // Espace complexity O(1) -> no usage of auxiliar struture
    // Pointer tecnique.
    // Hint: start from de second item in the array stocks[1] and compare with the previous stocks[i-1]
    private int BestTimeToBuyAndSell(int[] stocks)
    {
        //Check if stocks are empty, if so no chance to profit
        if (stocks == null && stocks.Length == 0)
            return 0;

        var profit = 0;

        //traverse all the stocks array starting from the second
        for (int i = 1; i < stocks.Length; i++) {

            //compare the current with the previous. It he previews is lower than the current, it is profitable
            if (stocks[i - 1] < stocks[i]) {

                //add the profit bettween the purchase and the selling.                
                profit += stocks[i] - stocks[i - 1];
            }
        }
        return profit;
    }
}