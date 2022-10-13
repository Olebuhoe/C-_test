Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ебать, это же МАХА!!!");
}
else
{
    Console.Write("Ну, и хули надо, ");
    Console.Write(username);
    Console.Write("?");
}