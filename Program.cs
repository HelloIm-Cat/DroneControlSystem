using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 3.0) ===\n");

// Создаем массив дронов
Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15)
};

while (true)
{
    Console.WriteLine("\nМеню:");
    Console.WriteLine("1. Показать информацию о всех дронах");
    Console.WriteLine("2. Взлёт выбранного дрона");
    Console.WriteLine("3. Подзарядка выбранного дрона");
    Console.WriteLine("4. Расчёт времени полёта"); // (Пока заглушка, если нет метода)
    Console.WriteLine("0. Выход");
    Console.Write("Выберите действие: ");

    string input = Console.ReadLine();

    // Используем TryParse для безопасного ввода
    if (!int.TryParse(input, out int choice))
    {
        Console.WriteLine("Ошибка: введите число.");
        continue;
    }

    if (choice == 0) break;

    switch (choice)
    {
        case 1:
            foreach (var d in drones) { d.PrintInfo(); Console.WriteLine(); }
            break;
        case 2:
        case 3:
            Console.Write("Введите индекс дрона (0, 1 или 2): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < drones.Length)
            {
                if (choice == 2) drones[index].TakeOff();
                if (choice == 3) drones[index].Charge(20); // Заряжаем на 20%
            }
            else
            {
                Console.WriteLine("Неверный индекс дрона.");
            }
            break;
        case 4:
            Console.WriteLine("Функция в разработке...");
            break;
        default:
            Console.WriteLine("Неизвестная команда.");
            break;
    }
}