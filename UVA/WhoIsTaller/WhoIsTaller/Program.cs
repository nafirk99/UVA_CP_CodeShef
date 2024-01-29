

int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] S = Console.ReadLine().Split();
    string R = (int.Parse(S[0])> int.Parse(S[1]))? "A" : "B";
    Console.WriteLine(R);
}
