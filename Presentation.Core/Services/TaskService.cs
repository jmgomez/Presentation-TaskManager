using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TaskManager.Core.Model;

namespace TaskManager.Core.Services
{
    public class TaskService : ITaskService
    {
        private readonly IList<Task> _tasks;
      
        public TaskService()
        {
            _tasks =  new List<Task>(new []
            {
                new Task(){Complete = true, Name = "Hacer el ejemplo."},  
                new Task(){Complete = false, Name = "Hacer los slides."},  
                new Task(){Complete = false, Name = "Asegurarse de que todo funciona correctamente."},  
            });
            
        }

        public IEnumerable<Task> AddTask(Task task)
        {
            _tasks.Add(task);
            return new List<Task>(_tasks);
        }

        public IEnumerable<Task> GetFinishedTasks()
        {
            return new List<Task>(_tasks.Where(t => t.Complete));

        }

        public IEnumerable<Task> GetAllTasks()
        {
            return new List<Task>(_tasks);
        }

        public IEnumerable<Task> GetUnfinishedTasks()
        {
            return new List<Task>(_tasks.Where(t => !t.Complete));
        }

       
    }
}