internal class Car
{
    string Model;
    int Speed;
    int MaxSpeed;

    public Car(string model, int maxSpeed)
    {
        Model = model;
        Speed = 0;
        MaxSpeed = maxSpeed;

    }
    public void Accelerate(int delta)
    {
        Speed += delta;
        if (Speed > MaxSpeed)
        {
            Speed = MaxSpeed;
        }
        Console.WriteLine($"Модель: {Model}, Текущая скорость: {Speed} км/ч");
    }
    public void Brake()
    {
        Speed = 0;
        Console.WriteLine("После торможения: 0 км/ч");
    }
}
