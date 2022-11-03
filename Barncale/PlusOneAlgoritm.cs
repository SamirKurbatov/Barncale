namespace Tasks;

public static class PlusOneAlgoritm
{
    public static int[] PlusOne(int[] digits)
    {
        int i = digits.Length - 1;

        while (i >= 0 && digits[i] == 9)
        {
            i--;
        }

        if (i == -1)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        int[] generalResult = new int[digits.Length];

        generalResult[i] = digits[i] + 1;
        for (int j = 0; j < i; j++)
        {
            generalResult[j] = digits[j];
        }

        return generalResult;
    }
}