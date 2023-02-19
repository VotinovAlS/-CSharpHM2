Console.Write("Введите трехзначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number > -1000 && number < -99)
{
  int second = (number % 100 - number % 10) / 10;
  if (second >= 0)
  {
    Console.WriteLine("Вторая цифра введенного числа: " + second);
  }
  else
  {
    Console.WriteLine("Вторая цифра введенного числа: " + -second);
  }
}
else
{
  Console.WriteLine("Число не трехзначное!");
}
