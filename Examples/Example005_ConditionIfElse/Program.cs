Console.WriteLine("Enter your name");
string username = Console.ReadLine();

if(username.ToLower() == "vasya")
{
    Console.WriteLine("Super, this is Vasya!");
}
else 
{
    Console.Write("Hello, ");
    Console.Write(username);
}