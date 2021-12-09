/*
Given an array, rotate the array to the right by k steps, where k is non-negative.
*/

// 49.75%

public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] res = new int[nums.Length];
        
        if (k > nums.Length) k = k % nums.Length;
            
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[(nums.Length - k + i) % nums.Length];
            }

            for (int i = 0; i < nums.Length; i++)
                nums[i] = res[i];
        }
    }
