//4.Даны два произвольных числа a, b. Если оба значения принадлежат отрезку [c,d],
//то вычислить R=sin(a)sin(b), в противном случае вывести сообщение «Нет решения»


double a, b, c, d, R;
        Console.WriteLine("Введите значение");
c = Convert.ToInt32(Console.ReadLine());
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

if (c >= a && a <= d && c >= b && b <= d) 
        {
    R = (double)(Math.Sin(a) * Math.Sin(b));
    Console.WriteLine("Ответ R=" + R);
}
else
{
    Console.WriteLine("Нет решения");
}
Console.ReadKey();