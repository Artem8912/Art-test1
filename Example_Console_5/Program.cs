Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
   Console.WriteLine("Специально для Маши"); 
}
else {

    Console.Write("Привет!");
    Console.WriteLine (username);

}