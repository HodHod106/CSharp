// Precedence and order of evaluation
// https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170

// Primary EXpressions (exression that return a value)
// like 

using System.Collections;
using System.Threading.Tasks.Dataflow;

var amout = Math.Cos(30)+1;  // Math. -> member lookup          ->.cos -> method call that return something (double in this example)
    Console.WriteLine(amout);    // COnsle.WrireLine                -> like the aboove but it not return anything (type void)
    System.Console.WriteLine("*****************************************************************");

// Binary Operation (+,-,*,/,%) it require two operands
// Computaions occurs from left to right or (prioretiy)
// -> () , * / %,  + -
    System.Console.WriteLine(8/5);
    System.Console.WriteLine(8*5);
    System.Console.WriteLine(8+5);
    System.Console.WriteLine(8-5);
    System.Console.WriteLine(8%5);
    System.Console.WriteLine("*****************************************************************");

// assignment operator (right to left)
    string s1 = "";
    string s2 = "";
    string s3 = s2 = s1 = "Value";
    System.Console.WriteLine(s1);
    System.Console.WriteLine(s2);
    System.Console.WriteLine(s3);
    System.Console.WriteLine("*****************************************************************");

// Null Checking
    string s = null;
    s = s ?? "IS NULL CHECK"; // ?? -> is null checker >> if(s == null) c = "IS NULL CHECK"
    System.Console.WriteLine(s);

    s = s ?? "somethig"; // ?? -> is null checker >> if(s == null) c = "IS NULL CHECK"
    System.Console.WriteLine(s);
    System.Console.WriteLine("*****************************************************************");

// Null conditioning
    String str = null;
    str = str?.ToUpper(); // معناها لو مش بنل حولها لكن لو بنل خليها نل
    str = (str is null ? null : "NOT NULL"); // THE SMAE ABOVE
    System.Console.WriteLine(str); // Print nothing
System.Console.WriteLine("*****************************************************************");


// if else statemnet
    int number = 5;

    if (number > 10)
    {
        Console.WriteLine("The number is greater than 10.");
    }
    else if (number > 5)
    {
        Console.WriteLine("The number is greater than 5 but less than or equal to 10.");
    }
    else
    {
        Console.WriteLine("The number is 5 or less.");
    }
System.Console.WriteLine("*****************************************************************");


// switch statemnet
    int day = 3;
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid day");
            break;
    }
System.Console.WriteLine("*****************************************************************");

// If you want to group cases together, you can omit the break:


int weekDay = 2;

switch (weekDay)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("It's a weekday.");
        break;
    case 6:
    case 7:
        Console.WriteLine("It's the weekend.");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

System.Console.WriteLine("*****************************************************************");

// In Csharp you can switch on types also
object o = 5; // you can use dynamic also
switch(o){
    case string ss:
        System.Console.WriteLine($"It's a string, {ss.ToUpper()}");
        break;
    case int i:
        System.Console.WriteLine($"It's an intger, square of {i} = {i*i}");
        break;
    case double:
        System.Console.WriteLine("It's a double");
        break;
}
System.Console.WriteLine("*****************************************************************");


// bool isVIP = true;
// switch(isVIP){
//     case bool i when i == true:
//         System.Console.WriteLine("yes");
//         break;
//     case bool:
//     System.Console.WriteLine("no");
//     break;
// }


// switch allows you to assign a value to a variable based on a pattern matching operation.

int cardNum = 10;
string cardName = cardNum switch{
    1 => "Ace",
    11 => "Jack",
    12 => "Queen",
    13 => "King",
    _ => cardNum.ToString()
};
System.Console.WriteLine("card name: "+cardName);
    System.Console.WriteLine("==============");


// LOOPS

// while -> The while loop continues to execute a block of code as long as the specified condition is true.
    int counter = 0;
    while (counter < 5)
    {
        Console.WriteLine($"i = {counter}");
        counter++;
    }
    System.Console.WriteLine("==============");
// Do While -> The do-while loop is similar to the while loop, but it guarantees that the code block is executed a
            // at least once, as the condition is evaluated after the block has been executed.
    counter = 0;
    do
    {
        Console.WriteLine($"j = {counter}");
        counter++;
    } while (counter < 5);
    System.Console.WriteLine("==============");


// Jump statements in C# are used to alter the flow of control in a program. The main jump statements in C# are:
    // break
    // continue
    // return
    // goto
    // throw