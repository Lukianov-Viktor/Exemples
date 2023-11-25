Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "yana")
{
    Console.WriteLine("Ура!!! Яночка пришла!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}