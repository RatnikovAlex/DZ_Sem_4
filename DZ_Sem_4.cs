// Урок 4. Функции


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int power = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{number} в степени {power} = " + (Math.Pow(number, power)));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// while (number > 0)
// {
// sum = sum + number % 10;
// number = number /10 ;
// }
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Console.Write("Из скольки чисел будет массив?:");
// int size = Convert.ToInt32(Console.ReadLine()); // Задаем длину массива

// Console.Write("Какое минимальное число должно быть в массиве?:");
// int min = Convert.ToInt32(Console.ReadLine());  // Задаем мин число в массиве

// Console.Write("Какое максимальное число должно быть в массиве?:");
// int max = Convert.ToInt32(Console.ReadLine());  // Задаем макс число в массиве

// if (max < min)
// {
// Console.Write("Не верно указан диапозон!");  // Отсекаем если ввели макс меньше чем мин
// }
// else 
// {
// int[] result = GetBinaryArray(size);
// Console.WriteLine($"[{String.Join(", ", result)}]");
// int[] GetBinaryArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = new Random().Next(min, max + 1); // чтобы рандом брал все указаные макс взят с +1( если разница диапозона 1) 
//     }
//     return array;
// }
// }