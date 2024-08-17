// Note: Every thing in dotner comes form the class object

// Type Illias

using System.Xml.Schema;

// Int16 s; // short s;
// Int32 i; // int i;
// Int64 l; // long l;
// Int128 ll; // long long ll;
// UInt16 ush; // ushort ush;
// // ....

// Implicit conversion
// For Numeric data types ينفع احط الاصغر فالاكبر
// Like

Int32 numberINt = 100;
Int64 numberLong = numberINt;       // int < long  so it is valid 


// EXplocit Casting 

// short numberSHort = numberINt;  // error cause   long > int    you must do it manually
short numberSHort = (short)numberINt;       // eXPLICIT CASTING
System.Console.WriteLine(int.MaxValue);
double d = 3.56;
System.Console.WriteLine(d);
d = (int)d;
System.Console.WriteLine(d);
System.Console.WriteLine("====================================");


// Boxing -> From value type to refrence type
int x = 10;
object obj = x;   // conversion done impilicitly (Boxing)

// UnBoxing -> From refrence type to value type
int xx = (int)obj; // conversion done explicitly (UnBoxing)



// Conversion from string to numbers

string numberStrValue = "1000";
int number = int.Parse(numberStrValue);         
System.Console.WriteLine(number);

numberStrValue = "1000z";    // // but what would happen if the number does not in the correct foramt
// number = int.Parse(numberStrValue);
// System.Console.WriteLine(number); // it will return an FormatException

numberStrValue = "99999999999";    // // but what would happen the number greater than the converted type
// number = int.Parse(numberStrValue);
// System.Console.WriteLine(number);       // System.OverflowException

// So, to solve this you can use the TtyParse Function
if(int.TryParse(numberStrValue,out number)){
    System.Console.WriteLine("Succesfully Parsed");
}else{
    System.Console.WriteLine("Faild Parsing");
}

// Convert 
// int convertNUmber = Convert.ToInt32(numberStrValue); // like the parse it will give the same exeptions, so use parse 

System.Console.WriteLine("====================================");

// Bit converter 
var numberBItVonverted = 99;
var numberBytes = BitConverter.GetBytes(numberBItVonverted);
foreach(var b in numberBytes) {
    string conv = Convert.ToString(b,2).PadLeft(8,'0');
    System.Console.WriteLine(conv);
}
System.Console.WriteLine("====================================");
// Binary cinverter
    // int convertyobinart = 10;
    // string binary = Convert.ToString(convertyobinart,16);
    // System.Console.WriteLine(binary);

    // string bin = "f";
    // int num = Convert.ToInt32(bin,16);
    // System.Console.WriteLine(num);


// string to array of char to ascii to binary 
string name = "Sherif";
char []letter = name.ToCharArray();
foreach(var c in letter){
    int ascii = Convert.ToInt32(c);
    // string bin = Convert.ToString(Convert.ToInt32(c),2).PadLeft(8,'0');
    // System.Console.WriteLine(bin);
    string output = $"{c} -> ASCII: {ascii}, \tBinary: {Convert.ToString(ascii,2).PadLeft(8,'0')},\tHex: {ascii:x}, \t Octal: {Convert.ToString(ascii,8)}";
    System.Console.WriteLine(output);

}
System.Console.WriteLine("=====================================================================================");

// reverse
var hexValues = "53 68 65 72 69 66";
string []valuse = hexValues.Split(' ');
foreach(var c in valuse) {
    int dec = Convert.ToInt32(c,16);
    System.Console.Write((char)dec);
    // another way 
    System.Console.Write(char.ConvertFromUtf32(dec)); 
}
System.Console.WriteLine();
 // from hex to decimal
 string HexVal = "8E2";
 int decVal = int.Parse(HexVal,System.Globalization.NumberStyles.HexNumber);
 System.Console.WriteLine(decVal);
 