/*
Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.
*/

public class Solution {
    public void ReverseString(char[] s) {
        char temp;

            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
    }
}
