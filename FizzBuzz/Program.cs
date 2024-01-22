int limit;
string input;

do
{
    Console.Clear();
    Console.WriteLine("Write a number and press [Enter]");
    input = Console.ReadLine() ?? string.Empty;
} while (!int.TryParse(input, out limit));


for (var i = 1; i <= limit; i++)
{
    Console.WriteLine(AsFizzBuzz(i));
}

string AsFizzBuzz(int number)
{
    return (IsDivisibleBy(number, 3), IsDivisibleBy(number, 5)) switch
    {
        (true, true) => "FizzBuzz",
        (true, false) => "Fizz",
        (false, true) => "Buzz",
        _ => number.ToString()
    };
}

bool IsDivisibleBy(int number, int divisor)
{
    return number % divisor == 0;
}