/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1; int center;
        
        while (left <= right) {
            center = left + (right - left) / 2;
            if (target == nums[center]) {
                return center;
            }
            else if (target > nums[center]) {
                left = center + 1;                 
            }
            else if (target < nums[center]) {
                right = center - 1;
            }
        }
        return -1;
    }
}
