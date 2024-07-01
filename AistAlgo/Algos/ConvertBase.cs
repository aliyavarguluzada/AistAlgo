namespace AistAlgo.Algos
{
    public static class ConvertBase
    {

        public static int Convert(int number)
        {


            int remainder;

            List<int> list = new List<int>();


            while (number >= 2)
            {
                remainder = number % 2;
                number = number / 2;

                list.Add(remainder);
            }
            if (number == 1)
                list.Add(1);

            list.Reverse();

            foreach (int i in list)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            return 0;
        }


        public static double ToBase10(int number)
        {
            int remainder;

            List<int> a = new List<int>();

            for (int i = 0; i <= number; i++)
            {


                remainder = number % 10;
                number = number / 10;

                a.Add(remainder);

                if (number == 1 || number == 0)
                {
                    a.Add(number);
                }
            }

            double sum = 0;

            for (int i = 0; i < a.Count; i++)
            {
                sum = sum + (a[i] * Math.Pow(2, i));

            }

            Console.WriteLine(sum);
            return sum;
        }

    }
}
