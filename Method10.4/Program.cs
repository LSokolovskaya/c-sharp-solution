// int[] arrays1 = new int[5] { 1, 2, 3, 5, 6 };
// bool[] arrays2 = new bool[3];
// int[] arrays3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
// string arrays4 = new[] {"1", "2"}

// Как изменить порядок элементов в строке на обратный без использования вспомогательных классов и методов?
// string text = "qwertyuio";
// string result = ;
// for (int i = 0; i <= text.Length; i++)
// {
//     if()
// }



// Как определить позиции дублированного элемента и его значение в массиве, в котором содержатся 
// все элементы типа int от 1 до 100, при этом в массиве только один элемент дублируется?
// (массив не надо заполняит значениями, массив со значениями уже объялен и передается в метод)

static string MethodIndex(int[] arrays)
{
    string index = "";
    for (int i = 0; i <= arrays.Length; i++)
    {
        if (arrays[i] == arrays[i] + 1)
        {
            index += i;
        }
    }
    return index;
}