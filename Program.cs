namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
          

            EmpWageBuilder Samsung = new EmpWageBuilder("SAMSUNG", 20, 5, 25);
            EmpWageBuilder Apple = new EmpWageBuilder("APPLE", 16, 6, 20);

            Samsung.computeEmpWage();
            Console.WriteLine(Samsung.toString());
            Apple.computeEmpWage();
            Console.WriteLine(Apple.toString());
        }
    }
    }
