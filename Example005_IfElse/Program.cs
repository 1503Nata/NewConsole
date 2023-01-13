Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine ();

if (username.ToLower() == "наталья")
{
  Console.WriteLine("Ура, это же Наташа!");
}
else
{ 
    Console.Write("Привет,  ");
    Console.Write(username);
}
