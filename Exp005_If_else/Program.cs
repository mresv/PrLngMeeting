Console.WriteLine("Введите Имя пользователя");
string user = Console.ReadLine();
if (user.ToLower() == "маша")
{
Console.WriteLine("Ура! Это же Маша!");
}
else
{
Console.Write("Привет, ");
Console.Write(user);
}