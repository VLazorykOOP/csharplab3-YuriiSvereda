using System;

// Базовий клас
class Country
{
    public string Name { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"Country: {Name}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Area: {Area}");
    }
}

// Похідний клас Республіка
class Republic : Country
{
    public string President { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"President: {President}");
    }
}

// Похідний клас Монархія
class Monarchy : Country
{
    public string Monarch { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Monarch: {Monarch}");
    }
}

// Похідний клас Королівство
class Kingdom : Monarchy
{
    public int NobilityCount { get; set; }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Nobility Count: {NobilityCount}");
    }
}


