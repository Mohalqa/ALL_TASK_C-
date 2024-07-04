using System;

namespace VariableNamingExample
{
    class Program
    {
        static (int, double) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;
            return (sum, average);
        }

        static int? GetYears(int[] years)
        {
            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    return years[i];
                }
            }

            return null;
        }

        public static int AgeInDays(int ageInYears)
        {
            return ageInYears * 365;
        }

        public static string Login(string username, string password)
        {
            var users = new[]
            {
                new { Username = "user1", Password = "password1" },
                new { Username = "user2", Password = "password2" },
            };

            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return "pass";
                }
            }

            return "failed";
        }

        static double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1900 and 2024.");
            }

            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return 0;
            }

            int wordCount = 0;
            bool inWord = false;

            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }

            return wordCount;
        }

        static void Main(string[] args)
        {
            // Task 3: Part 1
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            // Task 3: Part 2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine($"Index of Banana: {Array.IndexOf(fruits, "Banana")}");
            Console.WriteLine($"Index of Tomato: {Array.IndexOf(fruits, "Tomato")}");

            // Task 3: Part 3
            string[] food = { "Burger", "Shawarma", "Pizza", "Fish", "Fruits" };
            string[] sport = { "MMA", "Boxing", "Running" };
            string[] movies = { "Inception", "Avatar", "The Matrix", "Interstellar" };

            Console.WriteLine("\nFavorite Food:");
            foreach (var item in food) Console.WriteLine(item);

            Console.WriteLine("\nFavorite Sports:");
            foreach (var item in sport) Console.WriteLine(item);

            Console.WriteLine("\nFavorite Movies:");
            foreach (var item in movies) Console.WriteLine(item);

            // Task 3: Part 4
            int[] numbers = { 5, 10, 15 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            // Task 3: Part 5
            int n;
            int sumOfOdds = 0;
            Console.Write("Enter the number of terms (n): ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("The odd numbers from 1 to 100:");
            int count = 0;
            for (int i = 1; count < n; i += 2)
            {
                Console.Write($"{i} ");
                sumOfOdds += i;
                count++;
            }
            Console.WriteLine($"\nThe sum of odd numbers: {sumOfOdds}");

            // Task 3: Part 6
            int n1 = 3; // Number of rows
            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("/**********Task3 Done**************/");

            Console.WriteLine("/**********Task4 Start**************/");

            // Task 4: Part 1
            int[] numbers2 = new int[10];
            Console.WriteLine("Input the 10 numbers:");

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write($"Number-{i + 1}: ");
                numbers2[i] = int.Parse(Console.ReadLine());
            }

            var (sum1, average) = CalculateSumAndAverage(numbers2);

            Console.WriteLine($"The sum of 10 numbers is: {sum1}");
            Console.WriteLine($"The average is: {average:F6}");

            // Task 4: Part 2
            int num;
            Console.Write("Input number of terms: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}");
            }

            // Task 4: Part 3
            int[] yeares = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int? result = GetYears(yeares);
            Console.WriteLine($"First year after 1950: {result}");

            // Task 4: Part 4
            int age = 20;
            int result2 = AgeInDays(age);
            Console.WriteLine($"Your age in days is: {result2} days");

            // Task 4: Part 5
            // Code for AnimalLegs is commented out.

            // Task 4: Part 6
            string username1 = "user1";
            string password1 = "password1";
            string result1 = Login(username1, password1);
            Console.WriteLine($"Test 1: Username: {username1}, Password: {password1}, Result: {result1}");

            string username2 = "invalid_user";
            string password2 = "password1";
            string result4 = Login(username2, password2);
            Console.WriteLine($"Test 2: Username: {username2}, Password: {password2}, Result: {result4}");

            string username3 = "user1";
            string password3 = "wrong_password";
            string result3 = Login(username3, password3);
            Console.WriteLine($"Test 3: Username: {username3}, Password: {password3}, Result: {result3}");

            // Task 4: Part 7
            double baseNumber = 2.0;
            double exponent = 3.0;

            double powerResult = Power(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {powerResult}");

            // Task 4: Part 8
            int year = 2020;
            bool isLeapYear = IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year: {isLeapYear}");

            year = 2021;
            isLeapYear = IsLeapYear(year);
            Console.WriteLine($"{year} is a leap year: {isLeapYear}");

            try
            {
                year = 1899;
                isLeapYear = IsLeapYear(year);  
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Task 4: Part 9
            int number = 11;
            bool isPrime = IsPrime(number);
            Console.WriteLine($"{number} is prime: {isPrime}");

            number = 12;
            isPrime = IsPrime(number);
            Console.WriteLine($"{number} is prime: {isPrime}");

            // Task 4: Part 10
            string sentence = "This is a test sentence.";
            int wordCount = CountWords(sentence);
            Console.WriteLine($"'{sentence}' has {wordCount} words.");
        }
    }
}
