namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            Task3();
            // Task4();
        }
        #region Task1
        // 1. Написать методы с ипользованием лямбда-оператора по выполнению
        // арифметических операций (+, -, /, *, % и другие). Вызов данных методов произвести
        // с использованием тернарного switch в методе.
        static void Task1()
        {
            int number1;
            number1 = 5;
            int number2 = 13;
            string opr = "+";

            System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
            // System.Console.WriteLine(MethodSum(number1, number2));
            // System.Console.WriteLine(MethodDeference(number1, number2));
            // System.Console.WriteLine(MethodMultiplication(number1, number2));
            // System.Console.WriteLine(MethodDivision(number1, number2));
        }
        static int MethodSum(int number, int number1) => number + number1;
        static int MethodDeference(int number, int number1) => number - number1;
        static int MethodMultiplication(int number, int number1) => number * number1;
        static int MethodDivision(int number, int number1) => number / number1;

        static string Switch(int number1, int number2, string opr) => opr switch
        {
            "+" => MethodSum(number1, number2).ToString(),
            "-" => MethodDeference(number1, number2).ToString(),
            "*" => MethodMultiplication(number1, number2).ToString(),
            "/" => MethodDivision(number1, number2).ToString(),
            _ => string.Format("No resultations {0}", opr)
        };
        #endregion
        #region Task2
        // 2. Написать метод по рассчету средней скорости на участке и выводе сообщения превысил водитель 
        // скорость или нет. Метод должен принимать во сколько водитель въехал в участок контроля скорости 
        // и время во сколько выехал из участка, в виде HH:MM:SS, длинну участка контроля скорости и среднюю допустимую скорость участка
        // В задаче использовать необязательные парметры, локальные методы.
        static void Task2()
        {

        }
        static double Speed(double timeStart = 2, double timeEnd = 8)
        {

        }
        #endregion
        #region Task3
        // 3. Написать метод увеличению размера массива и заполнения его значениями
        // В задаче использовать необязательные парметры, локальные методы.
        static void Task3()
        {
            int[] array1 = new int[1] { 4 };
            int[] array2 = new int[3] { 12, 4, 4 };
            int[] arrayResult = new int[8];
            ArrayRise(array1, array2, arrayResult);
            System.Console.WriteLine(string.Join(',', arrayResult));
        }
        static int[] ArrayRise(int[] array1, int[] array2, int[] arrayResult, int arrayLength = 1, int arrayLength1 = 3)
        {
            Arraynew();
            int[] Arraynew()
            {
                Array.Copy(array1, arrayResult, array1.Length);
                array1.CopyTo(arrayResult, 1);
                System.Console.WriteLine(arrayResult[0]);
                System.Console.WriteLine(arrayResult[1]);
                System.Console.WriteLine(arrayResult[2]);
                System.Console.WriteLine(arrayResult[3]);
                return arrayResult;
            }
            return arrayResult;
        }
        #endregion
        #region Task4
        // 4. Написать метод по расчету корней квадратного уравнения с использованием
        // локального метода

        #endregion

    }
}