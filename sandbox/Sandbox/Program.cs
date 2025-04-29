using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int x = 10;
if (x == 10) // single = is assignment, == is comparison
{
	Console.WriteLine("X is 10");
}

for (int i = 0; i < x; i++) //i ++ will be executed at the end of the code, i = 0 is where to start
{
	Console.WriteLine($"Bob is cool: {i}");
}

    }
}

