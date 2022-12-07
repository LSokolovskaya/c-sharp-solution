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
            string mail = Console.ReadLine();
            System.Console.WriteLine(Mail(mail, out string result, out string domen));
        }
        static string Mail(string mail, out string result, out string domen)
        {
            domen = "";
            result = "";
            if (mail.EndsWith("@gmail.com"))
            {
                result = "true";
                domen = "@gmail.com";
            }
            else if (mail.EndsWith("@mail.ru"))
            {
                result = "true";
                domen = "@mail.ru";
            }
            else if (mail.EndsWith("@yandex.ru"))
            {
                result = "true";
                domen = "@yandex.ru";
            }
            else
            {
                result = "false";
                domen = "";
            }
            return result;
            return domen;
        }
        #endregion
        #region Task3
        // 3. Написать метод, который удаляет из строки заданный символ. Символ является входным параметром-значением. Строка должна быть параметром-ссылкой и результатом. (ref)
        // static void Task3()
        // {
        //     System.Console.WriteLine("Введите символ, который хотите удалить");
        //     char? simbol = Convert.ToChar(Console.ReadLine());
        //     System.Console.WriteLine(MethodDelete(char simbol, ref string text));
        // }
        // static string MethodDelete(char simbol, ref string text)
        // {
        //     text = "Тzыz zклаzсzсzнzыzйz zиz zуz zтzеzбzя zвсzеz zпоzлzуzчzиzтzсяz,z zхzорzоzшzеzгоz zдzнzя";
        //     string result = "";
        //     for (int i = 0; i < text.Length; i++)
        //     {
        //         result = text[i] != simbol ? result + text[i] : "";
        //     }
        //     return result;
        // }
        #endregion
        #region Task4
        // 4. Написать метод выполняющий сложение парметов, если параметры одного типа данных возвращать true и результат сложение, в противном случае false (out)

        #endregion
        #region Task5
        // 5. Пользователь вводит строку и разделитель. Написать метод возвращающий наличие в строке разделителя, если разделитель есть вернуть строку разбитую данным разделителем (out)

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

