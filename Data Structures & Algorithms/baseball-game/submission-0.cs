public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>();

        foreach (var op in operations){
            switch (op) 
            {
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                default:
                    var num = int.Parse(op);
                    scores.Add(num);
                    break;
            }
        }

        return scores.Sum();
    }
}