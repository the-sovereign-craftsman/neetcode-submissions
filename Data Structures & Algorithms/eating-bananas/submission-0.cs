public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        //piles[i] = # of bananas in that pile
        //h = # of hours alloted to eat all bananas

        var max = piles.Max();

        var l = 1;
        var r = max;

        int smallestK = int.MaxValue;
        var k = 0;
        while (l <= r) {
            k = l + (r - l) / 2;
            //scan the whole pile calculating m (a.k.a k)
            if (ScanPile(piles, h, k) > 0){
                l = k + 1;
            }
            else if (ScanPile(piles, h, k) <= 0) {
                smallestK = Math.Min(k, smallestK);
                r = k - 1;
            }
        }

        return smallestK;
    }

    private int ScanPile(int[] piles, int h, int k) {
        long totalConsumptionTime = 0;
        foreach (var pile in piles) {
            totalConsumptionTime += (long)Math.Ceiling((double)pile / k);
            
            if (totalConsumptionTime > h){
                return 1;
            }
        }

        if (totalConsumptionTime < h) {
            return -1;
        }
        else {
            return 0;
        }
    }
}
