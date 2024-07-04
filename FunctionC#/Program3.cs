using System;

public class HelloWorld
{
    public static int GetDays(DateTime date1, DateTime date2)
    {
        TimeSpan difference = date2 - date1;
        return difference.Days;
    }
    public static List<string> NumInStr(string[] strings)
    {
        List<string> result = new List<string>();
        foreach (string str in strings)
        {
            if (str.Any(char.IsDigit))
            {
                result.Add(str);
            }
        }
        return result;
    }
    public static string ReverseOdd(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length % 2 != 0)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
        }
        return string.Join(" ", words);
    }
    public static bool IsPandigital(long number)
    {
        string numStr = number.ToString();
        if (numStr.Length > 10)
        {
            return false; 
        }

        for (int i = 0; i <= 9; i++)
        {
            if (!numStr.Contains(i.ToString()))
            {
                return false;
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2019, 6, 14);
        DateTime date2 = new DateTime(2019, 6, 20);
        int days1 = GetDays(date1, date2);  
        Console.WriteLine(days1);

        date1 = new DateTime(2018, 12, 29);
        date2 = new DateTime(2019, 1, 1);
        int days2 = GetDays(date1, date2);  
        Console.WriteLine(days2);



        Console.WriteLine("********************************************************************************");



        string[] arr1 = { "1a", "a", "2b", "b" };
        List<string> filtered1 = NumInStr(arr1);  
        Console.WriteLine(string.Join(", ", filtered1));

        string[] arr2 = { "abc", "abc10" };
        List<string> filtered2 = NumInStr(arr2);  
        Console.WriteLine(string.Join(", ", filtered2));




        Console.WriteLine("********************************************************************************");

        string result1 = ReverseOdd("Bananas");  
        Console.WriteLine(result1);

        string result2 = ReverseOdd("One two three four");  
        Console.WriteLine(result2);








        Console.WriteLine("********************************************************************************");




        long num1 = 98140723568910;
        bool pandigital1 = IsPandigital(num1); 
        Console.WriteLine(pandigital1);

        long num2 = 90864523148909;
        bool pandigital2 = IsPandigital(num2);  
        Console.WriteLine(pandigital2);

        long num3 = 112233445566778899;
        bool pandigital3 = IsPandigital(num3);  
        Console.WriteLine(pandigital3);
    }
}