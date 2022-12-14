Console.WriteLine("Enter the fist namber");
string namberA = Console.ReadLine();
Console.WriteLine("Enter second namber");
string namberB = Console.ReadLine();
var namber1 = double.Parse(namberA);
var namber2 = double.Parse(namberB);
var result = namber1/namber2;
Console.WriteLine(result);