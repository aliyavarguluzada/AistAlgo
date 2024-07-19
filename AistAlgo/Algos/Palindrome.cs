namespace AistAlgo.Algos
{
    public static class Palindrome
    {
        public static bool IsPalindrome(int number)
        {

            // 121
            int temp = number;

            int remainder = 0;

            int sum = 0;

            while (number > 0)
            {
                remainder = number % 10;

                sum = sum * 10 + remainder;

                number = number / 10;
            }

            if (temp == sum)
                return true;

            return false;
        }


        public static bool IsPalindrome(string word)
        {

            char[] chars = word.ToCharArray();

            int start = 0;
            int end = chars.Length - 1;

            bool a = false;

            while (start < end)
            {
                if (chars[start] == chars[end])
                {
                    a = true;
                }
                else
                {
                    return false;
                }
                start++;
                end--;
            }

            return a;

        }
    }
}
