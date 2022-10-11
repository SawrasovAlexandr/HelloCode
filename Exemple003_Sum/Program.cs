int nanberA = new Random().Next(1, 10); // 1 2 3 ... 9
Console.Write(nanberA);
int nanberB = new Random().Next(1, 10);
Console.Write(" + ");
Console.Write(nanberB);
int result = nanberA + nanberB;
Console.Write(" = ");
Console.WriteLine(result);