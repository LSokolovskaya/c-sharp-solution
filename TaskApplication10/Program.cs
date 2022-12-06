// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
    #region Задача1
    // записать метод возвращающий наибольшее число из трех чисел
    static void Task1()
    {
        System.Console.WriteLine(MethodMaxNumber(1, 4, 2));
    }
    static int MethodMaxNumber(int number1, int number2, int number3)
    {
        if (number1 > number2 && number1 > number3)
        {
            return number1;
        }
        else if (number2 > number1 && number2 > number3)
        {
            return number2;
        }
        else
        {
            return number3;
        }
    }
    #endregion
    #region Задача2
    static void Task2()
    {
        string text = "sdfghjkcvbnmfghjk";
        char symb = 's';
        System.Console.WriteLine(Count(text, symb));
    }
    static int Count(string text, char input)
    {
        int count = 0;
        foreach (char item in text)
        {
            if (item == input)
            {
                count += 1;
            }
        }
        return count;
    }
    #endregion
    #region Задача 3
    //метод, который возвращает строку
    static void Task3()
    {
        string input = "Hello asdlkajs dljseeeecovij102938i21=-3=089 hkjcveeeenxjcv";
        Console.WriteLine(input);
        Console.WriteLine(MethodReverse(input));
    }
    static string MethodReverse(string text)
    {
        string result = "";
        for (int i = text.Length - 1; i > -1; i--)
        {
            result += text[i];
        }
        return result;
    }
    #endregion
    #region Задача 4
    //найти индекс минимального значения массива  чисел
    static void Task4()
    {
        int[] array = { -1, 2, 5, -6, 3, 8, 4 };
        System.Console.WriteLine(SearchMinNumberArray(array));
    }
    static int SearchMinNumberArray(int[] array)
    {
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                index = i - 1;
            }
        }
        return index;
    }
    #endregion
    #region Задача 5
    static void Task5()
    {
        string input = "Hello askdjhasd oaisd/ 213 123/sdf sdf/sdf";
        char symbol = ' ';
        bool result = Method1(input, symbol, out int count);
        Console.WriteLine(string.Format("Symbol - {0}, length new array - {1}", symbol, count));
    }
    static bool Method1(string text, char symbol, out int count)
    {
        if (text.IndexOf(symbol) > -1)
        {
            count = text.Split(symbol).Length;
            return true;
        }
        count = 0; // default
        return false;
    }
    #endregion
    #region Задача 6

    static void Task6()
    {

    }
    static double Sum(params double[] numbers)
    {
        double sumelements = 0;
        double result = 0;
        foreach (var item in numbers)
        {
            sumelements += item;
        }
        return sumelements/ numbers.Length;
    }
    #endregion
}