Console.Clear();
Console.WriteLine();
Console.Write("Введите изначальное расстояние между друзьями: ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость хозяина собаки: ");
double firstFrindSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость его друга: ");
double secondFrindSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
byte friend = 2;
int count = 0;
double time = 0;
while (distance > 1)
{
    if (friend == 1)
    {
        time = distance / (firstFrindSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFrindSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFrindSpeed + secondFrindSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");
Console.WriteLine();
