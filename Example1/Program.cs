//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// Console.WriteLine("Введите двухзначное число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a <= 10 || a >= 99)
//     Console.WriteLine("Введено не верное число");
// else
// {
//     int pos1 = a / 10;
//     a = a % 10;
//     if (pos1 > a)
//     {
//         Console.WriteLine(pos1);
//     }
//     else
//     {
//         Console.WriteLine(a);
//     }
// }


//12. Удалить вторую цифру трёхзначного числа
// Console.WriteLine("Введите трехзначное число");
// int a = Convert.ToInt32(Console.ReadLine());
// int sotni = a / 100;
// int edin = a % 10;
// a = sotni * 10 + edin;
// Console.WriteLine(a);

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1%number2==0)
// {
//     Console.WriteLine("Кратно");
// }
// else{
//     Console.WriteLine("не кратно");
// }

//14. Найти третью цифру числа или сообщить, что её нет

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 100 && a > -100)
//     Console.WriteLine("Третьей цифры нет");
// else
// {
//     a = a / 100 % 10;
//     Console.WriteLine("Третья цифра {0}", a);
// }


// 15. Дано число. Проверить кратно ли оно 7 и 23

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number%7==0)&&(number%23==0))
// {
//     Console.WriteLine("Кратно");
// }
// else{
//     Console.WriteLine("не кратно");
// }

//16.Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// Console.WriteLine("Введите число обозначаюшее день недели");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 1 || a > 7)
//     Console.WriteLine("Введено не верное число");
// if (a == 1)
//     Console.WriteLine("Не выходной");
// if (a == 2)
//     Console.WriteLine("Не выходной");
// if (a == 3)
//     Console.WriteLine("Не выходной");
// if (a == 4)
//     Console.WriteLine("Не выходной");
// if (a == 5)
//     Console.WriteLine("Не выходной, но близко!");
// if (a == 6)
//     Console.WriteLine("Выходной");
// if (a == 7)
//     Console.WriteLine("Выходной");

// 17. По двум введённым числам проверять является ли одно квадратом другого
// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if ((number2 == number1 * number1) || (number1 == number2 * number2))
// {
//     Console.WriteLine("Является");
// }
// else
// {
//     Console.WriteLine(" Не является");
// }

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool x = true;
// bool y = true;
// if (!(x || y) == !x && !y)
//     Console.WriteLine("Верно");
// else
// {
//     Console.WriteLine("Не верно");
// }
// Не совсем уверен над правильностью этой задачи

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// Console.WriteLine("Введите х");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите у");
// int y = Convert.ToInt32(Console.ReadLine());
// void PoiskChet(int x, int y)
// {
//     if (x > 0 && y > 0)
//         Console.WriteLine("1 четверть");
//     if (x < 0 && y > 0)
//         Console.WriteLine("2 четверть");
//     if (x < 0 && y < 0)
//         Console.WriteLine("3 четверть");
//     if (x > 0 && y < 0)
//         Console.WriteLine("4 четверть");
//     // return x;
//     // return y;
// }
// PoiskChet(-2,5);

// 20. Ввести номер четверти, показать диапазоны для возможных координат
// Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
//     Console.WriteLine("x > 0 and y > 0");
// if (number == 2)
//     Console.WriteLine("x < 0 and y > 0");
// if (number == 3)
//     Console.WriteLine("x < 0 and y < 0");
// if (number == 4)
//     Console.WriteLine("x > 0 and y < 0");

// 21. Программа проверяет пятизначное число на палиндромом.
//12345
// Console.WriteLine("Введите пятизначное число");
// int a = Convert.ToInt32(Console.ReadLine());
// int number1 = a / 10000; // 1
// int number2 = a / 1000 % 10; // 2
// // number3 = a % 1000 / 100
// int number4 = a % 100 / 10; // 4
// int number5 = a % 10; // 5
// if (number1 == number5 && number2 == number4){
//     Console.WriteLine("Число является палиндромом");
// }
// else{
//     Console.WriteLine("Число является не палиндромом");
// }




// 22. Найти расстояние между точками в пространстве 2D
// Console.WriteLine("Введите x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// int s = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// Console.WriteLine(Math.Sqrt(s));


// 22. Найти расстояние между точками в пространстве 3D