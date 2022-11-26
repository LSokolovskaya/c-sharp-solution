
internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task7();
        // Task8();
        // Task9();
        // Task10();
        // Task11();
        // Task12();
        // Task13();
        // Task14();
    }
    static bool MethodIsNumber(object[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] is not int)
            {
                return false;
            }
        }
        return true;
    }
    #region Задача1
    // Пользователь вводит имя и фамилию. Необходимо создать метод возвращающую строку вида «Привет, {имя} {фамилия}»
    static void Task1()
    {
        System.Console.WriteLine("введите имя");
        string? name = Console.ReadLine();
        System.Console.WriteLine("введите фамилию");
        string? lastname = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
        {
            if (!string.IsNullOrEmpty(lastname))
            {
                System.Console.WriteLine(HelloMethod(name, lastname));
            }
            else
            {
                System.Console.WriteLine("Пусто");
            }
        }
        else
        {
            System.Console.WriteLine("Пусто");
        }
    }
    static string HelloMethod(string name, string lastname)
    {
        return $"Привет, {name} {lastname}";
    }
    #endregion
    #region Задача2
    // Напишите метод, который принимает строку в маленьком регистре и возаращает строку, где каждое слово начинается с большого регистра hschool company -> Hschool Company 
    static void Task2()
    {
        string? text = Console.ReadLine();
        System.Console.WriteLine(ConverterString(text));
    }
    static string ConverterString(string line)
    {
        string[] array = line.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            string text = array[i];
            // преобразование текста
            text = char.ToUpper(text[0]) + text.Remove(0, 1);
            array[i] = text;
        }
        return string.Join(' ', array);

    }
    #endregion
    #region Задача3
    // Напишите метод, который принимает статичный массив строк. Необходимо отфильтровать значения и оставить только те, 
    // где длина строк до 2 символов.[“by”, “belarus”, “de”, “ru”, “germany”] -> [“by”, “de”, “ru”]
    static void Task3()
    {
        string[] text = { "by", "belarus", "de", "ru", "germany" };
        System.Console.WriteLine(string.Join(",", MethodReplace(text)));
    }
    static string[] MethodReplace(string[] text)
    {
        string[] result = new string[3];
        int i = 0;
        foreach (string item in text)
        {
            if (item.Length < 3)
            {
                result[i] += item;
                i++;
            }
        }
        return result;
    }
    #endregion
    #region Задача4
    // На входе массив. Реализовать метод проверки на то что в массиве только числа. Метод возвращает true, если в массиве только числа и false в противном случае
    static void Task4()
    {
        object[] array = { 1, 2, 3, 4, 5 };
        bool result = MethodIsNumber(array);
        System.Console.WriteLine(result);
    }

    #endregion
    #region Задача5
    // 5. На входе n – количество элементов массива (вводится с клавиатуры). Далее производится 
    // заполнение массива с слуйчными числами. Реализуйте два метода для поиска минимального и 
    // максимального значения.
    static void Task5()
    {
        Console.WriteLine("введите длинну массива");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numberindex))
        {
            double[] numbers = new double[numberindex];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(-100, 100);
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(MethodMinNumber(numbers));
            Console.WriteLine(MethodMaxNumber(numbers));
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static double MethodMinNumber(double[] number)
    {
        double numberMin = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            if (numberMin > number[i])
            {
                numberMin = number[i];
            }
        }
        return numberMin;
    }
    static double MethodMaxNumber(double[] number)
    {
        double numberMax = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            if (numberMax < number[i])
            {
                numberMax = number[i];
            }
        }
        return numberMax;
    }
    #endregion
    #region Задача6
    // 6. На входе n – количество элементов массива (вводится с клавиатуры). Далее производится заполнение массива с слуйчными числами. Реализуйте методы подсчета количества элементов массива меньше и большe среднего значения.
    static void Task6()
    {
        Console.WriteLine("введите длинну массива");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numberindex))
        {
            double[] numbers = new double[numberindex];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(-100, 100);
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    #endregion
    #region Задача7
    // 7. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве только числа. Второй для получения суммы всех элементов массива. Если результат метода проверки – true, то вызывать новый метод, возвращающий сумму всех элементов массива
    static void Task7()
    {
        object[] array = { 1, 2, 3, 4, 5 };
        if (MethodIsNumber(array))
        {
            System.Console.WriteLine(SumItemsArray(array));
        }
    }
    static int SumItemsArray(object[] arrays)
    {
        int result = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            result += arrays[i] is int number ? number : default;
        }
        return result;
    }
    #endregion
    #region Задача8
    //  8. На входе массив. Реализуйте 2 метода. Первый для проверки,что вмассиве только строки. Второй для получения суммы всех строчных элементов массива. Если результат метода проверки – true, то вызывать новый метод, возвращающую конкатенацию всех строчных элементов массива
    static void Task8()
    {
        object[] array = { "s", "e", "f", "g", "h", "c", "v", "b", "n" };
        if ((Convert.ToBoolean(MethodIsNotNumber(array))))
        {
            System.Console.WriteLine(MethodConcat(array));
        }
        else
        {
            System.Console.WriteLine("error");
        }
    }
    static int MethodIsNotNumber(object[] text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] is string)
            {
                return Convert.ToInt32(true);
            }
        }
        return Convert.ToInt32(false);
    }
    static string MethodConcat(object[] array)
    {
        string result = "";
        for (int i = 0; i < array.Length; i++)
        {
            // result = string.Concat(array[i], array[i]);
            result = result + array[i];
        }
        return result;
    }
    #endregion
    #region Задача9
    // 9. На входе 2 массива, размерность которых вводится с клавиатуры, а значения заполняются случайными числами. Реализуйте 2 метода. Первый что массивы имеют одинаковую размерность и все элементы отличаются. Второй произвести поэлементное умножение. Если результат метода проверки – true, то вызывать новый метод, возвращающий вывод элементов через запятую
    static void Task9()
    {

    }
    #endregion
    #region Задача10
    // 10. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве только числа. Второй для получения только четных элементов массива. Если результат метода проверки – true, то вызывать новую метод, возвращающий массив с четными элементами массива
    static void Task10()
    {
        object[] array = { 1, 2, 4, 5, 6, 7, 4, 2, 4, 56 };
        if (MethodIsNumber(array))
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (MethodChetnoe(array[i]))
                {
                    System.Console.WriteLine(string.Join(",", array[i]));
                }
            }
        }
    }
    static int MethodChetnoe(int[] array)
    {
        int result;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 = 0)
            {
                result = string.Join(",", array[i])
            }
        }
        return result
    }
    #endregion
    #region Задача11
    // 11. На входе число. Необходимо создать метод,возвращающий факториал числа. Пример фактериала 4! = 1 * 2 * 3 * 4
    static void Task12()
    {
       
    }
    static int MethodFakterial(string text)
    {
         string? text = Console.ReadLine();
        if (int.TryParse(consoleText, out int number) && number > 0)
        {
            int result = 1;
            for (int i = 0; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
    #endregion
    #region Задача12
    // 12. На входе строка. Необходимо создать метод, возвращающий true, если это слово палиндром и false в противном случае
    #endregion
    #region Задача13
    // 13. На входе строка. Необходимо создать метод, возвращающий true, если это слово анаграмма и false в противном случае
    #endregion
    #region Задача14
    // 14. Реализовать метод возвращающий разность между НОК и НОД для двух чисел 15. Реазуйте методы перевода чисел из десятичной системы счисления в 2-ую и 16-ую
    #endregion
}