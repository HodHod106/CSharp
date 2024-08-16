// See https://aka.ms/new-console-template for more information

void solve(){

    string input = Console.ReadLine()??"";
    string []strArray = input.Split(' ');
    int []arr = Array.ConvertAll(strArray, int.Parse);

    Console.Write("You entered the following numbers:");
    foreach (int num in arr)
        Console.Write(num + " ");
    System.Console.WriteLine();
}


// Main
string test = Console.ReadLine()??"";
int TC = int.Parse(test);

for (int i = 0; i < TC; i++)
{
    solve();
}
