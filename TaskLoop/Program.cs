//Найти разницу значений массива из 5 элементов 
int[] items = new int[5] { 48, -43, -41, -19, 95 }; //наш массив с 5-ю значениями

int difference = 0; //объявили переменную difference, которая  будет хранить разность элементов  массива

//мы можем по элементно произвести заность всех элементов масства
difference -= items[0];
difference -= items[1];
difference -= items[2];
difference -= items[3];
difference -= items[4];
System.Console.WriteLine(difference);


difference = 0; //обнулили переменную difference, которая  будет хранить разность элементов  массива

for (int i = 0; i < items.Length; i++)
{
    difference -= items[i];
}
System.Console.WriteLine(difference);

//Необходимо почитать разность элементов массива(primer)
{
    //массив с 5 цифрами
    object[] items = new object[6] { 48, -43, -41, -19, 95, 43 };
    //объявили переменную
    int difference = 0;
    //объявление счетчика
    int index = 0;
    //items[0] is int number1 ? number1 : default;
    //is int проверяет может ли элемент массива быть приведен к типу int, 
    //если может приведенное значение записывается в новую переменную number1,
    //противном случае default. default равен значению по умолчанию для данного типа данных
    //аналогична int.TryParse(items[1].ToString(), out int number1) ? number1 : default; 
    //TryParse не может принимать тип object для этого приводим элемент массива к строке 
    //используя метод *.ToString() который является базовым для всех типов данных 
    difference -= items[index++] is int number0 ? number0 : default;
    difference -= items[index++] is int number1 ? number1 : default;
    difference -= items[index++] is int number2 ? number2 : default;
    difference -= items[index++] is int number3 ? number3 : default;
    difference -= items[index++] is int number4 ? number4 : default;
    difference -= items[index++] is int number5 ? number5 : default;
    // Перепишем через цикл for
    object[] items = new object[6] { 48, -43, -41, -19, 95, 43 };
    int difference = 0;
    for (int i = 0; i < items.Length; i++)
    {
        difference -= items[i] is int number ? number : default;
    }
}


{//Рассчитать сумму интервала чисел от 1 до рандомного числа (от 55 до 777)
 //по следующей формуле: число кратно 4 записываем целочисленную часть от деления в результирующую сумму
 //если число кратно 10 прибавляем предыдущее число в результирующую сумму, все остальные числа прибаляем в
 //результирующую сумму. Для чисел кратных 3 игнорировать выполнения цикла. Если число равно 451 прервать
 //суммирование чисел
 //new Random().Next(55, 777); генерация рандомного числа
    int number = new Random().Next(55, 777);
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        if (i == 451)
        {
            //Выход из цикла если i имеет значение 451
            break;
        }
        else if (i % 3 == 0)
        {
            //Переходим на новую итерацию цикла i++
            continue;
        }
        else if (i % 4 == 0)
        {
            result += i / 4;
        }
        else if (i % 10 == 0)
        {
            result += i - 1;
        }
        else
        {
            result += i;
        }
    }
    Console.WriteLine(result);
}

// ____________________________________________________
// {
//     int number = 5;
//     object item = number;
// string text = “text”;
// item = text;
// char symbol = ‘?’;
// item = symbol;
// bool value = true;
// item = value;

// }

{
    var random = new Random();
    int result = random.Next(3, 4);
    // Convert.ToInt32()
}

{
    int number = 5;
    object item = number;
    System.Console.WriteLine(item.GetType());
    string text = "text";
    item = text;
    System.Console.WriteLine(item.GetType());
    char symbol = '?';
    item = symbol;
    System.Console.WriteLine(item.GetType());
    bool value = true;
    item = value;
    System.Console.WriteLine(item.GetType());
}

{
    object item1 = 5.0;
    //подходит если вы уверены на 100%, что item это число
    double number1 = Convert.ToDouble(item1);
    object item2 = 4;
    //происходит проверка на тип данных, если к такому типу данных привести 
    //возможно возвращаем число, в противном случае значение по умолчанию
    int number2 = item2 is int number ? number : default;
}

{
    object item2 = "5";
    int number2;

    if (item2 is int number)
    {
        number2 = number;
    }
    else
    {
        number2 = default;
    }
    System.Console.WriteLine(number2);
}

// переменная is тип_данных новая_переменная_типа_данных

{
    //2 object, если 2 стринг - сумму длинн их, если 2 инта - сумму интов, если нет сообщение - всё плохо))))
    object obj1 = 23;
    object obj2 = 56;
    if (obj1 is string string1 && obj2 is string string2)
    {
        System.Console.WriteLine(string1.Length + string2.Length);
    }
    else if (obj1 is int int1 && obj2 is int int2)
    {
        System.Console.WriteLine(int1 + int2);
    }
    else { System.Console.WriteLine("Всё плохо"); }
}

{
    var random = new Random();
    random.Next(3, 4);
}


{
    int number = 5;
    System.Console.WriteLine(number.ToString().GetType());
    bool value = true;
    System.Console.WriteLine(value.ToString().GetType());
}

{
    string text = "\\\"";
    Console.WriteLine(text);
}

{
    string text1 = null;
    //равнозначно
    string? text2 = null;
}

// у нас есть строка,где для всех букв произвести следующие операции, 
// если код этой буквы равен простому числу-то суммируем если нет -игнорируем
System.Console.WriteLine("введите строку");
string? userText = Console.ReadLine();
if (!string.IsNullOrEmpty(userText))
{
    int result = 0;
    foreach (char let in userText)
    {
        // if (!char.IsLetter(let))
        // {
        //     continue;
        // }
        // int number = +let;
        // // int number = Convert.ToInt32(let);
        // bool isSimpleNumber = true;
        // for (int i = 2; i <= number / 2; i++)
        // {
        //     if (number % i == 0)
        //     {
        //         isSimpleNumber = false;
        //         break;
        //     }
        // }
        // if (isSimpleNumber)
        // {
        //     // прибавляем с результату значение
        //     result += number;
        // }
        if (char.IsLetter(let)) //наш символ является не буквой?
        {
            continue; //игнорируем дальнейшее выполнение цикла
        }
        int number = +let; //преобразуем char в int c использованием +

        bool isSimpleNumber = true; //объявили переменную которая указывает что число простое
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0) //проверяем на целочисленное деление числа number
            {
                isSimpleNumber = false; //меняем значение в переменной на false тем самым показывая что число не простое 
                break; //выход из цикла, дальнейшие итерации выполняться не будут
            }
        }

        if (isSimpleNumber) //если после после цикла перменная истина (true)
        {
            result += number; //прибавляем простое число
        }
    }
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Null");
}


int number = +let;
        // int number = Convert.ToInt32(let);
        bool isSimpleNumber = true;
        for (int i = 2; i <= number / 2 && isSimpleNumber; i++)
        {
            isSimpleNumber = number % i == 0;
        }


{
    string text = "vsdbhgfsnhgdgs";
    for (int i = 0; i < text.Length; i++)
    {
        //text[i]
    }
    foreach (char let in text)
    {
        //text[i] == let true
    }
}

//вводим строку, мен]ем верхний регистр на нижний и наоборот. Цифры удвляем
{
    System.Console.WriteLine("vvedyte chislo");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string result = "";
        foreach (char item in text)
        {
            if (char.IsUpper(item))
            {
                result += char.ToLower(item);
            }
            else if (char.IsLower(item))
            {
                result += char.ToUpper(item);
            }
            else if (!char.IsDigit(item))
            {
                result += item;
            }
        }
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("error");
    }

}