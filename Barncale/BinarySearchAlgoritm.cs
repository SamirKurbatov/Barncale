namespace Tasks;

public static class BinarySearchAlgoritm
{
    public static int BinarySearch(int[] array, int targetValue, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }

        var middle = (start + end) / 2;
        var middleValue = array[middle];

        if (middleValue == targetValue)
        {
            return middle;
        }

        if (middleValue > targetValue)
        {
            return BinarySearch(array, targetValue, start, middle - 1);
        }

        return BinarySearch(array, targetValue, middle + 1, end);
    }
}