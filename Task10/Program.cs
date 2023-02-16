Console.Write("Введите трехзначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
int second = (number % 100 - number % 10) / 10;

Console.WriteLine("Вторая цифра введенногочисла: " + second);
}
else
{
Console.WriteLine("Число не трехзначное!");
}
