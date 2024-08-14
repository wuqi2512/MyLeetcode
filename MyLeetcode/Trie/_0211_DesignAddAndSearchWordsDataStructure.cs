namespace MyLeetcode.Trie
{
    internal class _0211_DesignAddAndSearchWordsDataStructure
    {
        public class WordDictionary
        {
            private class Node
            {
                public bool Value;
                public Node[] Next = new Node[26];
            }

            private Node root;

            public WordDictionary()
            {
                root = new Node();
            }

            public void AddWord(string word)
            {
                Node cur = root;
                foreach (char c in word)
                {
                    int index = c - 'a';
                    if (cur.Next[index] == null)
                    {
                        cur.Next[index] = new Node();
                    }
                    cur = cur.Next[index];
                }
                cur.Value = true;
            }

            public bool Search(string word)
            {
                return Search(root, word, 0);
            }

            private bool Search(Node node, string word, int index)
            {
                Node cur = node;
                if (index == word.Length)
                {
                    return cur.Value;
                }

                char c = word[index];
                if (c == '.')
                {
                    foreach (Node n in cur.Next)
                    {
                        if (n != null && Search(n, word, index + 1))
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    cur = cur.Next[c - 'a'];
                    if (cur != null)
                    {
                        return Search(cur, word, index + 1);
                    }
                }

                return false;
            }
        }
    }
}
