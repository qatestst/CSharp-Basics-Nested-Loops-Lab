namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "";

            while (true)
            {
                double savedMoney = 0;
                string neededMoney = "";

                country = Console.ReadLine();

                if (country == "End")
                { break; }

                neededMoney = Console.ReadLine();
                if (neededMoney == "End")
                { break; }
                double amount = 0;


                double neededMoneyParse = double.Parse(neededMoney);

                while (savedMoney < neededMoneyParse)
                {

                    amount = double.Parse(Console.ReadLine());
                    savedMoney += amount;
                    if (savedMoney >= neededMoneyParse)
                    { Console.WriteLine($"Going to {country}!"); }

                }
            }
        }
    }
}