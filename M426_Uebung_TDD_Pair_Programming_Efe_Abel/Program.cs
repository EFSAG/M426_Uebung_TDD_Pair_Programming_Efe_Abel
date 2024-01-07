namespace M426_Uebung_TDD_Pair_Programming_Efe_Abel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new StringCalculator();

            try
            {
                int result = calculator.Add();
                Console.WriteLine($"Die Summe ist: {result}");
                Console.WriteLine($"Die Add Methode wurde {calculator.CalledCount} mal aufgerufen.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}