using System.Linq.Expressions;

namespace Methods{
        class Program{
                public static void Main(string[] args)
                {
                        Demo d = new Demo();
                        d.doSomething();
                        var IntTypeValue = 10 + d.IntType();
                        System.Console.WriteLine("Primary Type -> " + IntTypeValue);

                        var age = 18;
                        d.returnAgePassByValue(age); // age -> argument
                        System.Console.WriteLine("passe by value -> " + age); // print 18 << passed by value 
                        // if you wanna make changes on the value itself, it must passed by refrence 
                        // so use the keyword ->ref or out

                        // to use ref -> arguments must be intialized 

                        d.returnAgePassByREfrence(ref age);
                        System.Console.WriteLine("passe by refrence -> " + age);

                        // you can use also the key word (out), value must not be intialized
                        // but it must initailized on the method itself


                        int dd;
                        d.returnAgePassByREfrenceOutVersion(out dd);
                        System.Console.WriteLine(dd);

                        // real example on (out);

                        int number;
                        string strNumber = "1000";
                        if(int.TryParse(strNumber,out number)){
                                System.Console.WriteLine("valid number -> " + (number + 5));
                        }else{
                                System.Console.WriteLine("Invalid Number");
                        }


                        
/// <summary>
/// Method Overloading
/// </summary>
                        System.Console.WriteLine("=============================");
                        OverLoading o = new OverLoading();
                        o.promote(999);
                        o.promote(500,"Egypt");
                        o.promote(400,"USA","Helton");


                        /// <summary>
                        /// Expression bodied method
                        /// </summary>
                        System.Console.WriteLine("=============================");
                        ExrepressionBodiedMethods e = new ExrepressionBodiedMethods();
                        System.Console.WriteLine(e.isEven(6));
                        System.Console.WriteLine(e.isEven(7));

                        // local bodied method
                        int []arr = {1,2,3,4,5,6,7,8,9};
                        e.printOdd(arr);
                        System.Console.WriteLine("\n=============================");

                        // enhancing 
                        // to use the methods by class name rather than onject 
                        // you can implent it as static

                        StaticTest.printOdd(arr);
                        System.Console.WriteLine();



                } 
        }


        internal class Demo{

                // void type (do not have return)
                public void doSomething(){
                        System.Console.WriteLine("do Something...");
                }

                // Primary type(int, double, .....) (mast have return)
                public int IntType(){
                        return 10 + 5;
                }

                // pass by value
                // parameters 
                public int returnAgePassByValue(int age){
                        age += 3;
                        return age;
                }

                public int returnAgePassByREfrence(ref int age){
                        age +=3;
                        return age;
                }

                public int returnAgePassByREfrenceOutVersion(out int age){
                        age = 51; // it must be assigned even the parameter has a value
                        age+=1;
                        return 5 + age;
                }
        }

        internal class OverLoading{
                public void promote(double amount){
                        System.Console.WriteLine($"YOU HAVE GOT A PROMOTION = ${amount}");
                }
                public void promote(double amount,string trip){
                        System.Console.WriteLine($"YOU HAVE GOT A PROMOTION = ${amount}, and a trip to {trip}");
                }
                public void promote(double amount,string trip, string hotel){
                        System.Console.WriteLine($"YOU HAVE GOT A PROMOTION = ${amount}, and a trip to {trip}, in a hotel called {hotel}");
                }
        }

        internal class ExrepressionBodiedMethods{
                // stntax fun => exression(must be in one statment)
                public bool isEven(int n) => n%2==0;

                // local method in a method

                public void printOdd(int []numbers){
                        foreach(var i in numbers){
                                if(isOdd(i)) System.Console.Write(i + " ");
                        }
                        bool isOdd(int n) => n%2==1; // this method can be seen only inside peintOdd
                }
        }

        internal class StaticTest{
                 public bool isEven(int n) => n%2==0;

                // local method in a method

                public static void printOdd(int []numbers){
                        foreach(var i in numbers){
                                if(isOdd(i)) System.Console.Write(i + " ");
                        }
                        bool isOdd(int n) => n%2==1;    // this method can be seen only inside peintOdd
                                                        // if you use this from outside this method, it must be static as well
                }
        }
}