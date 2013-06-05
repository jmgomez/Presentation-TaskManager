using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using TaskManager.Core.Model;
using TaskManager.Core.Services;

namespace TaskManager.Core.ViewModels
{
    public class TaskListViewModel 
		: MvxViewModel
    {
        private readonly ITaskService _taskService;
        private IEnumerable<Task> _tasks;
        private string _newTaskText;

        public TaskListViewModel(ITaskService taskService)
        {
            _taskService = taskService;
            Tasks = _taskService.GetAllTasks(); 
        }



        public IEnumerable<Task> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; RaisePropertyChanged(()=>Tasks); }
        }

        public ICommand AddTaskCommand
        {
            get { return new MvxCommand(AddTask); }
        }

        private void AddTask()
        {
           if(!string.IsNullOrWhiteSpace(NewTaskText))
                Tasks = _taskService.AddTask(new Task(){Name=NewTaskText});
           NewTaskText = string.Empty;
        }

        public ICommand ShowFinishedTasksCommand
        {
            get { return new MvxCommand(ShowFinished); }
        }

        private void ShowFinished()
        {
            Tasks = _taskService.GetFinishedTasks();
        }
        public ICommand ShowUnfinishedTasksCommand
        {
            get { return new MvxCommand(ShowUnfinished); }
        }

        private void ShowUnfinished()
        {
            Tasks = _taskService.GetUnfinishedTasks();
        }
        public ICommand ShowAllTasksCommand
        {
            get { return new MvxCommand(ShowAllTasks); }
        }

        private void ShowAllTasks()
        {
            Tasks = _taskService.GetAllTasks();
        }

        public string NewTaskText
        {
            get { return _newTaskText; }
            set { _newTaskText = value; this.RaisePropertyChanged(()=>NewTaskText); }
        }
    }
}
