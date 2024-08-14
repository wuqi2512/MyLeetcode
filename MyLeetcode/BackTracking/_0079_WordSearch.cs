namespace MyLeetcode.BackTracking
{
    internal static class _0079_WordSearch
    {
        public static bool Run(char[][] board, string word)
        {
            bool[,] flags = new bool[board.Length, board[0].Length];
            char first = word[0];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (_0079_BackTracking(board, word, i, j, 0, flags))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool _0079_BackTracking(char[][] board, string word, int row, int col, int index, bool[,] flags)
        {
            if (board[row][col] != word[index])
            {
                return false;
            }
            else if (index == word.Length - 1)
            {
                return true;
            }

            flags[row, col] = true;

            // up
            if (row - 1 >= 0 && !flags[row - 1, col])
            {
                if (_0079_BackTracking(board, word, row - 1, col, index + 1, flags))
                {
                    return true;
                }
            }
            // down
            if (row + 1 < board.Length && !flags[row + 1, col])
            {
                if (_0079_BackTracking(board, word, row + 1, col, index + 1, flags))
                {
                    return true;
                }
            }
            // left
            if (col - 1 >= 0 && !flags[row, col - 1])
            {
                if (_0079_BackTracking(board, word, row, col - 1, index + 1, flags))
                {
                    return true;
                }
            }
            // right
            if (col + 1 < board[0].Length && !flags[row, col + 1])
            {
                if (_0079_BackTracking(board, word, row, col + 1, index + 1, flags))
                {
                    return true;
                }
            }

            flags[row, col] = false;

            return false;
        }
    }
}
