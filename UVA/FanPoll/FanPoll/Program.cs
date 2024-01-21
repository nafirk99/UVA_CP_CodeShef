
string[] T = Console.ReadLine().Split();
string R = (int.Parse(T[0]) > int.Parse(T[1]) && int.Parse(T[0]) > int.Parse(T[2])) ? "YES" : "NO";
Console.WriteLine(R);