Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оля")
{
    Console.WriteLine("Ура! Наша Оля приехала!");
} 
else
if(username.ToLower() == "ваня")
{
    Console.WriteLine("Ваня, не балуйся!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}