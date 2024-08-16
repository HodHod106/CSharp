// See https://aka.ms/new-console-template for more information

// Declaration
int num;

// assigment
num = 5;
System.Console.WriteLine(num);

// Intailization
int num2 = 10;
System.Console.WriteLine(num2);


// string refrence type
string s1 = "Hodhod"; // s1  --->  HodHod
string s2 = "Sherif";

// regular concatination
string s3 = s2 + ' ' + s1;
System.Console.WriteLine(s3);

// string interpolation
string s4 = $"{s2} {s1}";
System.Console.WriteLine(s4);


// int min & max value
// System.Console.WriteLine($"int min {int.Min}, max {int.Max}");


// var keyword "like auto c++" (specify the datatype from the first assigment only, it meand you can not assign diffret datatype to it) (compile time)
// characters in tokens means suffix to define the token datatype

var s = "Hodhod";   // string 
var f = 0f;         // float
var dd = 0d;        // double
var m = 0.1m;       // decimal
var l = 5l;         // long
var u = 56u;        // unsigned int
var ul = 6553ul;    // insigned long

// ul = 0f; // error -> diffrent datatype


// you can separe numbers with (_)
int oneMillion = 1_000_000;

System.Console.WriteLine(oneMillion);

// dynamic keyword (specify the datatype from the value assinded any time, you can value datatype also)(run time)
// characters in tokens means suffix to define the token datatype

dynamic x = 10;
System.Console.WriteLine(x);
x = "abcd";
System.Console.WriteLine(x);


// char (letter datatype )
char c = 's';
System.Console.WriteLine(c);


object o = "sss"; // object datatype and you can change the datatype
System.Console.WriteLine(o);
o = 5;
System.Console.WriteLine(o);