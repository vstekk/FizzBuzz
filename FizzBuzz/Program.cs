// vypisovat cisla postupne
// cisla delitelne 3 napisu misto toho Fizz
// cisla delitelna 5 napisu misto toho Buzz
// cisla delitelna 3 i 5 jsou FizzBuzz


int limit;
string input;

Console.WriteLine("Give me your FizzBuzz limit:");
do
{
    input = Console.ReadLine() ?? string.Empty;
} while (!int.TryParse(input, out limit));

Console.Clear();

for (var i = 1; i <= limit; i++)
{
    Console.WriteLine(GetFizzBuzzString(i));
}

string GetFizzBuzzString(int number)
{
    return
        IsDivisibleBy(number, 3) && IsDivisibleBy(number, 5) ? "FizzBuzz"
        : IsDivisibleBy(number, 3) ? "Fizz"
        : IsDivisibleBy(number, 5) ? "Buzz"
        : number.ToString();
}

bool IsDivisibleBy(int number, int divider)
{
    return number % divider == 0;
}