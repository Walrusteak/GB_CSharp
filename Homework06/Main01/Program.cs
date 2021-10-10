using System;
using System.Diagnostics;
using static System.Console;

namespace Main01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                string input = ReadLine().Trim();
                switch (input)
                {
                    case "1":
                        PrintProcesses();
                        break;
                    case "2":
                        KillProcessByPid(GetIdInput());
                        break;
                    case "3":
                        KillProcessByName(GetNameInput());
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
            WriteLine("1. Вывести список процессов");
            WriteLine("2. Завершить процесс по pid");
            WriteLine("3. Завершить процесс по имени");
            WriteLine("q. Выход");
            Write("Выбор: ");
        }

        static void PrintProcesses()
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (!String.IsNullOrWhiteSpace(p.ProcessName))
                    WriteLine($"{p.Id,-7} {p.ProcessName}");
            }
        }

        static void KillProcessByPid(int pid)
        {
            try
            {
                Process.GetProcessById(pid).Kill();
                WriteLine($"Процесс с pid {pid} убит");
            }
            catch (Exception e)
            {
                WriteLine($"Произошла ошибка: {e.Message}");
            }
        }

        static void KillProcessByName(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            if (processes.Length == 0)
            {
                WriteLine($"Процессы с именем {name} не найдены");
                return;
            }
            foreach (Process p in processes)
            {
                try
                {
                    p.Kill();
                    WriteLine($"Процесс с pid {p.Id} убит");
                }
                catch (Exception e)
                {
                    WriteLine($"Произошла ошибка при убийстве процесса с pid {p.Id}: {e.Message}");
                }
            }
        }

        static int GetIdInput()
        {
            int id;
            do
                Write("Введите ID процесса: ");
            while (!Int32.TryParse(ReadLine(), out id));
            return id;
        }

        static string GetNameInput()
        {
            Write("Введите имя процесса: ");
            return ReadLine();
        }
    }
}
