namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            CalculateForAMonth check = new CalculateForAMonth();
            check.Calculate();
        }
    }
}