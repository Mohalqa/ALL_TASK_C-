using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class FileOperations
{
    public static void Main(string[] args)
    {
        string filePath = "my_information.txt";

     
        WriteToFile(filePath);

        
        string fileContent = ReadFromFile(filePath);

       
        int totalCharacters = CountCharacters(fileContent);

      
        int totalWords = CountWords(fileContent);

      
        Console.WriteLine($"Total number of characters (excluding spaces): {totalCharacters}");
        Console.WriteLine($"Total number of words (excluding spaces): {totalWords}");
    }

   
    public static void WriteToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: Mohammad Alqadri");
                writer.WriteLine("Specialization: Software Engineering");
                writer.WriteLine("Age: 22");
                writer.WriteLine("Description: I am currently studying Software Engineering and working as a full stack developer.");
            }
            Console.WriteLine("File write operation complete.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }

  
    public static string ReadFromFile(string filePath)
    {
        string content = string.Empty;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    content += line + "\n";
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading from file: {ex.Message}");
        }
        return content;
    }

    
    public static int CountCharacters(string text)
    {
       
        string textWithoutSpaces = Regex.Replace(text, @"\s+", "");

       
        int totalCharacters = textWithoutSpaces.Length;
        return totalCharacters;
    }

    
    public static int CountWords(string text)
    {
       
        string textWithoutSpaces = Regex.Replace(text, @"\s+", " ");

        string[] words = textWithoutSpaces.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

       
        int totalWords = words.Length;
        return totalWords;
    }
}
