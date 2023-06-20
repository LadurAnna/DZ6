// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 41: Пользователь вводит с клавиатуры
//  M чисел. Посчитайте, сколько чисел больше 0
//   ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
 
//  int Prompt(string message)
//  {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
//  }
//  int[] InputArray(int length)
//  {
//    int[] array = new int[length];
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = Prompt($"Введите {i + 1}-й элемент");
//    }
//    return array;
//  }
//  void PrintArray(int[] array)
//  {
//    for (int i = 0; i< array.Length; i++)
//    {
//       Console.WriteLine($"a[{i}] = {array[i]}");
//    }
//  }
//  int CountPositiveNumbers(int[] array)
//  {
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0)
//       {
//          count++;
//       }
//    }
//    return count;
//  }
//  int length = Prompt("Введите количество элементов >");
//  int[] array;
//  array = InputArray(length);
//  PrintArray(array);
//  Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");
// ___________________________________________
// Напишите программу, которая найдёт точку
//  пересечения двух прямых, заданных 
//  уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения 
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// const int COEFICIENT = 0;
// const int CONSTANT = 1;
// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int LINE1 = 1;
// const int LINE2 = 2;

// double[] lineDate1 = InputLineData(LINE1);
// double[] lineDate2 = InputLineData(LINE2);

// if(ValidateLines(lineDate1, lineDate2))
// {
//     double[] coord = FindCoords(lineDate1, lineDate2);
//     Console.Write($"Точка пересечения уравнений y={lineDate1[COEFICIENT]}*x+{lineDate1[CONSTANT]} и y={lineDate2[COEFICIENT]}*x+{lineDate2[CONSTANT]} ");
//         Console.WriteLine($" имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
// }
// double Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }
// double[] InputLineData(int numberOfLine)
// {
//     double[] lineDate = new double[2];
//     lineDate[COEFICIENT] = Prompt($"Введите коэфициент для {numberOfLine}прямой>");
//     lineDate[CONSTANT] = Prompt($"Введите константу для {numberOfLine}прямой>");
//     return lineDate;
// }
// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//    double[] coord = new double[2];
//    coord[X_COORD] = (lineData1[CONSTANT] - lineDate2[CONSTANT]) / (lineData2[COEFICIENT] - lineData1[COEFICIENT]);
// coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
//    return coord;
// }
// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//    if (lineData1[COEFICIENT] == lineData2[COEFICIENT])
//    {
//       if (lineData1[CONSTANT] == lineData2[CONSTANT])
//       {
//          Console.WriteLine("Прямые совпадают");
//          return false;
//       }
//       else
//       {
//          Console.WriteLine("Прямые паралельны");
//          return false;
//       }
//    }
//    return true;
// }