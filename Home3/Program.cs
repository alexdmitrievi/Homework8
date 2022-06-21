// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] array = new int[5,5,5];
Random rnd = new Random();
string El = "";
int newEl = 0;
for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        for (int k = 0; k < 5;k++){
            newEl = rnd.Next(10,100);
            while (El.Contains(Convert.ToString(newEl))){
                newEl = rnd.Next(10,100);
            }
            array[i,j,k] = newEl;
            Console.WriteLine($"{i},{j},{k}: {array[i,j,k]} ");
        }
    }
}
