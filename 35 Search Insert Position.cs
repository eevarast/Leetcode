/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
            int center = 0;

            while (left <= right)
            {
                
                center = left + (right - left) / 2;

                if (target == nums[center])
                {
                    return center;
                }
                else if (target < nums[center])
                {
                    right = center - 1;
                }
                else if (target > nums[center])
                {
                    left = center + 1;
                }
            }
            if (target > nums[center]) return center + 1;
            else return center;
    }
}
