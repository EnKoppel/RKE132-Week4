int sum = 0;


for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($" Current total: {sum}");
    sum=sum+i;//sum+=i;
}
Console.WriteLine($"Final total {sum}");
Console.WriteLine("------------------------------------------------------------------------------------------");
//for (int i = 10; i > 0; i--)
//{
  //  Console.WriteLine($"i={i-1}");
//}