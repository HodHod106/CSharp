
// single dim. array 

/*Initalization v1*/
// string[] freinds = new string[5] {
//     "ali",
//     "mohammed",
//     "mahmoud",
//     "abdo",
//     "ahmed"
// };

/*Initalization v2*/
// string[] freinds = {
//     "ali",
//     "mohammed",
//     "mahmoud",
//     "abdo",
//     "ahmed"
// };

/*Initalization v3 (prefered)*/
string[] freinds = new string[5];
// var freinds = new string[5]; // you can use tis also
freinds[0] = "ali";
freinds[1] = "mohammed";
freinds[2] = "mahmoud";
freinds[3] = "abdo";
freinds[4] = "ahmed";

System.Console.Write('{');
for(int it = 0 ; it < freinds.Length - 1;it++){
    System.Console.Write(freinds[it] + ", ");
}
System.Console.WriteLine(freinds[freinds.Length-1] + "}");
System.Console.WriteLine("***********************************");



// Mulit dim. array (rectangular arrary)
// Step 1: Define a 2D array with 3 rows and 4 columns
    int[,] array2D = new int[,]
    {
        { 1, 2, 3, 0 },  // Row 0
        { 4, 5, 0, 0 },  // Row 1
        { 6, 7, 8, 9 }   // Row 2
    };

    // Step 2: Print the 2D array
    for (int i = 0; i < array2D.GetLength(0); i++)  // Iterate over rows
    {
        for (int j = 0; j < array2D.GetLength(1); j++)  // Iterate over columns
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.WriteLine(); // Move to the next line after each row
    }
System.Console.WriteLine("***********************************");
// not: the function testMulti.Length in 2D array will return the mul. of rows*col like in this example returns (3*5=15)

// jagged array (like array of arrays in c++)
    int[][] jaggedArray = new int[3][];

    // Step 2: Initialize each row with different lengths
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5 };
    jaggedArray[2] = new int[] { 6, 7, 8, 9 };

    // Step 3: Print the jagged array
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
        Console.WriteLine(); // Move to the next line after each row
    }
// not: the function jaggedArray.Length in jagged array will return numbers of rows only like here in returns 3


// ranges and indices 

        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        // Accessing a range of elements using the range operator (..)
        int[] middle = numbers[2..5];   // Gets elements from index 2 to 4 (30, 40, 50)
        int[] fromStart = numbers[..3];  // Gets elements from start to index 2 (10, 20, 30)
        int[] toEnd = numbers[7..];      // Gets elements from index 7 to the end (80, 90, 100)
        int[] fullRange = numbers[..];   // Gets the full array (10, 20, ..., 100)

        // Accessing a single element using the Index structure
        int lastElement = numbers[^1];   // Gets the last element (100)
        int secondLastElement = numbers[^2]; // Gets the second last element (90)

        // Print the results
        PrintArray("Middle elements (2..5): ", middle);
        PrintArray("From start (..3):", fromStart);
        PrintArray("To end (7..):", toEnd);
        PrintArray("Full range (..):", fullRange);
        Console.WriteLine("Last element (^1): " + lastElement);
        Console.WriteLine("Second last element (^2): " + secondLastElement);

    static void PrintArray(string description, int[] array)
    {
        Console.Write(description);
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    