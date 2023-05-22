Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
else
    Console.WriteLine("Большее число: " + b + ", меньшее число: " + a);