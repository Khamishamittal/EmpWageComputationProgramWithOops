namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            AddPartTime check = new AddPartTime(); 
            check.CalculatePartime();
        }
    }
}