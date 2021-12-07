/*
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, 
find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] 
where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.
*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int rightBorder = numbers.Length - 1, leftBorder = 0;
            int[] res = new int[2]; int sum;

            while (leftBorder < rightBorder) { 
                sum = numbers[leftBorder] + numbers[rightBorder];
                if (sum == target)
                {
                    res[0] = leftBorder + 1; res[1] = rightBorder + 1;
                    return res;
                }
                else if (sum > target) rightBorder--;
                else leftBorder++;
            }
            return res;
    }
}
