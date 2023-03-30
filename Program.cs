namespace ReducingDishes
{
    internal class Program
    {
        private class ReducingDishes
        {
            public int MaxSatisfaction(int[] satisfaction)
            {
                Array.Sort(satisfaction);
                int[,] dp = new int[satisfaction.Length + 1, satisfaction.Length + 2];
                for(int i = satisfaction.Length - 1; i >= 0; --i)
                {
                    for(int j = 1; j <= satisfaction.Length; ++j)
                    {
                        dp[i, j] = Math.Max(satisfaction[i] * j + dp[i + 1, j + 1], dp[i + 1, j]);
                    }
                }
                return dp[0, 1];
            }
        }
        static void Main(string[] args)
        {
            ReducingDishes reducingDishes = new();
            Console.WriteLine(reducingDishes.MaxSatisfaction(new int[] { -1, -8, 0, 5, -9 }));
            Console.WriteLine(reducingDishes.MaxSatisfaction(new int[] { 4, 3, 2 }));
            Console.WriteLine(reducingDishes.MaxSatisfaction(new int[] { -1, -4, -5 }));
        }
    }
}