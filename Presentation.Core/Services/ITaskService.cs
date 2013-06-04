using System.Collections.Generic;
using System.Collections.ObjectModel;
using TaskManager.Core.Model;

namespace TaskManager.Core.Services
{
    public interface ITaskService
    {
        IEnumerable<Task> AddTask(Task task);
        IEnumerable<Task> GetFinishedTasks();
        IEnumerable<Task> GetAllTasks();
        IEnumerable<Task> GetUnfinishedTasks();
    }
}