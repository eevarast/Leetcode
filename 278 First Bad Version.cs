/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int i = 1;
        while (!IsBadVersion(i)) i++;
        return i;
    }
}
