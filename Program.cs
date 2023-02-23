namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            IComputeEmgWage wageBuilder = new EmpWageBuilder();

            wageBuilder.addCompanyEmpWage("MICROSOFT", 20, 5, 20);
            wageBuilder.addCompanyEmpWage("GOOGLE", 18, 4, 23);
            wageBuilder.computeEmpWage();
        }
    }
    }
