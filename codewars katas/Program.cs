



var one = new List<int>() { 1, 1, 1, 2, 1, 1, 1 };

Console.WriteLine(GetUnique(one));



Console.WriteLine(Calculator(".... // .."));
//Find the unique number 6kyu
//https://www.codewars.com/kata/585d7d5adb20cf33cb000235
int GetUnique(IEnumerable<int> numbers)
{
    foreach (var item in numbers)
    {
        var count = numbers.Count(x => x == item);
        if (count == 1) return item;

    }
    return 1;
}

//Create Phone Number 6kyu
//https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp 

string CreatePhoneNumber(int[] numbers)
{

    return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}";
}

//Dot Calculator
//https://www.codewars.com/kata/6071ef9cbe6ec400228d9531/train/csharp
string Calculator(string txt)
{
    string[] symbols = new[] { "+", "-", "*", "/" };
    string sym = "";
    foreach (var s in symbols)
     {
        var index = txt.IndexOf(s);

        if (index >= 0) sym = s;
    }
    var split = txt.Split(sym);
    var count = 0;
    switch (sym)
    {
        case "+":
            count = split[0].Length - 1 + split[1].Length - 1;
            break;
        case "-":
            count = (split[0].Length - 1) - (split[1].Length - 1);
            break;
            case "*":
            count = (split[0].Length - 1) * (split[1].Length - 1);
            break;
            case "/":
            count = (split[0].Length - 1) / (split[2].Length - 1);
            break;
        default:
            break;
    }
    var res = "";
    if(count > 0)
    {

    for (int i = 0; i < count; i++)
    {
        res += ".";
    }
    }

    return res;
}

//Power of two 7kyu
//https://www.codewars.com/kata/534d0a229345375d520006a0/train/csharp
static bool PowerOfTwo(int n)
{
    return (n & (n - 1)) == 0;
}

//Exclamation marks series #7: Remove words from the sentence if it contains one exclamation mark 7kyu
//https://www.codewars.com/kata/57fafb6d2b5314c839000195/train/csharp
static string Remove(string s)
{
    var res = "";
    var split = s.Split(' ');

    foreach (var i in split)
    {
        var count = i.Count(k => (k == '!'));

        if (count != 1) res += " " + i;
    }
    if (res.Length > 1)
        res = res.Remove(0, 1);


    return res;
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
