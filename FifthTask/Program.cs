using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        
        string text = Console.ReadLine();
        
        
        int wordCount = CountWords(text);
        
        int sentenceCount = CountSentences(text);
        
        var frequentlyOccurringWords = GetMostFrequentlyOccurringWords(text);
        
        double averageWordLength = CalculateAverageWordLength(text);
        
        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");
        Console.WriteLine($"Средняя длина слова: {averageWordLength:F2} символов");
        Console.WriteLine("Самые частые слова:");
        if (frequentlyOccurringWords.Any())
        {
            foreach (var word in frequentlyOccurringWords)
            {
                Console.WriteLine($"{word.Key} - {word.Value} раз(а)");
            }
    }
    
    static int CountWords(string text)
    {
        char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '\t', '\n', '\r' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        return words.Count(word => word.Any(char.IsLetter));
    }
    
    static int CountSentences(string text)
    {
        char[] sentenceSeparators = { '.', '!', '?' };
        string[] sentences = text.Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries);
        
        return sentences.Count(s => s.Trim().Any(char.IsLetterOrDigit));
    }
    
    static List<KeyValuePair<string, int>> GetMostFrequentlyOccurringWords(string text)
{
    char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '\t', '\n', '\r', '"', '\'' };
    
    var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                   .Where(word => word.Any(char.IsLetter))
                   .Select(word => word.ToLower())
                   .Where(word => word.Length > 1);
    
    var wordFrequency = words.GroupBy(word => word)
                            .ToDictionary(group => group.Key, group => group.Count())
                            .Where(pair => pair.Value > 1)
                            .ToList();
    
    if (!wordFrequency.Any())
        return new List<KeyValuePair<string, int>>();
    
    int maxFrequency = wordFrequency.Max(pair => pair.Value);
    
    return wordFrequency
        .Where(pair => pair.Value == maxFrequency)
        .OrderBy(pair => pair.Key)
        .ToList();
}
    
    static double CalculateAverageWordLength(string text)
    {
        char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '\t', '\n', '\r' };
        
        var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                       .Where(word => word.Any(char.IsLetter));
        
        if (!words.Any())
            return 0;
        
        return words.Average(word => word.Length);
    }
}
}