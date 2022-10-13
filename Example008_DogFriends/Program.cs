Console.Clear();
Console.WriteLine();                                //отделяем вывод данных программы пустой строкой
Console.Write("Введите изначальное расстояние между друзьями в метрах: ");   //запрашиваем и
string dis = Console.ReadLine();                      //принимаем расстояние
double distance = 0;
while (double.TryParse(dis, out distance) == false | distance <= 0)
{
    int answer = new Random().Next(0, 4);
    if (answer == 0)
    {
        Console.Write("Расстояние это натуральное число! Введите снова: ");
        dis = Console.ReadLine();
    }
    if (answer == 1)
    {
        Console.Write("Ошибка ввода! Введите снова: ");
        dis = Console.ReadLine();
    }
    if (answer == 2)
    {
        Console.Write("Не надо нажимать ничего кроме цифр!!! Введите снова: ");
        dis = Console.ReadLine();
    }
    if (answer == 3)
    {
        Console.Write("Ошибка! Введите снова: ");
        dis = Console.ReadLine();
    }
}
while (distance > 40075000)                                             //проверяем не слишком ли
{                                                                       //оно велико и если это так
    Console.Write("Вообще то экватор короче! Введите число поменьше: ");//просим повторить ввод и
    distance = Convert.ToDouble(Console.ReadLine());                    //обновляем значение
}
Console.Write("Введите скорость хозяина собаки в м/с: ");       //запрашиваем и 
string ffs = Console.ReadLine();                      //принимаем расстояние
double firstFrindSpeed = 0;
while (double.TryParse(ffs, out firstFrindSpeed) == false | firstFrindSpeed <= 0)
{                              
    Console.Write("Ошибка ввода! Введите снова: ");
    ffs = Console.ReadLine();
}                                       //принимаем скорость хозяина собаки
while (firstFrindSpeed > 12.4)                                              //проверяем не слишком ли
{                                                                           //оно велико и если это так
    Console.Write("Усейн Болт медленней бегает! Введите число поменьше: "); //просим повторить ввод и
    firstFrindSpeed = Convert.ToDouble(Console.ReadLine());                 //обновляем значение 
}
Console.Write("Введите скорость его друга в м/с: ");            //запрашиваем и 
string sfs = Console.ReadLine();                      //принимаем расстояние
double secondFrindSpeed = 0;
while (double.TryParse(sfs, out secondFrindSpeed) == false | secondFrindSpeed <= 0)
{                              
    Console.Write("Ошибка ввода! Введите снова: ");
    sfs = Console.ReadLine();
}                                                            //принимаем скорость его друга
while (secondFrindSpeed > 12.4)                                             //проверяем не слишком ли
{                                                                           //оно велико и если это так
    Console.Write("Усейн Болт медленней бегает! Введите число поменьше: "); //просим повторить ввод и
    secondFrindSpeed = Convert.ToDouble(Console.ReadLine());                //обновляем значение 
}
Console.Write("Введите скорость собаки в м/с: ");           //запрашиваем и 
string ds = Console.ReadLine();                      //принимаем расстояние
double dogSpeed = 0;
while (double.TryParse(ds, out dogSpeed) == false | dogSpeed <= 0)
{                              
    Console.Write("Ошибка ввода! Введите снова: ");
    ds = Console.ReadLine();
}                                     //принимаем скорость собаки
while (dogSpeed > 18.6)                                                     //проверяем не слишком ли
{                                                                           //оно велико и если это так
    Console.Write("Стар Тайтл медленней бегает! Введите число поменьше: "); //просим повторить ввод и
    dogSpeed = Convert.ToDouble(Console.ReadLine());                        //обновляем значение
}
byte friend = 2;    //задаем счетчик направления бега собаки
int count = 0;      //задаем счетчик количества пробежек собаки
double time = 0;    //определяем переменную времени одной пробежки

if (dogSpeed < firstFrindSpeed)                                             //проверяем не медленнее ли
{                                                                           //собака своего хозяина и если
    Console.WriteLine("Собака отстала от хозяина! Т.е. пробежала 0 раз");   //это так завершаем программу,
}                                                                           //сообщив об этом
else
{                                                                                     //проверяем не медленнее
    if (dogSpeed < secondFrindSpeed)                                                  //ли собака друга 
    {                                                                                 //хозяина и если это так
        Console.WriteLine("Собака добежала до друга и отстала! Т.е. пробежала 1 раз");//завершаем программу
    }                                                                                 //сообщив об этом
    else
    {
        while (distance > 1) //проверяем не достигли ли друзья точки встречи
        {
            if (friend == 1)     //направление бега собаки - к хозяину
            {
                time = distance / (firstFrindSpeed + dogSpeed);     //вычисляем время пробежки собаки к хозяину
                friend = 2;     //направление бега собаки сменилось
            }
            else                //направление бега собаки - от хозяина
            {
                time = distance / (secondFrindSpeed + dogSpeed);    //вычисляем время пробежки собаки от хозяина
                friend = 1;     //направление бега собаки сменилось
            }
            distance = distance - (firstFrindSpeed + secondFrindSpeed) * time;//сокращаем дистанцию
            count++;            //считаем количество пробежек собаки
        }
        Console.WriteLine("Собака пробежит " + count + " раз.");//выводим результат и завершаем программу
    }
}
Console.WriteLine();//отделяем вывод данных программы пустой строкой
