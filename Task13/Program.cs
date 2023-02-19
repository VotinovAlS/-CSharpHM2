Console.Write("Введите семизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(1000000, 10000000);
// Console.WriteLine("Сгенерированно число: " + number);

if (number > 999999 && number < 10000000 || number > -10000000 && number < -999999)
{
  int thirdLeft = (number % 100000 - number % 10000) / 10000;
  int thirdRight = (number % 1000 - number % 100) / 100;
  if (thirdLeft >= 0 && thirdRight >= 0)
  {
    Console.WriteLine("третья цифра введенного числа слева: " + thirdLeft + "; " + "третья цифра введенного числа справа: " + thirdRight);
  }
  else
  {
    Console.WriteLine("третья цифра введенного числа слева: " + -thirdLeft + "; " + "третья цифра введенного числа справа: " + -thirdRight);
  }
}
else
{
  if (number > 100 || number < -100)
  {
    Console.WriteLine("Число не семизначное!");
  }
  else
  {
    Console.WriteLine("Третьей цифры нет! Число не семизначное!");
  }
}
