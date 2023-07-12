using System.Diagnostics;
using OtusHomeWork7;

internal class Program
{
    private static void Main(string[] args)
    {
        FibonacciRecursion fibonacciRecursion = new FibonacciRecursion();
        FibonacciCycle cycle = new FibonacciCycle();
        
        Stopwatch sw = Stopwatch.StartNew(); 
        
        long result5Recursion = fibonacciRecursion.CalculateFibbonacciRecursion(5); 
        sw.Stop();
        Console.WriteLine($"Результат рекурсивного метода: {result5Recursion}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");
        sw.Reset();
        sw.Start(); 
        long result5Cycle = cycle.CalculateFibonacciCycle(5); 
        sw.Stop();
        Console.WriteLine($"Результат метода с циклом: {result5Cycle}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");
        sw.Reset();
        sw.Start();
        long result10Recursion = fibonacciRecursion.CalculateFibbonacciRecursion(10);
        sw.Stop();
        Console.WriteLine($"Результат рекурсивного метода: {result10Recursion}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");
        sw.Reset();
        sw.Start();
        long result10Cycle = cycle.CalculateFibonacciCycle(10);
        sw.Stop();
        Console.WriteLine($"Результат метода с циклом: {result10Cycle}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");
        sw.Reset();
        sw.Start();
        long result20Recursion = fibonacciRecursion.CalculateFibbonacciRecursion(20);
        sw.Stop();
        Console.WriteLine($"Результат рекурсивного метода: {result20Recursion}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");
        sw.Reset();
        sw.Start();
        long result20Cycle = cycle.CalculateFibonacciCycle(20);
        sw.Stop();
        Console.WriteLine($"Результат метода с циклом: {result20Cycle}. Время выполнения операции {sw.ElapsedMilliseconds} милисекунд. Время выполнения операции {sw.ElapsedTicks} тактов");

        Console.ReadKey();
    }
}