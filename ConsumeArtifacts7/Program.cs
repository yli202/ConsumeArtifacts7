namespace ConsumeArtifacts7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo consume Azure artifact");

            AlgebraClassLibrary.Algebra algebra = new AlgebraClassLibrary.Algebra();

            Console.WriteLine($"10+10={algebra.Addition(10, 10)}");
        }
    }
}