// // // 1. Пользователь вводит границы интервала из которого программа загадывает число. Написать программу по поиску 
// // // данного числа. Пользователь пишиет число в консоль, а программа отвечает.
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

// // 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и остальных символов.
// {
//     System.Console.WriteLine("Введите строку");
//     string? text = Console.ReadLine();
//     int resultString = 0;
//     int resultSpace = 0;
//     int resultNumber = 0;
//     int resultOther = 0;
//     if (!string.IsNullOrEmpty(text))
//     {
//         foreach (var item in text)
//         {
//             if (char.IsLetter(item))
//             {
//                 resultString++;
//             }
//             else if (char.IsNumber(item))
//             {
//                 resultNumber++;
//             }
//             else if (char.IsWhiteSpace(item))
//             {
//                 resultSpace++;
//             }
//             else
//             {
//                 resultOther++;
//             }
//         }
//         System.Console.WriteLine($"Колличество букв: {resultString}, колличество пробелов: {resultSpace}, колличество цифр: {resultNumber}, другие символы: {resultOther}");
//     }
//     else
//     {
//         System.Console.WriteLine("Пусто...");
//     }
// }


// // 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в массив и вывести через символ, который cкажет пользователь.
// {
//     System.Console.WriteLine("введите строку");
//     string? text = Console.ReadLine();
//     System.Console.WriteLine("введите символ");
//     char? symbol = Convert.ToChar(Console.ReadLine());
//     // System.Console.WriteLine("Введите символ, через который хотите вывести массив");
//     // string? sign = Console.ReadLine();
//     string index = "";
//     if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(Convert.ToString(symbol)))
//     {
//         System.Console.WriteLine("Введите символ, через который хотите вывести массив");
//         string? sign = Console.ReadLine();
//         for (int i = 0; i < text.Length; i++)
//         {
//             if (symbol == text[i])
//             {
//                 index = string.Join(Convert.ToString(i), sign);
//                 // index = String.Concat($"{index}", Convert.ToString(i), sign);
//             }
//         }
//         // System.Console.WriteLine(string.Join(sign, index));
//         System.Console.WriteLine(index);
//     }
//     else
//     {
//         System.Console.WriteLine(("Пусто..."));
//     }
// }


// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда Фиббоначи. Вывести весь этот ряд записанный в массив.
//EndsWith
// {
//     System.Console.WriteLine("введите число, которое является индексом последнего элемента ряда Фиббоначи");
//     int index = Convert.ToInt32(Console.ReadLine());
//     int a = 0;
//     int b = 1;
//     int[] result = new int[index];
//     for (int i = 2; i < index; i++)
//     {
//         result[i - 2] = a;
//         result[i - 1] = b;
//         result[i] = a + b;
//         a = b;
//         b = result[i];
//     }
//     System.Console.WriteLine(string.Join(' ', result));
// }

// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить пробелы символом ‘/’.
//  Если пользователь ввел символ вопрос ‘?’ он может быть только один и после него пробелы должны заменены на ‘=‘, все большие буквы 
// заменить на маленькую и перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-меня- все=получится
// {
//     string text = "ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится";
//     string result = "";
//     if (!string.IsNullOrEmpty(text))
//     {
//         bool answer = true;
//         // text = text.ToLower();
//         for (int i = 0; i < text.Length; i++)
//         {
//             if (char.IsLetter(text[i]))
//             {
//                 result += text[i];
//             }
//             if (text[i] == ' ')
//             {
//                 result += "/";
//             }
//             if (text[i] == '?' && answer)
//             {
//                 result += "/";
//                 answer = false;
//             }
//             if (char.IsUpper(text[i]))
//             {
//                 // result = (result.Replace(text[i], Convert.ToChar("-")));
//                 // result += text[i];
//             }
//         }
//         System.Console.WriteLine(result);
//     }
//     else
//     {
//         System.Console.WriteLine("error");
//     }
// }

// 6. Проработать 7 раздличных методов char и описать через коментарий, что делает данный метод, его входные параметры и выходные данные
{

}
// 7. Проработать 10 раздличных методов string и описать через коментарий, что делает данный метод, его входные параметры и выходные данные
// {
    // string textFirst = "qwertyuiop[]asdfghjkl;'zxcvbnm,./1234567890";
    // string textSecond = "wertyuildvbqr62903tedfvnsfktujwergnadfmv";
//     //1 аналог интерполяции, можно добавить много строк
//     System.Console.WriteLine(string.Format(textFirst, "FGJJH", "WER", "1234"));
//     //2 для сранения строк(вместо него можно использовать ==)
//     System.Console.WriteLine(textFirst.Equals(textSecond));
//     //3 ищет подстроку, если находит, то выводит индекс первого вхождения подстроки, в противном случае -1
//     System.Console.WriteLine(textFirst.IndexOf("h"));
//     //4 ищет подстроку, если находит, то выводит индекс вхождения подстроки с конца, в противном случае -1
//     System.Console.WriteLine(textFirst.LastIndexOf("h"));
//     //5 проверяет начинаетмся ли строка с подстроки
//     System.Console.WriteLine(textFirst.StartsWith("qwer"));//true
//     System.Console.WriteLine(textFirst.StartsWith("fgh"));//false
//     //6 проверяет заканчивается ли строка подстрокой
//     System.Console.WriteLine(textFirst.EndsWith("890"));//true
//     System.Console.WriteLine(textFirst.EndsWith("fgh"));//false
//     //7 убирает пробелы с начала и конца
//     System.Console.WriteLine(textFirst.Trim());
//     //8 проверияет на пустоту или пробел
//     System.Console.WriteLine(string.IsNullOrWhiteSpace(" "));//false
//     System.Console.WriteLine(string.IsNullOrWhiteSpace(""));//true
//     //9 разбивает строку на части
//     System.Console.WriteLine(textFirst.Split(' '));//разбил по пробелам
//     System.Console.WriteLine(textFirst.Split("a"));//разбил по "a"
//     System.Console.WriteLine(textFirst.Split("k").Length);//Разбил по "k" и указал количество подстрок
//     //10 встречается ли символ(подстрока) в строке
    // System.Console.WriteLine(textFirst.Contains("g"));//true
    // System.Console.WriteLine(textFirst.Contains("!"));//false
//     //11 возвращет строку с удаленными символами(указывается с какой позиции
//     //  удалить или интервал с какой по какую позицию удалять)
//     System.Console.WriteLine(textFirst.Remove(5));
//     System.Console.WriteLine(textFirst.Remove(2,5));
//     //12заменяет один символ на другой, сначала указывается какой символ заменить,
//     // а потом на какой заменить
//     System.Console.WriteLine(textFirst.Replace("g","s"));
// }
