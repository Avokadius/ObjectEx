namespace ObjectEx.Models;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age); // Генерация хэш-кода на основе свойств
    }

    public static bool operator ==(Person a, Person b)
    {
        if (a is null)
        {
            return b is null;
        }

        return a.Equals(b);
    }

    public static bool operator !=(Person a, Person b)
    {
        return !(a == b);
    }

    public static bool operator <(Person a, Person b)
    {
        return a.Age < b.Age; // Сравнение по возрасту
    }

    public static bool operator >(Person a, Person b)
    {
        return a.Age > b.Age; // Сравнение по возрасту
    }

}
