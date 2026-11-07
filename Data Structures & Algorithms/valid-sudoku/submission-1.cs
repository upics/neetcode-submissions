public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Horizontal line indexes = for each xi [x][0],[x][1],[x][2]
                                // for each xi [x][3],[x][4],[x][5]
                                // for each xi [x][6],[x][7],[x][8]
        // Vertical line indexes = [x][0], [x][3], [x][6]  
                                //[x][1], [x][4], [x][7]  

        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>()
        {
            {0, new HashSet<char>()},
            {1, new HashSet<char>()},
            {2, new HashSet<char>()},
            {3, new HashSet<char>()},
            {4, new HashSet<char>()},
            {5, new HashSet<char>()},
            {6, new HashSet<char>()},
            {7, new HashSet<char>()},
            {8, new HashSet<char>()}
        };
        Dictionary<int, HashSet<char>> columns = new Dictionary<int, HashSet<char>>()
        {
            {0, new HashSet<char>()},
            {1, new HashSet<char>()},
            {2, new HashSet<char>()},
            {3, new HashSet<char>()},
            {4, new HashSet<char>()},
            {5, new HashSet<char>()},
            {6, new HashSet<char>()},
            {7, new HashSet<char>()},
            {8, new HashSet<char>()}
        };

        Dictionary<(int,int), HashSet<char>> squares = new Dictionary<(int,int), HashSet<char>>()
        {
            {(0,0), new HashSet<char>()},
            {(0,1), new HashSet<char>()},
            {(0,2), new HashSet<char>()},
            {(1,0), new HashSet<char>()},
            {(1,1), new HashSet<char>()},
            {(1,2), new HashSet<char>()},
            {(2,0), new HashSet<char>()},
            {(2,1), new HashSet<char>()},
            {(2,2), new HashSet<char>()},
        };

        for (int i = 0; i < 9; i++) 
        {
            for (int j = 0; j < 9; j++) {
                if(board[i][j] == '.')
                    continue;
                if (rows[i].Contains(board[i][j]) ||
                    columns[j].Contains(board[i][j]) ||
                    squares[(i/3, j/3)].Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {

                
                        rows[i].Add(board[i][j]);
                        columns[j].Add(board[i][j]);
                        squares[(i/3,j/3)].Add(board[i][j]);
                    }
            }
        }
        return true;
    }
}
