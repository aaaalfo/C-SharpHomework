

class Program
{
    static void Main()
    {

        Console.WriteLine("\nВведите предложение (Слова должны содержать только буквы)");

        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new string(word.Where(c => char.IsLetter(c)).ToArray()))
                     .Where(word => !string.IsNullOrEmpty(word))
                     .ToArray();


        int wordCount = words.Length;

        int sentenceCount = 0;

        double sumWordLength = 0;

        foreach (var symbol in input)
        {
            if (symbol == '.' || symbol == '?' || symbol == '!')
                sentenceCount++;

        }


        Dictionary<string, int> mostFrequentWords = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (mostFrequentWords.ContainsKey(word.ToLower()))
            {
                mostFrequentWords[word.ToLower()]++;
            }
            else
            {
                mostFrequentWords.Add(word.ToLower(), 1);
            }
        }
        var maxValue = mostFrequentWords.Values.Max();
        var maxElements = mostFrequentWords.Where(pair => pair.Value == maxValue);

        foreach (var word in words)
        {
            sumWordLength += word.Length;

        }

        double averageWordLength = sumWordLength / words.Length;

        Console.WriteLine($"Количество слов: {wordCount}");

        Console.WriteLine($"Количество предложений: {sentenceCount}");

        Console.WriteLine("Слова, встречающиеся максимальное количество раз:");
        foreach (var pair in maxElements)
            {
                Console.WriteLine($"    {pair.Key}: {pair.Value} раз(а)");
            }

        Console.WriteLine($"Средняя длина слов: {averageWordLength:F2}\n");
    }
}

