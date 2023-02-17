namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            CalculateWageTillCondition check = new CalculateWageTillCondition();
            check.EmployeeCheck();
        }
    }
}