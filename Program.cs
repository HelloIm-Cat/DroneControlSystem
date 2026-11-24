using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 3.0) ===\n");

Drone myDrone = new Drone("DJI Mini 3", 15);
myDrone.PrintInfo();
Console.WriteLine();

// Пытаемся взлететь (должно выдать ошибку, так как заряд < 20%)
myDrone.TakeOff();

// Заряжаем дрон
myDrone.Charge(30); // Добавляем 30% (станет 45%)

// Теперь взлетаем
myDrone.TakeOff();

// Сажаем дрон
myDrone.Land();
myDrone.PrintInfo();

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();
// Тест синхронизации выполнен
