internal class Dice
{
    int _sides;
    public Dice()
    {
        _sides = 6;

    }
    public Dice(int sides) { this._sides = sides; }

    public void Roll()
    {
        Random random = new Random();
        int value = random.Next(1, _sides);
        Console.WriteLine($"Вам выпала {value}");
    }
}

