namespace AistAlgo.Algos
{
    public static class MostRepeatedNumber
    {
        public static int Repeated(int[] arr)
        {
            // [1, 2, 3, 3, 4, 2, 3, 3, 3, 4];


            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {


                    if (!keyValuePairs.ContainsKey(arr[i]))
                    {
                        keyValuePairs.Add(arr[i], 1);

                    }
                    else if (arr[i] == arr[j])
                        keyValuePairs[arr[i]]++;


                }

            }


            var maxValueKey = keyValuePairs.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;


            return maxValueKey;
        }
    }
}
