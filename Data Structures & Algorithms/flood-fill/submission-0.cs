public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color) {
            return image;
        }
        
        Backtrack(image, sr, sc, color, image[sr][sc]);

        return image;
    }

    private void Backtrack(int[][] image, int r, int c, int color, int source) {
        Console.WriteLine("Backtrack Frame");
        
        //base cases
        var rowLength = image.Length;
        var colLength = image[0].Length;

        if (Math.Min(r, c) < 0 
            || r >= rowLength 
            || c >= colLength
            || image[r][c] != source) 
        {
            return;
        }

        Console.WriteLine("r = " + r);
        Console.WriteLine("c = " + c);
        Console.WriteLine("source = " + source);
        Console.WriteLine("image cell = " + image[r][c]);

        source = image[r][c];
        image[r][c] = color;

        Backtrack(image, r + 1, c, color, source);
        Backtrack(image, r - 1, c, color, source);
        Backtrack(image, r, c + 1, color, source);
        Backtrack(image, r, c - 1, color, source);

    }
}