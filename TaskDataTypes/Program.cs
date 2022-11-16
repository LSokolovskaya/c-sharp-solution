// 1. Пользователь вводит границы интервала из которого программа загадывает число. Написать программу по поиску 
// данного числа. Пользователь пишиет число в консоль, а программа отвечает.
{
    System.Console.WriteLine("Введите нижнюю границу интервала");
    int minNumber = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите верхнюю границу интервала");
    int maxNumber = Convert.ToInt32(Console.ReadLine());
    int randomNumber = new Random().Next(minNumber, maxNumber);
    for (int i = 0; randomNumber >= minNumber && randomNumber <= maxNumber; i++)
    {
        System.Console.WriteLine("Угадайте число в заданном вами диапазоне. И пусть удача всегда будет на вашей стороне.");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= minNumber && number <= maxNumber)
        {
            if (number == randomNumber)
            {
                System.Console.WriteLine("Поздравляю! Ты угадал!!!");
                break;
            }
            else
            {
                System.Console.WriteLine("Печаль =( Попробуй еще раз");
            }
        }
        else
        {
            System.Console.WriteLine("Ты что, забыл диапазон, который сам ввел? Не смешно.");
        }
    }
}


// 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и остальных символов.
// {
//     System.Console.WriteLine("Введите строку");
//     string? text = Console.ReadLine();
//     text = text?.Trim();
//     int resultString = 0;
//     int resultSpace = 0;
//     int resultNumber = 0;
//     int resultOther = 0;
//     if (!string.IsNullOrEmpty(text))
//     {
//         for (int i = 1; i < text?.Length; i++)
//         {
//             if (!char.IsDigit(text[i]))
//             {
//                 resultString += i;
//                 // System.Console.WriteLine(i);
//             }
//             else if (string.Join(text[i]))
//             {
//                 resultSpace += i;
//                 // System.Console.WriteLine(resultSpace);
//             }
//             // else if (int.TryParse(text, out number))
//             // {
//             //     resultNumber += i;
//             // }
//             // else
//             // {
//             //     resultOther += 1;
//             // }
//         }

//         // System.Console.WriteLine($"Колличество букв: {resultString}");
//         // , колличество пробелов: {resultSpace}, колличество цтфр: {resultNumber}, Колличество букв: {resultOther}");
//     }
//     else
//     {
//         System.Console.WriteLine("Пусто...");
//     }
// }

// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в массив и вывести через символ, который cкажет пользователь.


// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда Фиббоначи. Вывести весь этот ряд записанный в массив.
// System.Console.WriteLine("Введите индекс последнего элемента ряда Фибоначчи");
// Char? simbol = Convert.ToChar(Console.ReadLine());
int number = int.Parse(Console.ReadLine);
for(int i = 0; i ==1 ;i++)
// int[] fibonachi = new 


// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить пробелы символом ‘/’.
//  Если пользователь ввел символ вопрос ‘?’ он может быть только один и после него пробелы должны заменены на ‘=‘, все большие буквы 
// заменить на маленькую и перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-меня- все=получится


// 6. Проработать 7 раздличных методов char и описать через коментарий, что делает данный метод, его входные параметры и выходные данные


// 7. Проработать 10 раздличных методов string и описать через коментарий, что делает данный метод, его входные параметры и выходные данные
