using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using taskmanager;

 public class UserTask
    {
        public UserTask(string Description)
        {
            this.UserInput = Description;
        }
        public string UserInput {get; set;}
        public override string ToString()
        {
            return UserInput;
        }
      
    }