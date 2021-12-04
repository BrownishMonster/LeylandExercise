using LeylandExercise.App;

IPerfectSquareCalculator calculator = new CustomPerfectSquareCalculator();
var defaultColor = Console.ForegroundColor;

Console.WriteLine("Write an integer here, and we will calculate if it is a perfect Square!");

string line = default;
while (!string.IsNullOrEmpty(line = Console.ReadLine()))
{
    if (int.TryParse(line, out var value))
    {
        Console.WriteLine($"\nIs {value} a perfect square?");
        Console.WriteLine(calculator.IsPerfectSquare(value) ? "\tYes" : "\tNo");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter an integer!");
        Console.ForegroundColor = defaultColor;
    }
    Console.WriteLine(new string('-', 25));
}
