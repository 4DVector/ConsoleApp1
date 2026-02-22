using ConsoleApp1.Logic;

namespace ConsoleApp1.Tests;

public class UnitTest1
{
    [Fact]
    public void Sort_ShouldSortArrayInAscendingOrder()
    {
        var op = new ArrayOperations();
        int[] numbers = { 45, 12, 89, 7, 33, 21 };
        int[] expected = { 7, 12, 21, 33, 45, 89 };
        
        op.Sort(numbers);
        
        Assert.Equal(expected, numbers);
    }

    [Fact]
    public void Search_ShouldReturnCorrectIndex_WhenElementExists()
    {
        var op = new ArrayOperations();
        int[] numbers = { 7, 12, 21, 33, 45, 89 };
        
        int result = op.Search(numbers, 33);
        
        Assert.Equal(3, result);
    }

    [Fact]
    public void Search_ShouldReturnMinusOne_WhenElementDoesNotExist()
    {
        var op = new ArrayOperations();
        int[] numbers = { 7, 12, 21, 33, 45, 89 };
        
        int result = op.Search(numbers, 100);
        
        Assert.Equal(-1, result);
    }
    
    [Fact]
    public void Sort_ShouldHandleEmptyArray()
    {
        var op = new ArrayOperations();
        int[] numbers = { };
        
        op.Sort(numbers);
        
        Assert.Empty(numbers);
    }

    [Fact]
    public void Search_ShouldReturnMinusOne_ForEmptyArray()
    {
        var op = new ArrayOperations();
        int[] numbers = { };
        
        int result = op.Search(numbers, 10);
        
        Assert.Equal(-1, result);
    }
}