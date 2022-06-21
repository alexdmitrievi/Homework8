/*Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int Factorial(int a){
    if (a == 1){
        return 1;
    }
    return Factorial(a-1)*a;
}
*/
static float Factorial(int n) {
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}


Console.WriteLine("Введите число n для треугольника Паскаля");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < n; i++){
    for (int j = 0; j <= (n - i); j++){
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++){
        Console.Write(" ");
        Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j))); 
    }
    Console.WriteLine();
    Console.WriteLine();
}



