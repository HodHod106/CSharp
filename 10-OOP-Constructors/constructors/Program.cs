using System.Security.Principal;

namespace constructors{
    class Program{
        public static void Main(string[] args)
        {
            Date d = new Date(29,2,200);
            System.Console.WriteLine(d.GetDate());


            // object intializer
            Employee e1 = new Employee{
                Id = 999,
                FName = "AHmed",
                LName = "abslam"
            };
            Employee e2 = new Employee(1000){
                FName = "Blablablabla",
                LName = "Blablalalbla"
            };

            System.Console.WriteLine(e2.dispalyName());

            PrivateCtor p = PrivateCtor.Create(1009,"ALi","Walid");
            System.Console.WriteLine(p.dispalyName());


        }
    }

    class Date{

        // readonly -> add layer of security
        // it can be changed only in constructor 

                                      // 0  1  2  3  4  5  6  7  8  9 10 11 12
        private readonly int[]days365 = [0,31,28,31,30,31,30,31,31,30,31,30,31];
        private readonly int[]days366 = [0,31,29,31,30,31,30,31,31,30,31,30,31];

        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;

        // adding constructor
        public Date(int day, int month, int year){

            bool isleap = (year%4==0 && (year%100!=0) ||(year%400==0));

            int []days = isleap?days366:days365;

            if((year>=1 && year<=9999) && (month>=1 && month<=12) && (day>=1 && day<=days[month])){
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        // constructore oveloading and chaning
        public Date(int year): this(01,01,year){} // 
        public Date(int month,int year): this(01,month,year){} // 



        public string GetDate(){
            return $"{day.ToString().PadLeft(2,'0')}-{month.ToString().PadLeft(2,'0')}-{year.ToString().PadLeft(4,'0')}";
        }
    }

    class Employee{
        public int Id;
        public string FName = "";
        public string LName = "";

        public Employee(int id){
            Id = id;    
        }
        public Employee()
        {
            
        }

        public string dispalyName(){
            return $"Id : {Id}\t Name: {FName} {LName}";
        }

    }

        class PrivateCtor{
        
            private readonly int id;
            private readonly string fname = "";
            private readonly string lname = "";

  
            private PrivateCtor(int id,string fname, string lname){
                this.id = id;
                this.fname = fname;
                this.lname = lname;
            }

            public static PrivateCtor Create(int id,string fname, string lname)
            {
                return new PrivateCtor(id,fname,lname);
            }

            public string dispalyName(){
            return $"Id : {id}\t Name: {fname} {lname}";
        }
    }

}