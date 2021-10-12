using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Main05
{
    class Program
    {
        static ToDo[] tasks;

        static void Main(string[] args)
        {
            tasks = File.Exists("tasks.json") ? JsonSerializer.Deserialize<ToDo[]>(File.ReadAllText("tasks.json")) : new ToDo[10];

            while (true)
            {
                ShowMenu();
                string input = ReadLine().Trim(); ;
                switch (input)
                {
                    case "1":
                        PrintList();
                        break;
                    case "2":
                        EditTask();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        File.WriteAllText("tasks.json", JsonSerializer.Serialize(tasks));
                        break;
                    case "q":
                    case "Q":
                        return;
                }
                WriteLine();
            }
        }

        static void ShowMenu()
        {
            WriteLine("1. Вывести список");
            WriteLine("2. Изменить элемент");
            WriteLine("3. Удалить элемент");
            WriteLine("4. Сохранить в файл");
            WriteLine("q. Выход");
            Write("Выбор: ");
        }

        static void PrintList()
        {
            for (int i = 0; i < tasks.Length; i++)
                WriteLine($"{i}. {(tasks[i] == null ? "Отсутствует" : $"[{(tasks[i].IsDone ? 'x' : ' ')}] {tasks[i].Title}")}");
        }

        static void EditTask()
        {
            int num;
            do
            {
                Write("Номер задачи: ");
            }
            while (!Int32.TryParse(ReadLine(), out num) || num < 0 || num > 9);
            ToDo task = tasks[num];
            if (task == null)
            {
                task = new ToDo();
                tasks[num] = task;
            }
            Write("Название: ");
            task.Title = ReadLine();
            Write("Выполнено (д/Н): ");
            task.IsDone = ReadLine() == "д";
        }

        static void DeleteTask()
        {
            int num;
            do
            {
                Write("Номер задачи: ");
            }
            while (!Int32.TryParse(ReadLine(), out num) || num < 0 || num > 9);
            tasks[num] = null;
        }
    }
}
