// // 1. Пользователь вводит границы интервала из которого программа загадывает число. Написать программу по поиску 
// // данного числа. Пользователь пишиет число в консоль, а программа отвечает.
// {
//     System.Console.WriteLine("Введите нижнюю границу интервала");
//     int minNumber = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите верхнюю границу интервала");
//     int maxNumber = Convert.ToInt32(Console.ReadLine());
//     if (minNumber < maxNumber)
//     {
//         int randomNumber = new Random().Next(minNumber, maxNumber);
//         while (randomNumber >= minNumber && randomNumber <= maxNumber)
//         {
//             System.Console.WriteLine("Угадайте число в заданном вами диапазоне. И пусть удача всегда будет на вашей стороне.");
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (number >= minNumber && number <= maxNumber)
//             {
//                 if (number == randomNumber)
//                 {
//                     System.Console.WriteLine("Поздравляю! Ты угадал!!!");
//                     break;
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Печаль =( Попробуй еще раз");
//                 }
//             }
//             else
//             {
//                 System.Console.WriteLine("Ты что, забыл диапазон, который сам ввел? Не смешно.");
//             }
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Неверно введены пределы");
//     }
// }

// 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и остальных символов.
// {
//     System.Console.WriteLine("Введите строку");
//     string? text = Console.ReadLine();
//     int resultString = 0;
//     int resultSpace = 0;
//     int resultNumber = 0;
//     int resultOther = 0;
//     if (!string.IsNullOrEmpty(text))
//     {
//         for (int i = 0; i < text?.Length; i++)
//         {
//             if (char.IsLetter(text[i]))
//             {
//                 resultString += i;
//             }
//             else if (char.IsNumber(text[i]))
//             {
//                 resultNumber += i;
//             }
//             else if (char.IsWhiteSpace(text[i]))
//             {
//                 resultSpace += i;
//             }
//             else
//             {
//                 resultOther += 1;
//             }
//         }
//         System.Console.WriteLine($"Колличество букв: {resultString}, колличество пробелов: {resultSpace}, колличество цифр: {resultNumber}, другие символы: {resultOther}");
//     }
//     else
//     {
//         System.Console.WriteLine("Пусто...");
//     }
// }


// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в массив и вывести через символ, который cкажет пользователь.
{
    System.Console.WriteLine("введите строку");
    string? text = Console.ReadLine();
    System.Console.WriteLine("введите символ");
    char? symbol = Convert.ToChar(Console.ReadLine());
    // System.Console.WriteLine("Введите символ, через который хотите вывести массив");
    // string? sign = Console.ReadLine();
    string index = "";
    if (!string.IsNullOrEmpty(text))
    {
        if (!string.IsNullOrEmpty(Convert.ToString(symbol)))
        {
            System.Console.WriteLine("Введите символ, через который хотите вывести массив");
            string? sign = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (symbol == text[i])
                {
                    index =string.Join( Convert.ToString(i), sign);
                    // index = String.Concat($"{index}", Convert.ToString(i), sign);
                }
            }
            // System.Console.WriteLine(string.Join(sign, index));
            System.Console.WriteLine(index);
        }
        else
        {
            System.Console.WriteLine(("Тут тоже пусто..."));
        }
    }
    else
    {
        System.Console.WriteLine(("Пусто..."));
    }
}


// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда Фиббоначи. Вывести весь этот ряд записанный в массив.
//EndsWith
// {
// System.Console.WriteLine("Введите индекс последнего элемента ряда Фибоначчи");
// Char? simbol = Convert.ToChar(Console.ReadLine());
// int number = int.Parse(Console.ReadLine);
// int a = 0;
// int b = 1;
// for (int i = 0; i = ; i++)
// {
//     int c = a + b;
//     int d = c + b;
//     System.Console.WriteLine(d);
// }
// System.Console.WriteLine(c);
// int[] fibonachi = new 


// }

// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить пробелы символом ‘/’.
//  Если пользователь ввел символ вопрос ‘?’ он может быть только один и после него пробелы должны заменены на ‘=‘, все большие буквы 
// заменить на маленькую и перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-меня- все=получится


// 6. Проработать 7 раздличных методов char и описать через коментарий, что делает данный метод, его входные параметры и выходные данные


// 7. Проработать 10 раздличных методов string и описать через коментарий, что делает данный метод, его входные параметры и выходные данные
