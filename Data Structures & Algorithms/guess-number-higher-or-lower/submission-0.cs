/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var l = 1;
        var r = n;

        while (l <= r) {
            var m = l + (r - l) / 2;
            if (guess(m) > 0){
                l = m + 1;
            }
            else if (guess(m) < 0){
                r = m - 1;
            }
            else {
                return m;
            }
        }
        return -1;
    }
}