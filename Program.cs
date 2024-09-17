PrintWithColor("Пример работы 25 варианта",ConsoleColor.Yellow);
double minX;
double maxX;
double stepX;
double myDouble;
while (true)
{
    MyProgram();
}
void MyProgram()
{
    PrintWithColor("Введите минимальный X", ConsoleColor.Green);
    minX = GetDouble();

    PrintWithColor("Введите максимальный X", ConsoleColor.Green);
    maxX = GetDouble();

    PrintWithColor("Введите шаг функции", ConsoleColor.Green);
    stepX = GetDouble();

    MyMathF(minX,maxX,stepX);
}
void MyMathF(in double min,in double max,in double step)
{
    if (min > max) return;
    else if (step == 0) return;
    else if (step < 0) return;

    PrintWithColor("_О_Т_В_Е_Т_",ConsoleColor.Yellow);
    for (double i = min; i <= max; i += step)
    {
        PrintWithColor($"x = {i}; y = {MyGetValueFunction(i)}",ConsoleColor.Yellow);
    }
}
double MyGetValueFunction(in double x)
{
    double y;
    if (x <= 0)
    {
        y = (1 + Math.Cos(x)) / (1 + Math.Pow(x,2));
    }
    else
    {
        y = x * Math.Cos(x);
    }
    return y;
}
double GetDouble()
{
    if (double.TryParse(Console.ReadLine(), out myDouble))
        return myDouble;
    else
    {
        PrintWithColor("Произошла опечатка,введите число заново",ConsoleColor.Red);
        return GetDouble();
    }
}
void PrintWithColor(string message, ConsoleColor newColor)
{
    ConsoleColor color = Console.ForegroundColor;
    Console.ForegroundColor = newColor;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}
