namespace stringTransform
{
    public class Transform
    {
        public static string ToUpper(string s)
        {
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]) && char.IsLower(chars[i])) 
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }
            return new string(chars);
        }
        public static int CountSpaces(string s)
        {
            int count = 0;

            foreach (char c in s)
            {
                if (char.IsWhiteSpace(c))
                { 
                    count++;
                }
            }
            return count;
        }

    }
}