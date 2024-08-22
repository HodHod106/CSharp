
namespace filedsAndConstant.Employee{
    public class Employee{

        // constant
        public const double TAX = 0.03;

        // fields
        public string FName = "No Name";
        public string LName = "No Name";
        public double Wage;
        public double LoggedHours;


        private double CalculateSalary() => Wage*LoggedHours;
        private double CalculateTax() => CalculateSalary()*TAX;

        private double CalculateNetSalary() => CalculateSalary()-CalculateTax();

        public string print(){
            return $"Fist Name: {FName},\t" + 
                    $"Last Name: {LName},\t" + 
                    $"Wage: {Wage}, \t" + 
                    $"Logged Hours: {LoggedHours},\n" + 
                    $"Salary: {CalculateSalary()},\t" + 
                    $"TAX: {CalculateTax()}\t" + 
                    $"Net Salary: {CalculateNetSalary()}\n" ;
            }

    }
}