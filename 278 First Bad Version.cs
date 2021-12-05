/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
//O(n)
/* 
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int i = 1;
        while (!IsBadVersion(i)) i++;
        return i;
    }
}
*/
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1, right = n, center;
        
        while (left < right) {
            center = left + (right - left) / 2;
            if (IsBadVersion(center)) {
                right = center;
            }
            else { left = center + 1; }
        }
        return left;
    }
}
