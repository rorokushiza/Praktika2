using System;
using System.Text;


public class RandomDataGenerator
{
    private Random random = new Random();

    
    public int GenerateRandomInt(int min = 0, int max = 100)
    {
        return random.Next(min, max + 1);
    }

    public double GenerateRandomDouble(double min = 0.0, double max = 1.0)
    {
        return min + (random.NextDouble() * (max - min));
    }

   
    public string GenerateRandomString(int length = 10)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder result = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            result.Append(chars[random.Next(chars.Length)]);
        }

        if (random.Next(2) == 0)
            return result.ToString().ToUpper();
        else
            return result.ToString().ToLower();
    }

    public string GenerateRandomText(int wordCount = 5)
    {
        string[] words = {
            "Привет", "Мир", "Программирование", "Данные", "Массив",
            "Строка", "Код", "Генерация", "Случайный", "Тест"
        };

        StringBuilder text = new StringBuilder();
        for (int i = 0; i < wordCount; i++)
        {
            text.Append(words[random.Next(words.Length)]);
            if (i < wordCount - 1) text.Append(" ");
        }
        return text.ToString();
    }

    
    public int[] GenerateRandomIntArray(int size = 5, int min = 0, int max = 100)
    {
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(min, max + 1);
        }
        return numbers;
    }

    public string[] GenerateRandomStringArray(int size = 5)
    {
        string[] strings = new string[size];
        for (int i = 0; i < size; i++)
        {
            strings[i] = GenerateRandomString(random.Next(5, 15));
        }
        return strings;
    }

    public double[] GenerateRandomDoubleArray(int size = 5, double min = 0.0, double max = 100.0)
    {
        double[] doubles = new double[size];
        for (int i = 0; i < size; i++)
        {
            doubles[i] = GenerateRandomDouble(min, max);
        }
        return doubles;
    }

   
    public void DemonstrateStringMethods()
    {
        Console.WriteLine("=== Демонстрация методов строк ===");

        string text = GenerateRandomString(8);
        Console.WriteLine($"Строка: '{text}', Длина: {text.Length}");

        Console.WriteLine($"ToLower(): {"Hello World".ToLower()}");
        Console.WriteLine($"ToUpper(): {"Hello World".ToUpper()}");

        string message = "Добро пожаловать";
        bool hasWord = message.Contains("пожа");
        Console.WriteLine($"Строка '{message}' содержит 'пожа': {hasWord}");

        string citySearch = "MOSCOW";
        bool hasCity = citySearch.ToLower().Contains("mos");
        Console.WriteLine($"'MOSCOW' содержит 'mos': {hasCity}");

        string data = "яблоко,банан,апельсин,груша";
        string[] fruits = data.Split(',');
        Console.WriteLine("Разделенные фрукты:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"  - {fruit}");
        }
    }

    
    public void DemonstrateArrayMethods()
    {
        Console.WriteLine("\n=== Демонстрация работы с массивами ===");

        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine($"Первый элемент: {numbers[0]}");

        numbers[2] = 99;
        Console.WriteLine($"Третий элемент после изменения: {numbers[2]}");

        Console.WriteLine("Перебор циклом for:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"  numbers[{i}] = {numbers[i]}");
        }

        Console.WriteLine("Перебор циклом foreach:");
        foreach (int item in numbers)
        {
            Console.WriteLine($"  {item}");
        }
    }

    
    public void GenerateAndDisplaySampleData()
    {
        Console.WriteLine("=== Генерация случайных данных ===");

        
        Console.WriteLine($"\n1. Случайное целое число: {GenerateRandomInt()}");
        Console.WriteLine($"   Случайное дробное число: {GenerateRandomDouble():F2}");

       
        Console.WriteLine($"\n2. Случайная строка: {GenerateRandomString()}");
        Console.WriteLine($"   Случайный текст: {GenerateRandomText()}");

        
        Console.WriteLine("\n3. Массив случайных целых чисел:");
        int[] intArray = GenerateRandomIntArray();
        foreach (int num in intArray)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine("\n\n4. Массив случайных строк:");
        string[] stringArray = GenerateRandomStringArray(3);
        foreach (string str in stringArray)
        {
            Console.WriteLine($"  - {str}");
        }

        Console.WriteLine("\n5. Массив случайных дробных чисел:");
        double[] doubleArray = GenerateRandomDoubleArray(4, 0.0, 10.0);
        foreach (double d in doubleArray)
        {
            Console.Write($"{d:F2} ");
        }
        Console.WriteLine();
    }
} 


class Program
{
    static void Main(string[] args)
    {
        RandomDataGenerator generator = new RandomDataGenerator();

        
        generator.GenerateAndDisplaySampleData();
        generator.DemonstrateStringMethods();
        generator.DemonstrateArrayMethods();

       
        int[] nums = { 16, 38, 66, 79, 93 };
        Console.WriteLine($"\nДоступ к элементу массива: nums[0] = {nums[0]}");
        nums[2] = 99;
        Console.WriteLine($"После изменения: nums[2] = {nums[2]}");
    }
}