Console.WriteLine("What is your name?");
string username = Console.ReadLine(); 
if(username.ToLower() == "anna")
{
    Console.WriteLine("Meow...MEOW");
}
else 
{
    Console.WriteLine("Hello,");
    Console.Write(username);
}