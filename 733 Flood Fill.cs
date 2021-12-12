/*
An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.

You are also given three integers sr, sc, and newColor. You should perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, 
plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with newColor.
*/

// 74.24%

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int color = image[sr][sc];
        if (color != newColor) bfs(image, sr, sc, color, newColor);
        return image;
    }
    
    public void bfs(int[][] image, int r, int c, int color, int newColor) {
        if (image[r][c] == color) {
            image[r][c] = newColor;
                if (r >= 1) bfs(image, r - 1, c, color, newColor);
                if (c >= 1) bfs(image, r, c - 1, color, newColor);
                if (r + 1 < image.Length) bfs(image, r + 1, c, color, newColor);
                if (c + 1 < image[0].Length) bfs(image, r, c + 1, color, newColor);
        }
    }
}
