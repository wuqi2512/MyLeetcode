namespace MyLeetcode.Trie
{
    internal class _0208_ImplementTriePrefixTree
    {
        public class Trie
        {
            private class Node
            {
                public bool Value;
                public Node[] Next = new Node[26];
            }

            private Node root;

            public Trie()
            {
                root = new Node();
            }

            public void Insert(string word)
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
                Node cur = root;
                foreach (char c in word)
                {
                    cur = cur.Next[c - 'a'];
                    if (cur == null)
                    {
                        return false;
                    }
                }

                return cur.Value;
            }

            public bool StartsWith(string prefix)
            {
                Node cur = root;
                foreach (char c in prefix)
                {
                    cur = cur.Next[c - 'a'];
                    if (cur == null)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
