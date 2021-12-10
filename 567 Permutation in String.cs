/*
Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
In other words, return true if one of s1's permutations is the substring of s2.
*/

// 79.00% 

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

            int[] dict1 = new int[26];
            int[] dict2 = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                dict1[s1[i] - 'a']++;
                dict2[s2[i] - 'a']++;
            }

            if (isEqualDict(dict1, dict2)) return true;

            int leftBorder = 0, rightBorder = s1.Length;

            
            while (rightBorder < s2.Length)
            {
                dict2[s2[leftBorder] - 'a']--;
                dict2[s2[rightBorder] - 'a']++;
                if (isEqualDict(dict1, dict2)) return true;
                leftBorder++;
                rightBorder++;
                
            }

            return false;
        }

        public bool isEqualDict (int[] d1, int[] d2)
        {
            for (int i = 0; i < d1.Length; i++)
                if (d1[i] != d2[i]) return false;
            return true;
        }
    }
