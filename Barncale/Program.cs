using System.Diagnostics;
using Tasks;

// TwoSum
{
    var newArray = new[] { 0, 2, 3, 4 };
    TwoSumAlgoritm.TwoSum(newArray, 3);

    foreach (var item in newArray)
    {
        Console.Write(item + " ");
    }
}

// RemoveElement
{
    var newArray = new[] { 0, 2, 3, 4 };
    var removeElement = RemoveElementAlgoritm.RemoveElement(newArray, 2);
    Console.WriteLine(removeElement);
}

// RemoveDuplicates
{
    var array = new int[] { 0, 1, 1, 2, 3 };
    var removeDupl = RemoveDuplicatesAlgoritm.RemoveDuplicates(array);
    Console.WriteLine(removeDupl);
}

// BinarySearch
{
    var array = new int[] { 1, 3, 5, 6 };

    var search = BinarySearchAlgoritm.BinarySearch(array, 3, 0, array.Length - 1);
    Console.WriteLine(search);
}

// PlusOne
{
    var array = new int[] { 1, 3, 5, 6 };

    var plusOne = PlusOneAlgoritm.PlusOne(array);

    foreach (var item in plusOne)
    {
        Console.Write(" " + item);
    }
}

// MaxProfit
{
    var array = new int[] { 7, 1, 5, 3, 6, 4 };
    var maxProfitArray = MaxProfitAlgoritm.MaxProfit(array);
    Console.WriteLine(maxProfitArray);
}

// RomanToInt
{
    var roman = RomanToIntAlgoritm.RomanToInt("XXCV");
    Console.WriteLine(roman);
}

// Anagram
{
    var isAnagram = IsAnagramAlgoritm.IsAnagram("b", "b");
    var isAnagram2 = IsAnagramAlgoritm.IsAnagram("a", "b");
    Console.WriteLine(isAnagram);
    Console.WriteLine(isAnagram2);
}


// Для себя:)

// var array = new[] { 2, 4, 6 };
//
// var count = Count(array, 0);
// Console.WriteLine(count);
//
// int Count(int[] array, int count)
// {
//     if (count == array.Length - 1)
//     {
//         count++;
//     }
//     else
//     {
//         count = Count(array, ++count);
//     }
//
//     return count;
// }


// var array = new[] { 1, 5, 4, 3, 2 };
// var maxValue = GetMaxValueNumber(array, 4);
// Console.WriteLine(maxValue);
//
// int GetMaxValueNumber(int[] array, int number)
// {
//     if (number == 1)
//     {
//         return array[0];
//     }
//     else if (number == 2)
//     {
//         return IsEqual(array[0], array[1]);
//     }
//     else
//     {
//         return IsEqual(array[number - 1], GetMaxValueNumber(array, number - 1));
//     }
// }
//
// int IsEqual(int firstNumber, int secondNumber)
// {
//     return (firstNumber > secondNumber) ? firstNumber : secondNumber;
// }


// var numbers = new[]{ 4, -12, 3, 3, 31, 0, 7, 4, 14, 90, 5 };
//
// numbers = QuickSort(numbers, 0, numbers.Length - 1);
//
// foreach (var item in numbers)
// {
//     Console.Write(item);
// }
//
// int[] QuickSort(int[] array, int minIndex, int maxIndex)
// {
//     if (minIndex >= maxIndex)
//     {
//         return array;
//     }
//     var pivot = FindPivot(array, minIndex, maxIndex);
//     QuickSort(array, minIndex, pivot - 1);
//     QuickSort(array, pivot + 1, maxIndex);
//
//     return array;
// }
//
// int FindPivot(int[] array, int minIndex, int maxIndex)
// {
//     var pivot = minIndex - 1;
//     var temp = 0;
//     for (int i = minIndex; i < maxIndex; i++)
//     {
//         if (array[i] < array[maxIndex])
//         {
//             pivot++;
//             temp = array[pivot];
//             array[pivot] = array[i];
//             array[i] = temp;
//         }
//     }
//
//     pivot++;
//     temp = array[pivot];
//     array[pivot] = array[maxIndex];
//     array[maxIndex] = temp;
//     
//     return pivot;
// }