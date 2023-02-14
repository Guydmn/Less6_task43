// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первую координату первой точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки b1 : ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки b2 : ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 0;
    if ((k1==k2) && (b1==b2))
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (k1==k2)
    {
        Console.WriteLine($"Прямые не пересекаются");
    }
    else
    {
        x = (b2-b1)/(k1-k2);
        y = k1*x + b1;
        Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");
    }