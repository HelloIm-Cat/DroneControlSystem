namespace DroneControlSystem;

public class Drone
{
    public string Model { get; set; }
    public int BatteryLevel { get; set; } // 0..100
    public double Altitude { get; set; }
    public bool IsEngineOn { get; set; }

    public Drone(string model, int batteryLevel)
    {
        Model = model;
        BatteryLevel = batteryLevel;
        Altitude = 0;
        IsEngineOn = false;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Заряд батареи: {BatteryLevel}%");
        Console.WriteLine($"Высота: {Altitude:F1} м");
        Console.WriteLine($"Двигатель: {(IsEngineOn ? "включён" : "выключен")}");
    }

    public void TakeOff()
    {
        if (BatteryLevel < 20)
        {
            Console.WriteLine("Недостаточно заряда для взлёта (нужно минимум 20%).");
            return;
        }
        IsEngineOn = true;
        Altitude = 10.0;
        BatteryLevel -= 5;
        Console.WriteLine($"{Model} взлетел на высоту 10 м. Заряд: {BatteryLevel}%");
    }
    // Метод для посадки
    public void Land()
    {
        if (Altitude > 0)
        {
            Altitude = 0;
            IsEngineOn = false;
            BatteryLevel -= 2; // Тратим 2% на посадку
            Console.WriteLine($"{Model} совершил посадку. Заряд: {BatteryLevel}%");
        }
        else
        {
            Console.WriteLine($"{Model} уже на земле.");
        }
    }

    // Метод для зарядки
    public void Charge(int amount)
    {
        BatteryLevel += amount;
        if (BatteryLevel > 100)
        {
            BatteryLevel = 100; // Заряд не может быть больше 100%
        }
        Console.WriteLine($"{Model} заряжен на {amount}%. Текущий заряд: {BatteryLevel}%");
    }

}