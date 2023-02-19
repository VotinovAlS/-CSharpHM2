Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
  if (number == 6 || number == 7)
  {
    Console.WriteLine("День недели № " + number + " является выходным!");
  }
  else
  {
    Console.WriteLine("День недели № " + number + " НЕ является выходным!");
  }
}
else
{
  Console.WriteLine("Такого дня недели НЕ существует!");
}

