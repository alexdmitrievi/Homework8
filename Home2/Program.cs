// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] array = new int[5,5];
Random rnd = new Random();
int min = 100;
int mini = 0;
int minj = 0;
for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        array[i,j] = rnd.Next(0,10);
        Console.Write($"{array[i,j]} ");
        if (array[i,j] < min){
            min = array[i,j];
            mini = i;
            minj = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = minj; i < 4; i++){
    for (int j = 0; j < 5; j++){
        array[j,i] = array[j,i+1];
    }
}

for (int i = mini; i < 4; i++){
    for (int j = 0; j < 5; j++){
        array[i,j] = array[i+1,j];
    }
}

for (int i = 0; i < 4; i++){
    for (int j = 0; j < 4; j++){
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();