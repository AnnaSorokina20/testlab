Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Anna");
Console.WriteLine("20.07.05");

Console.WriteLine("What is your name?");
string input = Console.ReadLine();

Console.WriteLine("How old are you?");
if (int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("You entered an integer for age: " + age);
}
else
{
    Console.WriteLine("That's not a valid integer for age.");
}

Console.WriteLine("Name:"+input+" Age:"+age);