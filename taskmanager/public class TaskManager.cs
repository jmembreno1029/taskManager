using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using taskmanager;

 public class TaskManager
    {
        public ObservableCollection<UserTask> UserTasks {get; set;} = new ObservableCollection<UserTask>();
    }