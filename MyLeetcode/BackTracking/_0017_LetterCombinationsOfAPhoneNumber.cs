using System.Text;

namespace MyLeetcode.BackTracking
{
    internal static class _0017_LetterCombinationsOfAPhoneNumber
    {
        public static IList<string> Run(string digits)
        {
            List<string> list = new List<string>();
            if (digits.Length == 0)
            {
                return list;
            }

            Dictionary<char, string> dic = new Dictionary<char, string>()
            {
                {'2', "abc" },
                {'3', "def" },
                {'4', "ghi" },
                {'5', "jkl" },
                {'6', "mno" },
                {'7', "pqrs" },
                {'8', "tuv" },
                {'9', "wxyz" },
            };
            StringBuilder sb = new StringBuilder();
            _0017_BackTrack(dic, list, digits, 0, sb);

            return list;
        }

        private static void _0017_BackTrack(Dictionary<char, string> dic, List<string> list, string digits, int index, StringBuilder sb)
        {
            if (index == digits.Length)
            {
                list.Add(sb.ToString());
                return;
            }

            string str = dic[digits[index]];
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[i]);
                _0017_BackTrack(dic, list, digits, index + 1, sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
