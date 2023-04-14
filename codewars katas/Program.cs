

var hej = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

Console.WriteLine(CreatePhoneNumber(hej));

//Create Phone Number 6kyu
//https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp 

string CreatePhoneNumber(int[] numbers)
{

    return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}";
}

//Third Angle of a Triangle 8kyu
//https://www.codewars.com/kata/5a023c426975981341000014/train/csharp
static int OtherAngle(int a, int b)
{
    return 180 - a - b;
}

//Function 2 - squaring an argument
//https://www.codewars.com/kata/523b623152af8a30c6000027/train/csharp
static double Square(double a)
{
    return a * a;
}