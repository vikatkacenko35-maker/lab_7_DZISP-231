internal class Character
{
    int Health;
    int Mana;

    public Character(int health, int mana) { this.Health = health; this.Mana = mana; }
    public void Attack()
    {
        Console.WriteLine("Вы атакуете!");
    }
}

