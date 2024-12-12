using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFile7.Classes
{
    internal class Workers
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Workers> Subordinates { get; set; }
        public Workers(string name, string role)
        {
            Name = name;
            Role = role;
            Subordinates = new List<Workers>();
        }
        public void AddSubordinate(Workers worker)
        {
            Subordinates.Add(worker);
        }
        public bool AcceptingATask(string task)
        {
            Console.WriteLine($"{Name} принимает задачу: {task}");
            return true;
        }
        public bool TaskAssignment(string task, Workers worker)
        {
            if (Subordinates.Contains(worker))
            {
                Console.WriteLine($"От {Name} даётся задача: {task} для {worker.Name} ");
                return worker.AcceptingATask(task);
            }
            else
            {
                Console.WriteLine($"{worker.Name} не выполняет задачу: {task}");
                return false;
            }
        }

    }

}

