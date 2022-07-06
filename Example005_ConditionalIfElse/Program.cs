Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Well, it's MASHA!!!");
} else {
    Console.Write("Hello, ");
    Console.WriteLine(username);
}