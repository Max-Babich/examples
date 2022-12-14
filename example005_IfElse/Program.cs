
Console.Write("Print your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "max") // ToLower() делает все буквы строчными
    {
        Console.Write("I'm glad to see you, Max!" );
    }
else
    {
        Console.WriteLine("Hello ",username);
    }