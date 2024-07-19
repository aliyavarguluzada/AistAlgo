namespace AistAlgo.Algos
{
    public static class Mirror
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }


        public static int Reversed(int number)
        {
            int reversed = 0;

            int remainder = 0;

            while (number > 0)
            {
                remainder = number % 10;
                reversed = reversed * 10 + remainder;
                number = number / 10;
            }

            return reversed;
        }

        public static List<int> Mirrors()
        {
            List<int> mirrors = new List<int>();

            for (int i = 2; i < 1000; i++)
            {
                if (IsPrime(i) && IsPrime(Reversed(i)))
                {
                    mirrors.Add(i);
                }
            }
            return mirrors;
        }
    }
}
