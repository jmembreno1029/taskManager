using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace taskmanager
{     
    class Program
    {    
        public static TaskManager tm = new TaskManager();
        static void Main()
        {
            int num = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. Mark a task complete");
                Console.WriteLine("4. List tasks");
                Console.WriteLine("5. EXIT");                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("What would you like to do? (Please enter the corresponding number): ");                
                Console.ResetColor();
                num = Reading.ReadInt32FromConsole();

                switch(num)
                {
                    case -1: 
                    Console.WriteLine("Please select a valid option. (1 through 5)");
                    break;

                    case 1: 
                    Console.Write("Please enter a task: ");
                    var input = Reading.ReadTextLineFromConsole();
                    var ut = new UserTask(input);
                    tm.UserTasks.Add(ut);                    
                    Console.WriteLine($"New Task: {ut.ToString()}");
                    break;

                    case 2:                   
                    int i = 0;
                    int j = 1;
                    for (i = 0; i < tm.UserTasks.Count; i++)
                    {
                    Console.Write(j + " ");
                    Console.WriteLine(tm.UserTasks[i]);
                    j++;
                    }     
                    Console.WriteLine();           
                    Console.Write("Please write out the task you would like to remove (CASE-SENSITIVE [include (complete) if applicable]): ");
                    input = Reading.ReadTextLineFromConsole();
                    ut = new UserTask(input);

                    for(i = 0; i < tm.UserTasks.Count; i++)
                    {
                    if(input == tm.UserTasks[i].UserInput)
                        {                            
                            tm.UserTasks.RemoveAt(i); 
                            break;  
                        }
                    }                                                        
                    break;
               
                    case 3:
                    i = 0;
                    j = 1;
                    for (i = 0; i < tm.UserTasks.Count; i++)
                    {
                    Console.Write(j + " ");
                    Console.WriteLine(tm.UserTasks[i]);
                    j++;
                    }       
                    Console.WriteLine();
                    Console.Write("Please write out the task you would like to mark complete (CASE-SENSITIVE):  ");
                    input = Reading.ReadTextLineFromConsole();
                    ut = new UserTask(input);

                    for(i = 0; i < tm.UserTasks.Count; i++)
                    {
                    if(input == tm.UserTasks[i].UserInput)
                        {                            
                            tm.UserTasks[i].UserInput = tm.UserTasks[i].UserInput + " (complete)"; 
                            break;  
                        }
                    }                           
                    break;
 
                    case 4:                 
                    i = 0;
                    j = 1;
                    for (i = 0; i < tm.UserTasks.Count; i++)
                    {
                    Console.Write(j + " ");
                    Console.WriteLine(tm.UserTasks[i]);
                    j++;                
                    }                           
                    break;

                    case 5:
                    Environment.Exit(0);
                    break;                 
                }
            }
            while(num != 6);
           
        }
    }
}
