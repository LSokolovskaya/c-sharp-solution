namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
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
            Mail(mail, out bool result, out string domen);
            System.Console.WriteLine($"{result},{domen}");
        }
        static string Mail(string mail, out bool result, out string domen)
        {
            domen = "";
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
            return result.ToString();
            return domen;
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
            // #region Task4
            // // 4. Написать метод выполняющий сложение парметов, если параметры одного типа данных возвращать true и результат сложение, в противном случае false (out)
            // static void Task4()
            // {
            //     object number1 = 4;
            //     object number2 = 6;
            //     object text1 = "qwe";
            //     object text2 = "fghj";
            //     System.Console.WriteLine(MethodSum(number1, number2, text1, text2, out object result));
            // }
            // static object MethodSum(object number1, object number2, object text1, object text2, out object result)
            // {

            // }
            // #endregion
            #region Task5
            // 5. Пользователь вводит строку и разделитель. Написать метод возвращающий наличие в строке разделителя, если разделитель есть вернуть строку разбитую данным разделителем (out)
            static void Task5()
            {
                System.Console.WriteLine("Введите строку");
                string text = Console.ReadLine();
                System.Console.WriteLine("Введите сепаратор");
                string separator = Console.ReadLine();
            }
            #endregion
            #region Task6
            // 6. Написать метод возвращающий разность между найбольшим и наименьшим значением из списка. Результат разности возращать через out, метод для поиска минимального и максимального написать с использованием params

            #endregion
            #region Task7
            // 7. Написать метод который принимает строку, если строка содержит только 0 и 1 вернуть true, а 0 и 1 перевести в 10-ную систему счисления, в противном случае false (out)

            #endregion
            #region Task8
            // 8. На входе метода набор 0 и 1 перевести в 16-ную систему счисления (params)

            #endregion
        }
    }
}






// int BinarySearchIndex(int[] userArray, int numSearch, int indexStart, int indexEnd)
// {
//     if (indexStart > indexEnd)
//     {
//         return -1;
//     }
//     int middleIndex = (indexEnd + indexStart) / 2;

//     return numSearch == userArray[middleIndex] ? middleIndex : 
//         numSearch > userArray[middleIndex] ?
//             BinarySearchIndex(userArray, numSearch, middleIndex + 1, indexEnd) :
//             BinarySearchIndex(userArray, numSearch, indexStart, middleIndex - 1);
// }
// // [0,4] 5 ищем
// int[] userMassiv = { 1, 4, 5, 7, 8, 9, 22, 23, 25, 33, 39, 44, 46, 55, 88, 99 };
// // int[] userMassiv = { 0, 4 };
// int number = Convert.ToInt32(Console.ReadLine());
// int index = BinarySearchIndex(userMassiv, number, 0, userMassiv.Length - 1);
// System.Console.WriteLine(index);