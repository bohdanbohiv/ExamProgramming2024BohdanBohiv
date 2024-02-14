namespace Utilities
{
    public static class StringUtilities
    {
        public static int LongWordsCount(string str) =>
            str.Split(' ').Where(word => word.Length > 2).Count();
        public static string ToSpinalCase(string str) =>
            string.Join('-', str.ToLower().Split(' '));
        public static string ToPascalCase(this string str) =>
            string.Join("", str.ToLower().Split(' ').Select(word => word[0].ToString().ToUpper() + word[1..]));
    }
}
