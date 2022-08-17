// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a five-digit number");
int N = Convert.ToInt32(Console.ReadLine());
string numberText = N.ToString();
//string numberText = Convert.ToString(N) - верное;
//string N = Console.ReadLine(N); 
//int N = Convert.ToInt32(Console.ReadLine());
if (N >= 10000 && N < 100000)
{
    //string first = N[0];
    //string second = N[1];
    //string third = N[2];
    //string fourth = N[3];
    //string fifth = N[4];
    // if (first == fifth && two == fourth)
    if (numberText[0] == numberText[4] && numberText[2] == numberText[3])
    {
        Console.WriteLine($"{N} is a palindrome");
    }
    else
    {
        Console.WriteLine($"{N} is not a palindrome");
    }
}
else
{
Console.WriteLine("invalid number entered");
}