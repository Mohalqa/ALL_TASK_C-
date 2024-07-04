using System;

public class Function
{
    public static int MinutesToSeconds(int minutes)
    {
        return minutes * 60;
    }
    public static int IncrementNumber(int number)
    {
        return number + 1;
    }
    public static int FirstElement(int[] array)
    {
        if (array.Length > 0)
        {
            return array[0];
        }
        throw new ArgumentException("Array must contain at least one element.");
    }

    public static double TriangleArea(double @base, double height)
    {
        return 0.5 * @base * height;
    }

    public static List<int> EvenNumberEvenIndex(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i += 2)
        {
            if (nums[i] % 2 == 0)
            {
                result.Add(nums[i]);
            }
        }
        return result;
    }

    public static List<string> EvenIndexOddLength(string[] strings)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < strings.Length; i += 2)
        {
            if (strings[i].Length % 2 != 0)
            {
                result.Add(strings[i]);
            }
        }
        return result;
    }

    public static List<int> PowerElementIndex(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            result.Add((int)Math.Pow(nums[i], i));
        }
        return result;
    }
    public static int Multiplication2(int a, int b)
    {
        int result = 0;
        for (int i = 0; i < b; i++)
        {
            result += a;
        }
        return result;
    }

    public static int Multi2(int start, int end)
    {
        int result = 1;
        for (int i = start; i <= end; i++)
        {
            result *= i;
        }
        return result;
    }
    public static double AveArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return (double)sum / nums.Length;
    }

    public static void Main(string[] args)
    {
        int seconds = MinutesToSeconds(5);  
        Console.WriteLine(seconds);

 Console.WriteLine("*************************************************************************");
        int result = IncrementNumber(5);  
        Console.WriteLine(result);

        Console.WriteLine("*************************************************************************");

        int[] numbers = { 5, 2, 8, 1 };
        int first = FirstElement(numbers); 
        Console.WriteLine(first);

        Console.WriteLine("*************************************************************************");

        double area = TriangleArea(5, 8); 
        Console.WriteLine(area);

        Console.WriteLine("*************************************************************************");

        int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
        List<int> evenNumbersAtEvenIndexes = EvenNumberEvenIndex(nums);  
        Console.WriteLine(string.Join(", ", evenNumbersAtEvenIndexes));

        Console.WriteLine("*************************************************************************");


        string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
        List<string> oddLengthStringsAtEvenIndexes = EvenIndexOddLength(strings); 
        Console.WriteLine(string.Join(", ", oddLengthStringsAtEvenIndexes));

        Console.WriteLine("*************************************************************************");

        int[] nums3 = { 44, 5, 4, 3, 2, 10 };
        List<int> poweredElements = PowerElementIndex(nums); 
        Console.WriteLine(string.Join(", ", poweredElements));



        Console.WriteLine("*************************************************************************");
      
        int multiplication = Multiplication2(5, 4);  
        Console.WriteLine(multiplication);

        Console.WriteLine("*************************************************************************");


        int result2 = Multi2(4, 5);  
        Console.WriteLine(result2);

        result = Multi2(3, 6);  
        Console.WriteLine(result2);

        Console.WriteLine("*************************************************************************");
        
        int[] nums1 = { 1, 2, 3, 8, 9 };
        double average1 = AveArray(nums1);  
        Console.WriteLine(average1);

        int[] nums2 = { 1, 2, 3, 8, 9, 77 };
        double average2 = AveArray(nums2);  
        Console.WriteLine(average2);

    }
}