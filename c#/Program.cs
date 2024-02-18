// https://www.codewars.com/kata/515bb423de843ea99400000a/solutions/csharp

using System;
using System.Collections.Generic;
using System.Linq;

public class PaginationHelper<T>
{
    // TODO: Complete this class

    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    /// 
    private IList<T> collection;
    private int itemsPerPage;

    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {
        this.collection = collection;
        this.itemsPerPage = itemsPerPage;
    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount
    {
        get
        {
            return collection.Count;
        }
    }

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount
    {
        get
        {
            return (int)Math.Ceiling((double)collection.Count / itemsPerPage);
        }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
{
    if (pageIndex < 0 || pageIndex >= PageCount)
    {
        return -1; // return -1 for invalid pageIndex values
    }
    else if (pageIndex < PageCount - 1)
    {
        return itemsPerPage; // return itemsPerPage for pages other than the last page
    }
    else // pageIndex == PageCount - 1 (last page)
    {
        // Calculate the number of items on the last page
        int remainingItems = collection.Count % itemsPerPage;
        return remainingItems == 0 ? itemsPerPage : remainingItems;
    }
}

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        return itemIndex >= 0 && itemIndex < collection.Count ? itemIndex / itemsPerPage : -1;
    }
}

public static class Kata
{

    public static void Main(string[] args)
    {
        var helper = new PaginationHelper<int>(new List<int> { 1}, 1);
        Console.WriteLine(helper.PageCount); // should == 1
        Console.WriteLine(helper.ItemCount); // should == 4
        Console.WriteLine(helper.PageItemCount(0)); // should == 4
        Console.WriteLine(helper.PageItemCount(1)); // last page - should == 2
        Console.WriteLine(helper.PageItemCount(2)); // should == -1 since the page is invalid

        helper.PageIndex(5); // should == 1 (zero based index)
        helper.PageIndex(2); // should == 0
        helper.PageIndex(20); // should == -1
        helper.PageIndex(-10); // should == -1




    }
}
