namespace source._0600;

/// <summary>
///     https://leetcode.cn/problems/non-negative-integers-without-consecutive-ones
/// </summary>
public class Solution
{
    private static readonly int[] NonConsecutiveOnesCounts = CalculateNonConsecutiveOnesCount(32);

    public int FindIntegers(int n)
    {
        int previousBit = 0;
        int count = 0;
        for (int i = 30; i >= 0; --i)
        {
            if (IsOneBit(i))
            {
                count += NonConsecutiveOnesCounts[i + 1];
                if (previousBit == 1) break;

                previousBit = 1;
            }
            else
            {
                previousBit = 0;
            }

            if (i == 0)
            {
                ++count;
            }
        }

        return count;


        bool IsOneBit(int bitPosition)
        {
            return (n & (1 << bitPosition)) != 0;
        }
    }

    private static int[] CalculateNonConsecutiveOnesCount(int bitLength)
    {
        int[] counts = new int[bitLength];

        if (bitLength <= 2)
        {
            Array.Fill(counts, 1);
            return counts;
        }

        counts[0] = 1;
        counts[1] = 1;
        for (int i = 2; i < bitLength; ++i)
        {
            counts[i] = counts[i - 1] + counts[i - 2];
        }

        return counts;
    }
}