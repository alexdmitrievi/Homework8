/*Найти произведение двух матриц
В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника*/

int[,] matrix1 = new int[3,4];
int[,] matrix2 = new int[4,3];
int[,] result = new int[3,3];
int sum = 0;
Random rnd = new Random();
for (int i = 0; i < 3; i++){
    for (int j = 0; j < 4; j++){
        matrix1[i,j] = rnd.Next(0,10);
        Console.Write($"{matrix1[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 4; i++){
    for (int j = 0; j < 3; j++){
        matrix2[i,j] = rnd.Next(0,10);
        Console.Write($"{matrix2[i,j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++){
    for (int k = 0; k < 3; k++){
        for (int j = 0; j < 4; j++){
            sum = matrix1[i,j] * matrix2[j,k] + sum;
        }
        result[i,k] = sum;
    }
}
Console.WriteLine();

for (int i = 0; i < 3; i++){
    for (int j = 0; j < 3; j++){
        Console.Write($"{result[i,j]} ");
    }
    Console.WriteLine();
}