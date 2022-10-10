Console.Clear();
Console.WriteLine("введите 3х значное число");

int a = Convert.ToInt32(Console.ReadLine());

if (a>1000||a<100)
 Console.WriteLine("число введено неверно");
else 
a=a/10;
 Console.WriteLine(a%10);
