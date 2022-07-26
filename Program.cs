//Пользователь вводит число a
Console.Write("Проверка на четность. Введите a = ");
int a = Convert.ToInt32(Console.ReadLine());
//проверяем четное число или нет
if ( a % 2 < 0)
{
  Console.Write("да");  
}
else
{
  Console.Write("нет");  
}