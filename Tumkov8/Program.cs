using System;
using System.Collections.Generic;
using System.IO;

namespace Tumkov8.Class
{
    internal class Program
    {
        static void TaskFirst()
        {
            /*Упражнение 8.1 В класс банковский счет, созданный в упражнениях 7.1- 7.3 добавить
            метод, который переводит деньги с одного счета на другой. У метода два параметра: ссылка
            на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.*/
            Console.WriteLine("Упражнение 8.1");
            BankAccount yourAccount = new BankAccount("333999777", 578908725538, BankAccount.AccountType.Текущий);
            BankAccount savingsAccount = new BankAccount("333999778", 98000, BankAccount.AccountType.Сберегательный);
            Console.WriteLine("Информация о вашем счёте в банке: ");
            yourAccount.InfoAccount();
            yourAccount.AccountReplenishment(10000000);
            yourAccount.WithdrawalFromTheAccount(600000);
            yourAccount.TransferFromOneAccountToAnother(savingsAccount, 4673168);
            Console.WriteLine(" ");
        }
        static void TaskSecond()
        {
            /*Упражнение 8.2 Реализовать метод, который в качестве входного параметра принимает
            строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.
            Протестировать метод.*/
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Ввод строки: ");
            try
            {
                Console.WriteLine("Введите строку: ");
                string sentence = Console.ReadLine();
                if (string.IsNullOrEmpty(sentence))
                {
                    throw new ArgumentException("Ошибка: пустая строка");
                }

                string sentenceConversely = ChangesThePositionOfTheLetters(sentence);
                Console.WriteLine($"Перевернутая строка (буквы в обратном порядке): {sentenceConversely}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static string ChangesThePositionOfTheLetters(string sentence)
        {
            object[] o = new object[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                o[i] = sentence[i];
            }
            char[] converselyLetters = new char[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                converselyLetters[i] = (char)o[sentence.Length - 1 - i];
            }
            return new string(converselyLetters);
        }
        static void TaskThird()
        {
            /*Упражнение 8.3 Написать программу, которая спрашивает у пользователя имя файла. Если
            такого файла не существует, то программа выдает пользователю сообщение и заканчивает
            работу, иначе в выходной файл записывается содержимое исходного файла, но заглавными
            буквами.*/
            Console.WriteLine(" ");
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Введите имя файла (с полным путём к нему): ");
            string fileName = Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Такого файла не существует");
                return;
            }
            try
            {
                string fileText = File.ReadAllText(fileName);
                string resultFileText = fileText.ToUpper();
                string resultFile = @"C:\Users\User\Documents\result.txt;";
                File.WriteAllText(resultFile, resultFileText);

                Console.WriteLine(resultFileText);
            }
            catch (Exception file)
            {
                Console.WriteLine($"{file.Message}");
            }
        }
        static void TaskFourth()
        {
            /*Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр
            метода интерфейс System.IFormattable. Использовать оператор is и as. (Интерфейс
            IFormattable обеспечивает функциональные возможности форматирования значения объекта
            в строковое представление.)*/
            Console.WriteLine(" ");
            Console.WriteLine("Упражнение 8.4");
            string aSetOfWords = "Здравствуйте!";
            Console.WriteLine($"Входной параметр метода реализует интерфейс System.IFormattable: {IsIFormattable(aSetOfWords)}");
        }
        static bool IsIFormattable(object o)
        {
            if (o == null)
            {
                Console.WriteLine("Null");
                return false;
            }
            if (o is IFormattable)
            {
                return true;
            }
            return false;
        }
        static void TaskFifth()
        {
            /*Домашнее задание 8.1 Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail
            адрес. Разделителем между ФИО и адресом электронной почты является символ #:
            Иванов Иван Иванович # iviviv@mail.ru
            Петров Петр Петрович # petr@mail.ru
            Сформировать новый файл, содержащий список адресов электронной почты.
            Предусмотреть метод, выделяющий из строки адрес почты. Методу в
            качестве параметра передается символьная строка s, e-mail возвращается в той же строке s:
            public void SearchMail (ref string s).*/
            Console.WriteLine(" ");
            Console.WriteLine("Домашнее задание 8.1");
            string firstFileName = "email.txt";
            string resultFileName = "onlymail.txt";
            try
            {
                string[] text = File.ReadAllLines(firstFileName);
                var mail = new List<string>();
                foreach (string t in text)
                {
                    string keeping = t;


                    SearchMail(ref keeping);
                    if (!string.IsNullOrEmpty(keeping))
                    {
                        mail.Add(keeping);
                    }
                }
                File.WriteAllLines(resultFileName, mail);
                Console.WriteLine("Операция выполнена успешно. Файл,содержащий список адресов почты сформирован в onlymail.txt ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SearchMail(ref string s)
        {

            int extractingMail = s.IndexOf('#');

            if (extractingMail != -1)
            {
                s = s.Substring(extractingMail + 1);
            }
            else
            {
                s = string.Empty;
            }
        }
        static void Main(string[] args)
        {
            TaskFirst();
            TaskSecond();
            TaskThird();
            TaskFourth();
            TaskFifth();
            /*Домашнее задание 8.2 Список песен. В методе Main создать список из четырех песен. В
            цикле вывести информацию о каждой песне. Сравнить между собой первую и вторую
            песню в списке. Песня представляет собой класс с методами для заполнения каждого из
            полей, методом вывода данных о песне на печать, методом, который сравнивает между
            собой два объекта:
             class Song{
             string name; //название песни
             string author; //автор песни
             Song prev; //связь с предыдущей песней в списке
            //метод для заполнения поля name
            //метод для заполнения поля author
            //метод для заполнения поля prev
           //метод для печати названия песни и ее исполнителя
           public string Title(){... /*возвращ название+исполнитель*...}
           //метод, который сравнивает между собой два объекта-песни:
           public bool override Equals(object d) { ...} */
            Console.WriteLine(" ");
            Console.WriteLine("Домашнее задание 8.2");
            List<Song> song = new List<Song>();
            Song song1 = new Song();
            song1.SetName("Almost Idyllic");
            song1.SetAuthor("Sleeping At Last");
            Song song2 = new Song();
            song2.SetName("Motovilov:A Little Journey");
            song2.SetAuthor("Alexander Motovilov");
            Song song3 = new Song();
            song3.SetName("Beving:Ala");
            song3.SetAuthor("Joep Beving");
            Song song4 = new Song();
            song4.SetName("Once Upon a Time");
            song4.SetAuthor("Austin Farwell");
            song2.SetPrev(song1);
            song3.SetPrev(song2);
            song4.SetPrev(song3);
            song.Add(song1);
            song.Add(song2);
            song.Add(song3);
            song.Add(song4);
            Console.WriteLine("Информация о заданных песнях:");
            foreach (var son in song)
            {
                Console.WriteLine(son.Title());
            }
            Console.WriteLine("Результат сравнения между собой двух объектов-песен: ");
            if (song1.Equals(song2))
            {
                Console.WriteLine("Песни 1 и 2 одинаковые");
            }
            else
            {
                Console.WriteLine("Песни 1 и 2 разные");
            }



        }
    }
}
