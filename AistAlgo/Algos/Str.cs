namespace AistAlgo.Algos
{
    public static class Str
    {
        public static string Check(string sentence)
        {
            // sa sss ssssss ss ssssssssss
            string v = sentence = sentence.Trim();

            string[] a = v.Split(" ").ToArray();


            
            Console.WriteLine(a.Max());
            Console.WriteLine(a.Min());

          
            return String.Empty;
        }
    }
}
