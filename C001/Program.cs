// поиск максимального числа
Console.WriteLine("Поиск максимального");
Console.Write("первое число ");int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("второе число ");int b = Convert.ToInt32(Console.ReadLine());
Console.Write("третье число ");int c = Convert.ToInt32(Console.ReadLine());
Console.Write("четвёртое число ");int d = Convert.ToInt32(Console.ReadLine());
Console.Write("пятое число ");int e = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( e > max ) max = e;
Console.WriteLine($"Максимальное число = { max }");
