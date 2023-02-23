namespace EmpWageComputationWithOops
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            MultipleCompanies Company = new MultipleCompanies();

            Company.calculateWage("StarBucks", 15, 20, 60);

            Company.calculateWage("Apple", 25, 22, 70);


        }
    }
}
    
