// Задача 1
// Напишите программу, которая на вход принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23

// int num = 489;

// if (num % 7 == 0 && num % 23 == 0){
//     Console.WriteLine("да");
// }
// else{
//     Console.WriteLine("нет");
// }

// Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// int x = 2;
// int y = -4;

// if (x > 0 && y > 0){
//     Console.Write(1);
// } if (x < 0 && y > 0){
//     Console.Write(2);
// } if (x < 0 && y < 0){
//     Console.Write(3);
// } if (x > 0 && y < 0){
//     Console.Write(4);
// }

// Задача 3
// Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = 72;
// int first = num/10;
// int second = num % 10;
// if (first > second){
//     Console.Write(first);
// } else {
//     Console.Write(second);
// }

// Задача 4
// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

int num = 987521;
int result = num;
int digit = 0;
int i = 0;

while (result > 0){
    digit = result;
    digit = digit % 10;
    result = result / 10;
    i++;
}

int result_exponent = 1;

for (int j = 1; j < i+1; j++){
    result_exponent = 1;
    for (int k = 1; k < i+1-j; k++){
        result_exponent *= 10;
    }

    if (j == i){
        digit = num % 10;
        Console.Write(digit);
    } else {
        digit = num / result_exponent;
        digit = digit % 10;

        Console.Write(digit + ", ");
    }
}

