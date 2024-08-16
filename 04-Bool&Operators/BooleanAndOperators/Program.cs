// See https://aka.ms/new-console-template for more information

// bool ooerator
bool isvip = true; // true or false;

var x = 10;
var y = 10;

System.Console.WriteLine(x==y); // True

var z = (x==y); 
System.Console.WriteLine(z); // True

// comparison operators
var total = 1000;
var threshold = 900;
var vip = total>=threshold; // >= <= > < ==
System.Console.WriteLine(vip);

// negation (!)
bool trF = true;
trF = !trF;
System.Console.WriteLine(trF);

// conditional operators (&&,||,^) 
// it is also called short circut opearatoras casue it if the part of the coditon gave a result it does not complete the condtion


var GPA = 3.8;

bool checkerTrue = GPA>=3 && vip; // true;
bool checkerGalse = GPA>=4 || vip; // true; 
// other you can try other operators in the same way

// bitwise operators 
// [&,|] 



var s1 = "hello";
var s2 = "hello";
System.Console.WriteLine(s1==s2);

// Ternary operator
var a = 100;
var b = 190;
var bigger = a>=b?true:false; // false;
