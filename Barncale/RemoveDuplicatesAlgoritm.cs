namespace Tasks;

public static class RemoveDuplicatesAlgoritm
{
    public static int RemoveDuplicates(int[] nums)
    {
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                continue;
            }

            nums[count] = nums[i];
            count++;
        }

        return count;
    }
}