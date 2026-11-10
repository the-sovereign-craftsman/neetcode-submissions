public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        //upper bounds of k = max(piles);
        //binary search between 1 and max
        //each iteration scans all of piles
        //track smallest each time

        //range scan not a array scan

        var l = 1;
        var r = piles.Max();
        var _smallestK = int.MaxValue;

        while (l <= r) {
            var k = l + (r - l) / 2;
            if (ScanPiles(piles, k, h) > 0) { //too small - ran out of time
                l = k + 1;
            }
            else if (ScanPiles(piles, k, h) <= 0) {//big enough
                _smallestK = Math.Min(k, _smallestK);
                r = k - 1;
            }
        }

        return _smallestK;
    }

    private int ScanPiles(int[] piles, int k, int h) {
        
        var totalConsumptionTime = 0;
        foreach (var pile in piles) {
            totalConsumptionTime += (int)Math.Ceiling((double)pile / k);
            if (totalConsumptionTime > h) {
                return 1;
            }
        }

        if (totalConsumptionTime <= h) {
            return -1;
        }

        return 0;
    }
}
