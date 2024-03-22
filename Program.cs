//Console.Write("Enter the number of terms for Fibonacci sequence: ");
int n = 25; // Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Fibonacci sequence:");
for (int i = 0; i < n; i++)
{
    Console.Write(RecursiveFibonacci(i) + " ");
}

Console.WriteLine();

bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("---");

    Console.WriteLine("Calculate value from:");
    Console.WriteLine("Enter value:");

    string value = Console.ReadLine();
    double.TryParse(value, out double parsedValue);

    Console.WriteLine("---");
    Console.WriteLine("Percentages:");

    int listNumber = 0;
    var fibonacciPercentages = new List<double> { 23.6, 38.2, 61.8, 78.6 };
    foreach (var percentage in fibonacciPercentages)
    {
        listNumber++;
        Console.WriteLine($"{listNumber}. {percentage}%");
    }

    Console.WriteLine("---");
    Console.WriteLine("Select option:");

    string value2 = Console.ReadLine();
    int.TryParse(value2, out int parsedValue2);


    var cal = fibonacciPercentages[parsedValue2 -1];

    double aa = (cal / 100);
    double endResult = parsedValue * aa;

    Console.WriteLine("---");
    Console.WriteLine($"Result: {parsedValue} * ({cal} / 100) => {parsedValue} * {aa.ToString("F3")} = {endResult}");
}

static int RecursiveFibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
}