using ObjectEx.Models;

namespace ObjectEx;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person { Name = "Yury", Age = 41 };
        var p2 = new Person { Name = "Alex", Age = 33 };
        var p3 = new Person { Name = "Yury", Age = 41 };

        Console.WriteLine(p1);
        Console.WriteLine($"HashCode of p1: {p1.GetHashCode()}");
        Console.WriteLine($"HashCode of p2: {p2.GetHashCode()}");
        Console.WriteLine($"HashCode of p3: {p3.GetHashCode()}");

        Console.WriteLine(p1.Equals(p2)); // false
        Console.WriteLine(p3.Equals(p1)); // true
        Console.WriteLine(p3 == p1); // true

        Console.WriteLine($"p1 < p2: {p1 < p2}"); // false
        Console.WriteLine($"p1 > p2: {p1 > p2}"); // 

    }
}
