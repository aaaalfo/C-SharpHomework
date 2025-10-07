using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        var wordMatches = Regex.Matches(input.ToLower(), @"\b[\p{L}0-9]+\b");
        var words = wordMatches.Select(m => m.Value).ToArray();
        int wordCount = words.Length;
        int sentenceCount = Regex.Matches(input, @"[.!?]+").Count;

        var wordGroups = words.GroupBy(w => w).ToList();
        int maxCount = wordGroups.Any() ? wordGroups.Max(g => g.Count()) : 0;

        var mostFrequentWords = wordGroups
            .Where(g => g.Count() == maxCount)
            .OrderBy(g => g.Key);

        double averageWordLength = wordCount > 0 ? words.Average(w => w.Length) : 0;

        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");

        Console.WriteLine("Слова, встречающиеся максимальное количество раз:");
        if (mostFrequentWords.Any())
        {
            foreach (var group in mostFrequentWords)
            {
                Console.WriteLine($"{group.Key} — {group.Count()} раз(а)");
            }
        }

        Console.WriteLine($"Средняя длина слов: {averageWordLength:F2}");
    }
}
