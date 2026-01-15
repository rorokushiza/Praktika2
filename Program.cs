using System;
using System.Text;
using System.Linq;

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
        {
            return result.ToString().ToUpper();
        }
        else
        {
            return result.ToString().ToLower();
        }
    }

    public string GenerateRandomText(int wordCount = 4)
    {
        string[] words = {
            "Челюсть", "Дисциплина", "Исследователь", "Каша", "Книга",
            "Аналог", "Девятка", "Организация", "Тонна", "Технология"
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
        int len = text.Length;
        Console.WriteLine($"Строка: '{text}', Длина: {len}");

        string mixedCase = "Hello World";
        Console.WriteLine($"ToLower(): {mixedCase.ToLower()}");
        Console.WriteLine($"ToUpper(): {mixedCase.ToUpper()}");

        string message = "Добро пожаловать";
        bool hasWord = message.Contains("пожа");
        Console.WriteLine($"Строка '{message}' содержит 'пожа': {hasWord}");

        string data = "Папайя,Кокос,Черника,Лимон,Манго";
        string[] fruits = data.Split(',');
        Console.WriteLine("Разделенные фрукты:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"  {fruit}");
        }
    }

    public void DemonstrateArrayMethods()
    {
        Console.WriteLine("\n=== Демонстрация работы с массивами ===");

        int[] numbers = { 16, 38, 66, 79, 93 };

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
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("=== ГЕНЕРАТОР СЛУЧАЙНЫХ ДАННЫХ ===");
            Console.WriteLine("1.  Сгенерировать случайное целое число");
            Console.WriteLine("2.  Сгенерировать случайное дробное число");
            Console.WriteLine("3.  Сгенерировать случайную строку");
            Console.WriteLine("4.  Сгенерировать случайный текст");
            Console.WriteLine("5.  Сгенерировать массив целых чисел");
            Console.WriteLine("6.  Сгенерировать массив строк");
            Console.WriteLine("7.  Сгенерировать массив дробных чисел");
            Console.WriteLine("8.  Демонстрация методов строк");
            Console.WriteLine("9.  Демонстрация работы с массивами");
            Console.WriteLine("10. Показать все типы данных");
            Console.WriteLine("11. Работа с массивом целых чисел");
            Console.WriteLine("12. Работа с массивом строк");
            Console.WriteLine("13. Работа с массивом дробных чисел");
            Console.WriteLine("0.  Выход");
            Console.Write("\nВыберите действие: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Clear();
                Console.WriteLine($"=== Выбрано действие {choice} ===");

                switch (choice)
                {
                    case 1:
                        Console.Write("Минимальное значение: ");
                        int min1 = int.TryParse(Console.ReadLine(), out int m1) ? m1 : 0;
                        Console.Write("Максимальное значение: ");
                        int max1 = int.TryParse(Console.ReadLine(), out int m2) ? m2 : 100;
                        Console.WriteLine($"\nСлучайное целое число: {generator.GenerateRandomInt(min1, max1)}");
                        break;

                    case 2:
                        Console.Write("Минимальное значение: ");
                        double min2 = double.TryParse(Console.ReadLine(), out double d1) ? d1 : 0.0;
                        Console.Write("Максимальное значение: ");
                        double max2 = double.TryParse(Console.ReadLine(), out double d2) ? d2 : 1.0;
                        Console.WriteLine($"\nСлучайное дробное число: {generator.GenerateRandomDouble(min2, max2):F2}");
                        break;

                    case 3:
                        Console.Write("Длина строки: ");
                        int length = int.TryParse(Console.ReadLine(), out int l) ? l : 10;
                        Console.WriteLine($"\nСлучайная строка: {generator.GenerateRandomString(length)}");
                        break;

                    case 4:
                        Console.Write("Количество слов: ");
                        int words = int.TryParse(Console.ReadLine(), out int w) ? w : 4;
                        Console.WriteLine($"\nСлучайный текст: {generator.GenerateRandomText(words)}");
                        break;

                    case 5:
                        Console.Write("Размер массива: ");
                        int size1 = int.TryParse(Console.ReadLine(), out int s1) ? s1 : 5;
                        Console.Write("Минимальное значение: ");
                        int minArr1 = int.TryParse(Console.ReadLine(), out int ma1) ? ma1 : 0;
                        Console.Write("Максимальное значение: ");
                        int maxArr1 = int.TryParse(Console.ReadLine(), out int ma2) ? ma2 : 100;

                        int[] intArray = generator.GenerateRandomIntArray(size1, minArr1, maxArr1);
                        Console.WriteLine($"\nМассив из {size1} целых чисел:");
                        for (int i = 0; i < intArray.Length; i++)
                        {
                            Console.WriteLine($"  [{i}] = {intArray[i]}");
                        }
                        break;

                    case 6:
                        Console.Write("Размер массива: ");
                        int size2 = int.TryParse(Console.ReadLine(), out int s2) ? s2 : 5;

                        string[] stringArray = generator.GenerateRandomStringArray(size2);
                        Console.WriteLine($"\nМассив из {size2} строк:");
                        for (int i = 0; i < stringArray.Length; i++)
                        {
                            Console.WriteLine($"  [{i}] = \"{stringArray[i]}\"");
                        }
                        break;

                    case 7:
                        Console.Write("Размер массива: ");
                        int size3 = int.TryParse(Console.ReadLine(), out int s3) ? s3 : 5;
                        Console.Write("Минимальное значение: ");
                        double minArr3 = double.TryParse(Console.ReadLine(), out double md1) ? md1 : 0.0;
                        Console.Write("Максимальное значение: ");
                        double maxArr3 = double.TryParse(Console.ReadLine(), out double md2) ? md2 : 100.0;

                        double[] doubleArray = generator.GenerateRandomDoubleArray(size3, minArr3, maxArr3);
                        Console.WriteLine($"\nМассив из {size3} дробных чисел:");
                        for (int i = 0; i < doubleArray.Length; i++)
                        {
                            Console.WriteLine($"  [{i}] = {doubleArray[i]:F2}");
                        }
                        break;

                    case 8:
                        generator.DemonstrateStringMethods();
                        break;

                    case 9:
                        generator.DemonstrateArrayMethods();
                        break;

                    case 10:
                        generator.GenerateAndDisplaySampleData();
                        break;

                    case 11:
                        Console.Write("Размер массива: ");
                        int size4 = int.TryParse(Console.ReadLine(), out int s4) ? s4 : 5;
                        int[] arr1 = generator.GenerateRandomIntArray(size4);

                        Console.WriteLine($"\nМассив: [{string.Join(", ", arr1)}]");
                        Console.WriteLine($"Минимальное: {arr1.Min()}");
                        Console.WriteLine($"Максимальное: {arr1.Max()}");
                        Console.WriteLine($"Сумма: {arr1.Sum()}");
                        Console.WriteLine($"Среднее: {arr1.Average():F2}");

                        Array.Sort(arr1);
                        Console.WriteLine($"Отсортированный: [{string.Join(", ", arr1)}]");
                        break;

                    case 12:
                        Console.Write("Размер массива: ");
                        int size5 = int.TryParse(Console.ReadLine(), out int s5) ? s5 : 5;
                        string[] arr2 = generator.GenerateRandomStringArray(size5);

                        Console.WriteLine($"\nМассив строк:");
                        foreach (string str in arr2)
                        {
                            Console.WriteLine($"  Длина '{str}': {str.Length} символов");
                            Console.WriteLine($"  Верхний регистр: {str.ToUpper()}");
                            Console.WriteLine($"  Нижний регистр: {str.ToLower()}");
                        }
                        break;

                    case 13:
                        Console.Write("Размер массива: ");
                        int size6 = int.TryParse(Console.ReadLine(), out int s6) ? s6 : 5;
                        double[] arr3 = generator.GenerateRandomDoubleArray(size6);

                        Console.WriteLine($"\nМассив дробных чисел:");
                        foreach (double d in arr3)
                        {
                            Console.WriteLine($"  {d:F2}");
                        }
                        Console.WriteLine($"Сумма: {arr3.Sum():F2}");
                        Console.WriteLine($"Среднее: {arr3.Average():F2}");
                        break;

                    case 0:
                        isRunning = false;
                        Console.WriteLine("Выход из программы...");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
                Console.ReadKey();
            }
        }
    }
}