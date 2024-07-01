namespace AistAlgo.Algos
{
    public static class MostRepeatedNumber
    {
        public static int Repeated(int[] arr)
        {
            // [1, 2, 3, 3, 4, 2, 3, 3, 3, 4];


            Dictionary<int, int> b = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {


                    if (!b.ContainsKey(arr[i]))
                    {
                        b.Add(arr[i], 1);

                    }
                    else if (arr[i] == arr[j])
                            b[arr[i]]++;


                }

            }


            var maxValueKey = b.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;


            return maxValueKey;
        }
    }
}
