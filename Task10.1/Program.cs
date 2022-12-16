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
            // Task6();
            // Task7();
            Task8();
        }
        #region Task1
        // 1. На входе дано три массива заполненных случайными числами. Написать метод по подсчёту общего количества чётных чисел в массивах. (ref)
        static void Task1()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 7, 8, 95, 4 };
            int[] array2 = { 2, 35, 7, 3, 4, 79, 88 };
            int[] array3 = { 234, 34, 45, 6, 54, 32, 4, 56 };
            int result = 0;
            System.Console.WriteLine(KolichestvoChet(array1, array2, array3, ref result));

        }
        static int KolichestvoChet(int[] array1, int[] array2, int[] array3, ref int result)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                result = array1[i] % 2 == 0 ? result + 1 : result + 0;
            }
            for (int i = 0; i < array2.Length; i++)
            {
                result = array1[i] % 2 == 0 ? result + 1 : result + 0;
            }
            for (int i = 0; i < array3.Length; i++)
            {
                result = array1[i] % 2 == 0 ? result + 1 : result + 0;
            }
            return result;
        }
        #endregion
        #region Task2
        // 2. Написать метод, который проверяет является ли введнная строка почтовым адрессом и возвращающий домен почты.(out)
        static void Task2()
        {
            System.Console.WriteLine("Введите почтовый адрес");
            string? mail = Console.ReadLine();
            System.Console.WriteLine(Mail(mail, out string domen));
            System.Console.WriteLine(domen);
        }
        static bool Mail(string mail, out string domen)
        {
            domen = "";
            bool result = false;
            if (mail.EndsWith("@gmail.com"))
            {
                result = true;
                domen = "@gmail.com";
            }
            else if (mail.EndsWith("@mail.ru"))
            {
                result = true;
                domen = "@mail.ru";
            }
            else if (mail.EndsWith("@yandex.ru"))
            {
                result = true;
                domen = "@yandex.ru";
            }
            else
            {
                result = false;
                domen = "";
            }
            return result;
        }
        #endregion
        #region Task3
        // 3. Написать метод, который удаляет из строки заданный символ. Символ является входным параметром-значением. Строка должна быть параметром-ссылкой и результатом. (ref)
        static void Task3()
        {
            System.Console.WriteLine("Введите символ, который хотите удалить");
            string simbol = Console.ReadLine();
            //ОБЯЗАТЕЛЬНО ВЫБИРАЙ СИМВОЛ Z
            string text = "";
            if (!string.IsNullOrEmpty(simbol))
            {
                System.Console.WriteLine(MethodDelete(simbol, ref text));
            }
            else
            {
                System.Console.WriteLine("empty");
            }
        }
        static string MethodDelete(string simbol, ref string text)
        {
            text = "Тzыz zклаzсzсzнzыzйz zиz zуz zтzеzбzя zвсzеz zпоzлzуzчzиzтzсяz,z zхzорzоzшzеzгоz zдzнzя";
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() != simbol)
                {
                    result += text[i];
                }
            }
            text = result;
            return text;
        }
        #endregion
        #region Task4
        // 4. Написать метод выполняющий сложение парметов, если параметры одного типа данных возвращать true и результат сложение, в противном случае false (out)
        static void Task4()
        {
            string text1 = "qwe";
            string text2 = "fghj";
            System.Console.WriteLine(MethodSum(text1, text2, out string result));
        }
        static string MethodSum(string text1, string text2, out string result)
        {
            result = text1 is string && text2 is string ? text1 + text2 :
                text1 is int && text2 is int ? text1 + text2 : "error";
            return result;
        }
        #endregion
        #region Task5
        // 5. Пользователь вводит строку и разделитель. Написать метод возвращающий наличие в строке разделителя,
        //  если разделитель есть, то вернуть строку разбитую данным разделителем (out)
        static void Task5()
        {
            System.Console.WriteLine("Введите строку");
            string? text = Console.ReadLine();
            System.Console.WriteLine("Введите сепаратор");
            string? separator = Console.ReadLine();
            if (!string.IsNullOrEmpty(separator) && !string.IsNullOrEmpty(text))
            {
                System.Console.WriteLine(MethodSeparator(text, separator, out string result));
            }
            else
            {
                System.Console.WriteLine("Empty");
            }
        }
        static string MethodSeparator(string text, string separator, out string result)
        {
            result = "";
            if (text.Contains(separator))
            {
                result = string.Join(' ', text.Split(separator));
            }
            return result;
        }
        #endregion
        #region Task6
        // 6. Написать метод возвращающий разность между найбольшим и наименьшим значением из списка. Результат 
        // разности возращать через out, метод для поиска минимального и максимального написать с использованием params
        static void Task6()
        {
            int[] array = new int[] { 1, 2, 3, 4, 6, 8, 8, 6, 2, 45, 67, 8, 5, 34 };
            int result = 0;
            System.Console.WriteLine(MaxANdMinDifference(array, out result));

        }
        static int MaxANdMinDifference(int[] array, out int result)
        {
            int minNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            int maxNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            result = maxNumber - minNumber;
            return result;
        }
        #endregion
        #region Task7
        // 7. Написать метод который принимает строку, если строка содержит только 0 и 1 вернуть true,
        // а 0 и 1 перевести в 10-ную систему счисления, в противном случае false (out)
        static void Task7()
        {
            string number2 = "111";
            Method10(number2, out double number10, out bool result);
            System.Console.WriteLine($"{result}, {number10}");
        }
        static string Method10(string number2, out double number10, out bool result)
        {
            number10 = 0;
            result = true;
            for (int i = 0; i < number2.Length; i++)
            {
                if (number2[i] == '1')
                {
                    result = true;
                    number10 += Math.Pow(2, i);
                }
                else if (number2[i] != '1' || number2[i] != '0')
                {
                    result = false;
                }
            }
            return Convert.ToString(result);
            return Convert.ToString(number10);
        }
        #endregion
        #region Task8
        // 8. На входе метода набор 0 и 1 перевести в 16-ную систему счисления (params)
        static void Task8()
        {
            string number2 = "1111";
            string number16 = "";
            Method16(number2,out number16, out string result);
            System.Console.WriteLine($"{result}, {number16}");
        }
        static string Method16(string number2, out string number16, out string result)
        {
            number16 = "0";
            result = "true";
            for (int i = Convert.ToString(number2).Length - 1; i >= 0; i--)
            {
                if (number2[i] == '1')
                {
                    result = "true";
                    number16 = Convert.ToString(Convert.ToDouble(number16) + Math.Pow(2, i));
                    if (Convert.ToInt32(number16) > 9)
                    {
                        if (number16 == "10")
                        {
                            number16 = "A";
                        }
                        else if (number16 == "11")
                        {
                            number16 = "B";
                        }
                        else if (number16 == "12")
                        {
                            number16 = "C";
                        }
                        else if (number16 == "13")
                        {
                            number16 = "D";
                        }
                        else if (number16 == "14")
                        {
                            number16 = "E";
                        }
                        else if (number16 == "15")
                        {
                            number16 = "F";
                        }
                    }
                }
                else if (Convert.ToChar(number2[i]) != '1' || number2[i] != '0')
                {
                    result = "false";
                    number16 = "";
                }
            }
            return result;
            return number16;
        }
        #endregion
    }
}












// string number2 = "111";
// // int[] number2 = new int[] { 1, 1, 1 };
// double number10 = 0;
// bool result = false;
// for (int i = 0; i < number2.Length; i++)
// {
//     int l = Convert.ToInt32(number2[i]);
//     if (l == 1)
//     {
//         result = true;
//         number10 += Math.Pow(2, i);
//     }
//     if (l != 1 || number2[i] != 0)
//     {
//         result = false;
//     }
// }
// System.Console.WriteLine(number10);


// string text = "1";
// int i = Convert.ToInt32(text);
// i += 2;
// System.Console.WriteLine(i);
