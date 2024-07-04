using System;

public class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass class has initialized!");
    }
}
public class GreetingMessage
{
    public void DisplayMessage(string name)
    {
        Console.WriteLine($"Hello All, I am {name}");
    }
}
public class FactorialCalculator
{
    public int CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }

        int factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
public class ArraySorter
{
    public void SortArray(int[] array)
    {
        Array.Sort(array);
    }
}
public class DateDifferenceCalculator
{
    public void CalculateDifference(DateTime date1, DateTime date2)
    {
        if (date1 > date2)
        {
            DateTime temp = date1;
            date1 = date2;
            date2 = temp;
        }

        TimeSpan difference = date2 - date1;
        int years = date2.Year - date1.Year;
        int months = date2.Month - date1.Month;
        int days = date2.Day - date1.Day;

        if (months < 0)
        {
            years--;
            months += 12;
        }
        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(date1.Year, date1.Month);
        }

        Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
    }
}
public class DateConverter
{
    public void ConvertDate(string dateString)
    {
        DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
        Console.WriteLine($"Converted Date: {date:yyyy-MM-dd}");
    }
}


public class Task5
{
    public static void Main(string[] args)
    {
        // Task 5(1)
        MyClass myClass = new MyClass();

        // Task 5(2)
        GreetingMessage greeting = new GreetingMessage();
        greeting.DisplayMessage("Scott");

        // Task 5(3)
        FactorialCalculator factorialCalculator = new FactorialCalculator();
        int number = 5;
        int factorial = factorialCalculator.CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is: {factorial}");

        // Task 5(4)
        int[] array = { 11, -2, 4, 35, 0, 8, -9 };
        ArraySorter sorter = new ArraySorter();

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", array));

        sorter.SortArray(array);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", array));

        // Task 5(5)
        DateTime date1 = new DateTime(1981, 11, 3);
        DateTime date2 = new DateTime(2013, 9, 4);

        DateDifferenceCalculator dateDifferenceCalculator = new DateDifferenceCalculator();
        dateDifferenceCalculator.CalculateDifference(date1, date2);

        // Task 5(6)
        string dateString = "12-08-2004";

        DateConverter converter = new DateConverter();
        converter.ConvertDate(dateString);
    }
}