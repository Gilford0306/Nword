//Создайте приложение, проверяющее текст на недо-
//пустимые слова. Если недопустимое слово найдено, оно 
//должно быть заменено на набор символов *. По итогам 
//работы приложения необходимо показать статистику 
//действий.


Console.WriteLine("input string");
string s1 = Console.ReadLine();
Console.WriteLine("input forbidden word");
string s2 = Console.ReadLine();
//подсчёт количества повторений запретного слова 
string[] mas = s1.Split(' ', '.', ',', '-', '!', '?');
int x = 0;
foreach (string p in mas)
{
    if (p == s2)
    {
        x++;
    }
}
Console.WriteLine($"Forbidden word occurs {x} times");
//замена запретного слова 
string s3 = new string('*', s2.Length);
s1 = s1.Replace(s2, s3);
Console.Write("Result - ");
Console.WriteLine(s1);



