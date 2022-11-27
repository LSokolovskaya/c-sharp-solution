// using System;

// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(CreateUser(lastName: "Clarke", firstName: "Emilia", age: 36, height: 213, weight: 234));
//         }
//         static object CreateUser(string firstName, string lastName,
//          int age, int height, double weight)
//         {
//             return $"{firstName}, {lastName}, {age}, {height}, {weight}";
//         }
//     }
// }



// static double CalculateCost(double costItem, double vat = 13, double customsDuty = 5, double tax = 10)
// {
//     vat = 1 + vat / 100;
//     customsDuty = 1 + customsDuty/100;
//     tax = 1 + tax / 100;
//     return costItem * vat * customsDuty * tax;
// }
// System.Console.WriteLine(CalculateCost(100));

// static double SumValues(double value1, double value2) => value1 + value2;
// равнозначны
//     static double SumValues(double value1, double value2)
//     {
//         return value1 + value2;
//     }



// static int SumTwoArrays(int length)
// {
//     var array1 = CreateArray();
//     var array2 = CreateArray();

//     return SumArrays(array1, array2);

//     int[] CreateArray()
//     {
//         int[] array = new int[length];
//         var random = new Random();
//         for (int i = 0; i < length; i++)
//         {
//             array[i] = random.Next(-100, 100);
//         }
//         return array;
//     }

//     static int SumArrays(int[] array1, int[] array2)
//     {
//         int sum = 0;
//         for (int i = 0; i < array1.Length; i++)
//         {
//             sum += array1[i] + array2[i];
//         }
//         return sum;
//     }
// }



// /Task1 10,2------------------------------------
// // Написать методы с ипользованием лямбда-оператора по выполнению
// // арифметических операций (+, -, /, *, % и другие). Вызов данных методов произвести
// // с использованием тернарного switch в методе.

// // using System;

// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             int number1;
//             number1 = 5;
//             int number2 = 13;
//             string opr = "+";

//             System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
//             // System.Console.WriteLine(MethodSum(number1, number2));
//             // System.Console.WriteLine(MethodDeference(number1, number2));
//             // System.Console.WriteLine(MethodMultiplication(number1, number2));
//             // System.Console.WriteLine(MethodDivision(number1, number2));
//         }

//         static int MethodSum(int number, int number1) => number + number1;
//         static int MethodDeference(int number, int number1) => number - number1;
//         static int MethodMultiplication(int number, int number1) => number * number1;
//         static int MethodDivision(int number, int number1) => number / number1;

//         static string Switch(int number1, int number2, string opr) => opr switch
//         {
//             "+" => MethodSum(number1, number2).ToString(),
//             "-" => MethodDeference(number1, number2).ToString(),
//             "*" => MethodMultiplication(number1, number2).ToString(),
//             "/" => MethodDivision(number1, number2).ToString(),
//             _ => string.Format("No resultations {0}", opr)
//         };
//     }
// }