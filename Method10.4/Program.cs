// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// //если первое больше второг то поменять местами
// if (number1 > number2)
// {
//     int result1 = number1;
//     number1 = number2;
//     number2 = result1;
// }
// System.Console.WriteLine(number1);
// System.Console.WriteLine(number2);

static void Task()
{
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(Method());
    static ‹string Method()
    {
        if (number % 2 == 0)
        {
            return "четное";
        }
        else
        {
            return "нечетное";
        }
    }
}