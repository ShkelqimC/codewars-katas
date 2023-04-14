









Console.WriteLine(CountSheep(4));

//Create Phone Number 6kyu
//https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp 

string CreatePhoneNumber(int[] numbers)
{

    return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}";
}



//Find the index of the second occurrence of a letter in a string
//https://www.codewars.com/kata/63f96036b15a210058300ca9/train/csharp
static int SecondSymbol(string str, char symbol)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == symbol) count++;

        if (count == 2) return i;
    }


    return -1;
}

//Third Angle of a Triangle 8kyu
//https://www.codewars.com/kata/5a023c426975981341000014/train/csharp
static int OtherAngle(int a, int b)
{
    return 180 - a - b;
}

//Function 2 - squaring an argument 8kyu
//https://www.codewars.com/kata/523b623152af8a30c6000027/train/csharp
static double Square(double a)
{
    return a * a;
}
//The Feast of Many Beasts 8kyu
//https://www.codewars.com/kata/5aa736a455f906981800360d/train/csharp
static bool Feast(string beast, string dish)
{
    return (beast[0] == dish[0] && beast[beast.Length-1] == dish[dish.Length-1]);
}

//If you can't sleep, just count sheep!! 8kyu
//https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/train/csharp
static string CountSheep(int n)
{
    var res = "";
    for (int i = 1; i <= n; i++)
    {
        res += $"{i} sheep...";

    }
    return res;
}
