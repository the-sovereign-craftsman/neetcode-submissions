public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        
        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++) {
            if (!sDict.ContainsKey(s[i])) {
                sDict.Add(s[i], 1);
            }
            else {
                sDict[s[i]] += 1;
            }

            if (!tDict.ContainsKey(t[i])) {
                tDict.Add(t[i], 1);
            }
            else {
                tDict[t[i]] += 1;
            }
        }

        if (sDict.Count != tDict.Count) {
            return false;
        }

        foreach (var item in sDict) {
            if (!tDict.ContainsKey(item.Key)) {
                return false;
            }

            if (tDict[item.Key] != item.Value) {
                return false;
            }
        }

        return true;
    }
}
