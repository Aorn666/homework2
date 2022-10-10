Console.Clear();
Console.WriteLine("введите номер дня недели и узнайте является ли он выходным у нормальных людей");

int a = Convert.ToInt32(Console.ReadLine());

if (a<1 || a>7){
 Console.WriteLine("таких денй недели не бывает");
}
else {
  if (a == 1|| a == 2|| a == 3|| a == 4|| a == 5)
   Console.WriteLine("нет");
  if (a == 6|| a == 7)
   Console.WriteLine("да");
}