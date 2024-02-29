namespace CleanCodeChapter7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            MetricsCalculator metricsCalculator = new MetricsCalculator();
            Point p1 = new Point(1.2, 1.5);
            Point p2 = new Point(2.3, 2.7);

            Console.WriteLine($"Metodekall der p1 og p2 har verdier: {metricsCalculator.xProjection(p1, p2)}");

            p1 = null;

            //Console.WriteLine($"Metodekall der p1 er nullverdi med Assert: {metricsCalculator.xProjectionWithAssert(p1, p2)}");
            Console.WriteLine($"Metodekall der p1 er nullverdi med unntak: {metricsCalculator.xProjectionWithException(p1, p2)}");
            */

            Employee e1 = new Employee("John", 350.0);
            Employee e2 = new Employee("Per", 100.0);
            Employee e3 = new Employee("Sarah", 450.0);
            double totalPay = 0.0;

            List<Employee> employees = Employee.GetEmployees();

            
            foreach (Employee e in employees)
            {
                totalPay += e.GetPay();
            }

            Console.WriteLine($"Total pay of employees: {totalPay}");

        }
    }
}
