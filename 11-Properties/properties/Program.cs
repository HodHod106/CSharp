using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace properties{
    class Program{
        public static void Main(string[] args)
        {
            Dollar d = new Dollar(1.99m);
            d.setAmount(1.66m);
            System.Console.WriteLine(d.Amount);

            
        }
    }

    class Dollar{
        private decimal amount;

        public Dollar(decimal amount){
            this.amount = ProcessValue(amount);
        }

        // adding property
        // internally (clr)-> it converted to setter and getter 
        // public decimal Amount{
        //     get{
        //         return this.amount;
        //     }
        //     // if you delete the set part
        //     // now it becomes readonly property
        //     private set{
        //         this.amount = ProcessValue(value);
        //     }
        // }


        // if you have property like this (return a value and set a value without any validation you can use insteed automaic prop)
        // public decimal Amount{
        //     get{
        //         return this.amount;
        //     }
        //     // if you delete the set part
        //     // now it becomes readonly property
        //     private set{
        //         this.amount = value;
        //     }

        // }

        public decimal Amount { get; set; }
        public void setAmount(decimal val){Amount = val;}

        // public decimal ConversionFactor {get;set;} = 1.99m; // get for reading and set for writing, if you want only one you can delete the other


        // validation
        private decimal ProcessValue(decimal val) => val<=0? 0 : Math.Round(val,2);
    }
}