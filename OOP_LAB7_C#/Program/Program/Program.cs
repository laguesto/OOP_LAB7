using ExceptionLib;

double a, b, c, d;

Console.Write("Enter a, b, c, d: ");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
c = Convert.ToDouble(Console.ReadLine());
d = Convert.ToDouble(Console.ReadLine());

try
{
    ExceptionClass expr = new ExceptionClass(a, b, c, d);
    double result = expr.Calculate();

    Console.WriteLine("Result: " + result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}