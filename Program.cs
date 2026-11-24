using DroneControlSystem;
using System.Text.Json;

Console.WriteLine("=== Система управления БПЛА (версия 3.0) ===\n");

<<<<<<< HEAD
=======
// Создаем массив дронов
>>>>>>> feature/interactive-menu
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
<<<<<<< HEAD
    Console.WriteLine("4. Расчёт времени полёта (в разработке)");
    Console.WriteLine("5. Сохранить состояние в файл");
    Console.WriteLine("6. Загрузить состояние из файла");
=======
    Console.WriteLine("4. Расчёт времени полёта"); // (Пока заглушка, если нет метода)
>>>>>>> feature/interactive-menu
    Console.WriteLine("0. Выход");
    Console.Write("Выберите действие: ");

    string input = Console.ReadLine();

<<<<<<< HEAD
=======
    // Используем TryParse для безопасного ввода
>>>>>>> feature/interactive-menu
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
<<<<<<< HEAD
                if (choice == 3) drones[index].Charge(20);
=======
                if (choice == 3) drones[index].Charge(20); // Заряжаем на 20%
>>>>>>> feature/interactive-menu
            }
            else
            {
                Console.WriteLine("Неверный индекс дрона.");
            }
            break;
        case 4:
            Console.WriteLine("Функция в разработке...");
            break;
<<<<<<< HEAD
        case 5:
            SaveDrones(drones, "drones.json");
            break;
        case 6:
            drones = LoadDrones("drones.json");
            break;
=======
>>>>>>> feature/interactive-menu
        default:
            Console.WriteLine("Неизвестная команда.");
            break;
    }
<<<<<<< HEAD
}

static void SaveDrones(Drone[] drones, string fileName)
{
    var options = new JsonSerializerOptions { WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(drones, options);
    File.WriteAllText(fileName, jsonString);
    Console.WriteLine($"Состояние сохранено в файл {fileName}");
}

static Drone[] LoadDrones(string fileName)
{
    if (!File.Exists(fileName))
    {
        Console.WriteLine("Файл не найден. Будет создан новый массив.");
        return new Drone[0];
    }
    string jsonString = File.ReadAllText(fileName);
    Drone[]? loadedDrones = JsonSerializer.Deserialize<Drone[]>(jsonString);
    return loadedDrones ?? new Drone[0];
=======
>>>>>>> feature/interactive-menu
}