using filedsAndConstant.Employee;

// OOP (Fields and constant)
// old school to solve a problem
/// <summary>
/// 
        // const double TAX = 0.03d;
        // Console.Write("First name: ");
        // var fName = Console.ReadLine();

        // Console.Write("Last name: ");
        // var lName = Console.ReadLine();

        // Console.Write("Wage: ");
        // var wage = Convert.ToDouble(Console.ReadLine());

        // Console.Write("LoggedHours: ");
        // var hours = Convert.ToDouble(Console.ReadLine());

        // var NetSalary = wage*hours -(wage*hours*TAX);

        // Console.WriteLine($"Fist Name: {fName}");
        // Console.WriteLine($"Last Name: {lName}");
        // Console.WriteLine($"Wage: {wage}");
        // Console.WriteLine($"Logged Hours: {hours}");
        // Console.WriteLine($"Net Salary: {NetSalary}");
/// </summary>

// note: the above program runs only for one employee
// so if we want to add other employees, you should repear them
// or use and array for each attribute 
// this is not the best practice
// so you can use OOP to solve 
// so create a class Employee COntains all common attrubutes 

Employee e1 = new Employee();
System.Console.WriteLine("Enter the data of the first employee: ");
Console.Write("First name: ");
e1.FName = Console.ReadLine()??"";

Console.Write("Last name: ");
e1.LName = Console.ReadLine()??"";

Console.Write("Wage: ");
e1.Wage = Convert.ToDouble(Console.ReadLine());

Console.Write("Logged Hourse: ");
e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

// so if you want to add other employees you can create another instance 
// but a better way you can create array of Employees
// like
Employee []emps = new Employee[2];
emps[0] = e1;
emps[1] = new Employee();

System.Console.WriteLine("Enter the data of the second employee: ");
Console.Write("First name: ");
emps[1].FName = Console.ReadLine()??"";

Console.Write("Last name: ");
emps[1].LName = Console.ReadLine()??"";

Console.Write("Wage: ");
emps[1].Wage = Convert.ToDouble(Console.ReadLine());

Console.Write("Logged Hourse: ");
emps[1].LoggedHours = Convert.ToDouble(Console.ReadLine());


System.Console.WriteLine("***********************************************");
foreach(var emp in emps){

        var NetSalary = emp.Wage*emp.LoggedHours -(emp.Wage*emp.LoggedHours*Employee.TAX);
        Console.WriteLine($"Fist Name: {emp.FName}");
        Console.WriteLine($"Last Name: {emp.LName}");
        Console.WriteLine($"Wage: {emp.Wage}");
        Console.WriteLine($"Logged Hours: {emp.LName}");
        Console.WriteLine($"Net Salary: {NetSalary}");
        System.Console.WriteLine("==========================================");
}