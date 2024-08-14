using MyLeetcode.Trie;

namespace MyLeetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[]{'o','a','a','n'},
                new char[]{'e','t','a','e'},
                new char[]{'i','h','k','r'},
                new char[]{'i','f','l','v'},
            };
            string[] words = new string[]
            {
                "eat","oath","pea","rain",
            };
            var list = _0212_WordSearchII.Run(board, words);
            foreach (var word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}