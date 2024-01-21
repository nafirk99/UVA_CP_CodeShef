

int a = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    string[] T = Console.ReadLine().Split();
    if (int.Parse(T[0]) > int.Parse(T[1]))
    {
        Console.WriteLine(int.Parse(T[0]) - int.Parse(T[1]));
    }
    else Console.WriteLine(0);
}


