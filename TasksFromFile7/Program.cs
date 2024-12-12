using System;
using TasksFromFile7.ClassesTask;

namespace TasksFromFile7
{
    internal class Program
    {
        static void TaskFirst()
        {
            /*Написать программу, содержащую решение следующих задач:
            На совещании у начальства раздавали задачи. Сотрудники фирмы так задолбались, что
            решили, что будут получать задачи только в том случае, если это их прямое руководство.
            Все возмущение началось из‐за того, что бухгалтерия решила автоматизировать себе работу,
            они хотят приходить на работу, нажимать на кнопочку и чтобы все само делалось, а отдел
            информационных технологий должен сделать эту задачу им. Перейдем к иерархии
            сотрудников:
            Главный в конторе Тимур – генеральный директор.
            У Тимура есть подчиненные:
            Финансовый директор – Рашид,
            Директор по автоматизации – О Ильхам.
            Рашид в подчинении держит бухгалтерию. В бухгалтерии главный Лукас.
            О Ильхам в подчинении держит отдел информационных технологий. В отделе
            информационных технологий следующая иерархия: существует начальник, зам.
            начальника и 2 сектора.
            Начальник инф систем – Оркадий
            Зам.начальника – Володя.
            ○ системщики (занимаются сетями). Главный в секторе системщиков: Ильшат,
            Зам: Иваныч, Сотрудники: Илья, Витя, Женя
            ○ разработчики (разработка и сопровождение). Главный секторе разработчиков:
            Сергей, Зам: Ляйсан, Сотрудники: Марат, Дина , Ильдар, Антон.
            Таким образом, Дина, Марат, Ильдар, Антон слушаются Ляйсан, Ляйсан слушается
            только Сергея, Сергей может слушаться Оркадия и Володю. Аналогично и с
           сектором системщиков. Организовать иерархию конторы, создать несколько
           примитивых задач.
           При назначении задач, задача должна иметь признак кому ее дают: системщикам или
           разработчикам или начальству(начальник и зам.начальник отдела), а потом
           распределить задачи по сотрудникам. На экране будет следующее: от человека А
           даётся задача «название задачи» человек Б. И надо вывести берет человек задачу или
           нет.*/
            Console.WriteLine("Задание из файла");
            Workers generalDirector = new Workers("Тимур", "Генеральный деректор");
            Workers financialDirector = new Workers("Рашид", "Финансовый деректор");
            Workers automationDirector = new Workers(" О Ильхам", "Деректор по автоматизации");
            Workers chiefAccountant = new Workers("Лукас", "Главнй по бугалтерии");
            Workers headOfInformationSystems = new Workers("Оркадий", "Начальник инфомационных систем");
            Workers deputyGeneralDirectorHeadOfInformationSystems = new Workers("Володя", "Заместитель начальника информационных систем");
            Workers systemAnalystIlshat = new Workers("Ильшат", "Главный в секторе системщиков");
            Workers systemAnalystIvanych = new Workers("Иваныч", "Заместитель главного в секторе системщиков");
            Workers systemAnalystIlya = new Workers("Илья", "Системщик");
            Workers systemAnalystVitya = new Workers("Витя", "Системщик");
            Workers systemAnalystZhenya = new Workers("Женя", "Системщик");
            Workers theMainDeveloper = new Workers("Сергей", "Главный разработчик");
            Workers developerLyaysan = new Workers("Ляйсан", "Заместитель главного разработчика");
            Workers developerMarat = new Workers("Марат", "Разработчик");
            Workers developerDina = new Workers("Дина", "Разработчик");
            Workers developerIldar = new Workers("Ильдар", "Разработчик");
            Workers developerAnton = new Workers("Антон", "Разработчик");
            generalDirector.AddSubordinate(financialDirector);
            generalDirector.AddSubordinate(automationDirector);
            financialDirector.AddSubordinate(chiefAccountant);
            automationDirector.AddSubordinate(headOfInformationSystems);
            automationDirector.AddSubordinate(deputyGeneralDirectorHeadOfInformationSystems);
            headOfInformationSystems.AddSubordinate(systemAnalystIlshat);
            headOfInformationSystems.AddSubordinate(systemAnalystIvanych);
            headOfInformationSystems.AddSubordinate(systemAnalystIlya);
            headOfInformationSystems.AddSubordinate(systemAnalystVitya);
            headOfInformationSystems.AddSubordinate(systemAnalystZhenya);
            deputyGeneralDirectorHeadOfInformationSystems.AddSubordinate(theMainDeveloper);
            systemAnalystIlshat.AddSubordinate(systemAnalystIlya);
            systemAnalystIlshat.AddSubordinate(systemAnalystVitya);
            systemAnalystIlshat.AddSubordinate(systemAnalystZhenya);
            theMainDeveloper.AddSubordinate(developerLyaysan);
            theMainDeveloper.AddSubordinate(developerMarat);
            theMainDeveloper.AddSubordinate(developerDina);
            theMainDeveloper.AddSubordinate(developerIldar);
            theMainDeveloper.AddSubordinate(developerAnton);
            deputyGeneralDirectorHeadOfInformationSystems.TaskAssignment("Абонентское обслуживание ПК", developerMarat);
            chiefAccountant.TaskAssignment("Обеспечение безопасности информационных систем", developerLyaysan);
            theMainDeveloper.TaskAssignment("Анализ и написание алгоритмов", developerDina);
            systemAnalystIlshat.TaskAssignment("Обслуживание серверного оборудования", systemAnalystVitya);
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            TaskFirst();
            
        }
    }
}
