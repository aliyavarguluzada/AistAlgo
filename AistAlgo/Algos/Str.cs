namespace AistAlgo.Algos
{
    public static class Str
    {
        public static string Check(string sentence)
        {
            // sa sss ssssss ss ssssssssss
            string sentenceTrimmed = sentence.Trim();

            string[] StringArray = sentenceTrimmed.Split(" ").ToArray();



            Console.WriteLine(StringArray.Max());
            Console.WriteLine(StringArray.Min());


            return String.Empty;
        }
    }
}
