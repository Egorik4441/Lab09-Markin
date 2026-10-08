// // // // // // // // int totalExercises = 1;

// // // // // // // // for(int number = 8; number >= totalExercises; number--)
// // // // // // // // {
// // // // // // // //     Console.WriteLine($"Упражнение {number}");
// // // // // // // // }

// // // // // // // // Console.WriteLine("Домашнее задание готово");

// // // // // // // for (int room = 5; room <= 50; room += 5)
// // // // // // // {
// // // // // // //     Console.WriteLine($"Кабинет{room}");
// // // // // // // }

int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}

// // // // // int bilet = 0;
// // // // // for (int ticket = 1; ticket <= 30; ticket++)
// // // // // {
// // // // //     if (ticket == 4 || ticket == 12 || ticket == 19)

// // // // //     {
// // // // //         bilet++;
// // // // //         continue; // билет уже вытянут
// // // // //     }
// // // // //     Console.WriteLine($"Первый доступный билет: {ticket}, Было пропущено билетов: {bilet}");
// // // // //     break;
// // // // // }

// // // // for (; ; )
// // // // {
// // // //     Console.Write("Введите код группы (для выхода - <выход>): ");
// // // //     string groupCode = Console.ReadLine();

// // // //     if (groupCode == "выход")
// // // //     {
// // // //         break;
// // // //     }

// // // //     Console.WriteLine($"Записан код группы: {groupCode}");

// // // // }
// // // // Console.WriteLine("Работа с журналом завершена");

// // // int N = 34;

// // // for (int count = 1; count <= N; count += 2)
// // // {
// // //     Console.WriteLine($"Нечётные: {count}");
// // // }

// // for (int count = 100; count >= 0; count -= 10)
// // Console.WriteLine(count);

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 


// int N = 20;

// for (int i = 1; i <= N; i++)
//     {
//         if (i % 3 == 0)
    
// Console.WriteLine(i);
//     }

// for (int i = 100; i >= 2; i -= 2 )
// Console.WriteLine(i);
