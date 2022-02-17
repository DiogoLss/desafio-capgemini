namespace FirstQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            int[,] vs = new int[N,N];

            int x = N;
            for(int i = 0; i < N; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    if(j < x)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                x--;
                Console.WriteLine();
            }
        }
    }
}