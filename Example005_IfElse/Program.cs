Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!! А где медведь?");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!!");
}
 