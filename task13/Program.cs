Console.Clear();
Console.WriteLine("введите число и узнайте его 3ю цыфру");

int a = Convert.ToInt32(Console.ReadLine());

if (a<100)
 Console.WriteLine("3й цыфры нет");
else 
 while (a>1000)
 {
    a=a/10;
 }
 Console.WriteLine(a%10);