Console.Clear();
Console.WriteLine();
Console.Write("Введите изначальное расстояние между друзьями: ");
int distance = int.Parse(Console.ReadLine());
Console.Write("Введите скорость хозяина собаки: ");
int firstFrindSpeed = int.Parse(Console.ReadLine());
Console.Write("Введите скорость его друга: ");
int secondFrindSpeed = int.Parse(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dogSpeed = int.Parse(Console.ReadLine());
int friend = 2;
int count = 0;
int time = 0;
while (distance > 10)
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
