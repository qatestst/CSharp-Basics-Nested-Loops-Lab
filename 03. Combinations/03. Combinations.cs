namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //x1 + x2 + x3 = n


            int sum = 0;
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {

                for (int j = 0; j <= num; j++)
                {

                    for (int k = 0; k <= num; k++)
                    {

                        if (num == i + j + k)
                        {
                            sum += 1;
                        }
                    }

                }

            }
            Console.WriteLine(sum);
        }
    }
}