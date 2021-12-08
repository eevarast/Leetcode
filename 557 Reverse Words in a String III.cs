/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
*/

public class Solution {
    public string ReverseWords(string s) {
        string res = ""; s += " ";
            int rightBorder = 0, leftBorder = 0;


            while (rightBorder < s.Length - 1)
            {
                while (s[rightBorder] != ' ')
                {
                    rightBorder++;
                }

                int j = rightBorder - 1;
                while (j >= leftBorder)
                {
                    res += s[j]; j--;
                }

                rightBorder++;
                leftBorder = rightBorder;
                if (rightBorder < s.Length - 1) res += ' ';
            }
            return res;
    }
}
