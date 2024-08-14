namespace MyLeetcode.Trie
{
    internal static class _0212_WordSearchII
    {
        public static IList<string> Run(char[][] board, string[] words)
        {
            HashSet<string> ans = new HashSet<string>();
            Node trie = new Node();
            foreach (var str in words)
            {
                trie.Insert(str);
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    DFS(board, i, j, trie, ans);
                }
            }

            return ans.ToList();
        }

        private static (int, int)[] Dir = new (int, int)[]
        {
            (-1, 0), (0, 1), (1, 0), (0, -1),
        };
        private static void DFS(char[][] board, int row, int col, Node node, HashSet<string> ans)
        {
            char c = board[row][col];
            if (!node.Next.TryGetValue(c, out Node child))
            {
                return;
            }
            if (child.Word != null)
            {
                ans.Add(child.Word);
                child.Word = null;
            }
            node = child;

            board[row][col] = '#';
            foreach (var dir in Dir)
            {
                int nRow = row + dir.Item1;
                int nCol = col + dir.Item2;
                if (nRow < 0 || nRow >= board.Length
                 || nCol < 0 || nCol >= board[0].Length)
                {
                    continue;
                }
                DFS(board, nRow, nCol, node, ans);
            }
            board[row][col] = c;
        }

        public class Node
        {
            public string Word;
            public Dictionary<char, Node> Next = new Dictionary<char, Node>();

            public void Insert(string word)
            {
                Node cur = this;
                foreach (char c in word)
                {
                    if (!cur.Next.TryGetValue(c, out Node node))
                    {
                        node = new Node();
                        cur.Next.Add(c, node);
                    }
                    cur = node;
                }
                cur.Word = word;
            }
        }
    }
}
