// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
using System; //вызов библиотеке
System.Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number !=0)  // пока намбер не равно нулю
 {
    int digit = number % 10; //намбер остаток от деление на 10
    sum += digit;  // sum = sum + digit
    number /= 10; // number деление на 10
}
Console.WriteLine ("Сумма цифр в числе: " +sum);