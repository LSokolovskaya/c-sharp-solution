using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            Task6();
            // Task7();

        }

        #region Task4
        static void Task4()
        {
            // 4. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная степень двойки», если число является точной степенью 
            // двойки, или «Не являеться степенью двойки», в противном случае используя рекурсию.
            int number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(Degree2(number));
        }
        static string Degree2(int number)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
                return Degree2(number);
            }
            else if (number == 1)
            {
                return $"точная степень двойки";
            }
            else
            {
                return "не является точной степенью двойки";
            }
        }
        #endregion
        #region Task5
        static void Task5()
        {
            // 5. Написать метод возвращающий индекс максимального и минимального значения массива (два способа используя кортеж и out).
            int[] array1 = new int[] { 1, 0, 657, 5, 35, 555, 4 };
            int resultMax = 0;
            int resultMin = 0;
            NumberMaxMin(array1, out resultMax, out resultMin);
            System.Console.WriteLine(NumberMaxMinOverflow(array1));
        }
        static void NumberMaxMin(int[] array, out int resultMin, out int resultMax)
        {
            int min = array[0];
            int max = min;
            resultMin = 0;
            resultMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    resultMin = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    resultMax = i;
                }
            }
            System.Console.WriteLine($"Индекс минимального значения {resultMin}, индекс максимального значения {resultMax}");
        }
        static (int, int) NumberMaxMinOverflow(int[] array)
        {
            int min = array[0];
            int max = min;
            int resultMin = 0;
            int resultMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    resultMin = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    resultMax = i;
                }
            }
            return (resultMin, resultMax);
        }
        #endregion
        #region Task6
        static void Task6()
        {
            // 6. На входе 2 числа, написать метод по замене местами чисел в переменных, если первое число кратно двум, второе не кратно 
            // и первое число меньше второго (результат вернуть в виде кортежа)
            int number1 = 4;
            int number2 = 5;
            System.Console.WriteLine(ChangeNumbers(number1, number2));
        }
        static (int, int) ChangeNumbers(int number1, int number2)
        {
            int result = number1;
            if (number1 % 2 == 0 && number2 % 2 != 0 && number1 < number2)
            {
                number1 = number2;
                number2 = result;
            }
            return (number1, number2);
        }
        #endregion
    }
}




// 1. Написать метод, рассчитывающий число из рада Фиббоначчи используя рекурсию
// 2. Дано натуральное число (вводится с клавиатуры). Вычислите сумму его цифр используя рекурсию
// 3. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите все простые делители этого числа используя рекурсию
// 4. Дано натуральное число больше1 (вводитсясклавиатуры). Выведите «Точная степень двойки», если число является точной степенью 
// двойки, или «Не являеться степенью двойки», в противном случае используя рекурсию.
// 6. На входе 2 числа, написать метод по замене местами чисел в переменных, если первое число кратно двум, второе не кратно 
// и первое число меньше двух (результат вернуть в виде кортежа)
// 7. Дана строка. Написать метод по подсчёту количеству вхождений символа (подстроки). Метод возвращает символ (подстроку),
//  количество вхождений, перое и последнее вхождение в строку. (использовать IndexOf, LastIndexOf, Split и тд запрещено)