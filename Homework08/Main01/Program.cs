using System;
using System.Configuration;
using static System.Console;

namespace Main01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(ConfigurationManager.AppSettings["Greeting"]);

            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;
            WriteLine($"Сохраненное имя: {settings["Name"]?.Value}");
            WriteLine($"Сохраненный возраст: {settings["Age"]?.Value}");
            WriteLine($"Сохраненный род деятельности: {settings["Occupation"]?.Value}");

            Write("Введите имя: ");
            string name = ReadLine();
            int age;
            do
                Write("Введите возраст: ");
            while (!Int32.TryParse(ReadLine(), out age));
            Write("Введите род деятельности: ");
            string occupation = ReadLine();

            if (settings["Name"] == null)
                settings.Add("Name", name);
            else
                settings["Name"].Value = name;

            if (settings["Age"] == null)
                settings.Add("Age", age.ToString());
            else
                settings["Age"].Value = age.ToString();

            if (settings["Occupation"] == null)
                settings.Add("Occupation", occupation);
            else
                settings["Occupation"].Value = occupation;

            config.Save();
        }
    }
}