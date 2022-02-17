namespace ThirdQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = word.Length;
            int sum = 0;
            int verify = 0;
            int pair1 = 0;
            int pair2 = 0;

            for (int charnum = 1; charnum <= n - 1; charnum++)
            {
                for (pair1 = 0; pair1 <= n - 1; pair1++)
                {
                    for (pair2 = n - 1; pair2 >= 0; pair2--)
                    {
                        if (pair1 + charnum <= n && pair2 + charnum <= n && pair2 > pair1)
                        {
                            string word1 = word.Substring(pair1, charnum);
                            string word2 = word.Substring(pair2, charnum);
                            char[] char1 = word1.ToCharArray();
                            char[] char2 = word2.ToCharArray();

                            verify = 0;
                            foreach (char c in char1)
                            {
                                int block = 0;
                                for (int i = 0; i < charnum; i++)
                                {
                                    if (c == char2[i] && block == 0)
                                    {
                                        verify++; block++; char2[i] = '\0';
                                    }
                                }
                            }
                            if (verify == charnum)
                            {
                                sum++; Console.WriteLine($"pares: {word1} e {word2}");
                            }

                        }
                    }

                }

            }
            Console.WriteLine(sum);
        }
    }
}