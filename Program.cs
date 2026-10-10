//Задание 1.1
 for (int i = 10; i >= 1; i--) {
     Console.WriteLine(i);
 }
 int n = 1;
 while (n <= 1) {
   Console.WriteLine(n);
    n++;
 }
 int answer;
 do {
     Console.Write("Введите число больше 0: ");
     answer = Convert.ToInt32(Console.ReadLine());
 }
 while (answer <= 0);
 for (int i = 10; i >= 1; i--) {
     if (i == 3) continue;
     if (i == 7) break;
     Console.WriteLine(i);
 }

//Задание 1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
//Задание 2
//  for (int i = 2; i <= 50; i += 2) 
//    {
//        Console.WriteLine(i);
//    }

 int sum = 0;
 for (int i = 1; i <=10; i++) {
     sum += i;
 }
 Console.WriteLine($"Сумма: {sum}");

 int count = 0;
 for (int i = 1; i <= 20; i++){
   if (i % 5 == 0) {
        count++;
    } 
}
Console.WriteLine($"Чисел, кратных 5: {count}");

//Задание 2
// int sum = 0;  
// int count = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Сумма чисел, кратных 3: {sum}");
// Console.WriteLine($"Количество чисел, кратных 7: {count}");

int number = Convert.ToInt32(Console.ReadLine());
int total = 0;
while (number != 0) {
    total += number;
    number = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Сумма: {total}");

//Задание 3
//  Console.Write("Введите число (0 — стоп): ");
// int number = Convert.ToInt32(Console.ReadLine());

// int positive = 0;
// int negative = 0;

// while (number != 0)
//  {
//     if (number > 0)
//         positive++;
//     else
//         negative++;

//     Console.Write("Введите число (0 — стоп): ");
//     number = Convert.ToInt32(Console.ReadLine());
//  }

// Console.WriteLine($"Положительных: {positive}");
// Console.WriteLine($"Отрицательных: {negative}");

string password;
do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();

}
while (password != "qwerty");
Console.WriteLine("Доступ разрешен");

//Задание 4
// string password;
// bool access = false;

// for (int i = 1; i <= 3; i++)
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешён");
//         access = true;
//         break;
//     }
// }
//     if (!access)
//     {
//         Console.WriteLine("Доступ заблокирован");
//     }

//Задание 5
// Console.Write("Введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//         Console.WriteLine($"{n} x {i} = {n * i}");
// }

//Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//         continue; 

//     if (i % 10 == 0 && i > 20)
//     {
//         break; 
//     }

//     Console.WriteLine(i);
// }

//Итоговая задача
int secret = 42;

Console.WriteLine("Игра «Угадай число» У вас 5 попыток");

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Попытка {i}. Введите число: ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secret)
    {
        Console.WriteLine($"Победа! Попыток: {i}");
        return; 
    }
    else if (guess > secret)
    {
        Console.WriteLine("Меньше");
    }
    else
    {
        Console.WriteLine("Больше");
    }
}

Console.WriteLine($"Вы проиграли, число было {secret}");
