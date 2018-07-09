using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Entities;
using System.Data.Entity;
using TaskManager.BusinessLayer;
using TaskManager.DataLayer;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TaskManagerDbContext model = new TaskManagerDbContext())
            {
                ParentTask parentTask = new ParentTask();
                parentTask.ParentTaskID = 1;
                parentTask.ParentTaskDesc = "Parent 1";

                List<Task> taskList = new List<Task>();

                Task task = new Task();
                task.TaskID = 1;
                task.ParentTaskID = 1;
                task.StartDate = Convert.ToDateTime("27/06/2018");
                task.EndDate = Convert.ToDateTime("29/06/2018");
                task.TaskDesc = "Sample Task Parent 1";
                task.Priority = 10;
                taskList.Add(task);


                task = new Task();
                task.TaskID = 2;
                task.ParentTaskID = 1;
                task.StartDate = Convert.ToDateTime("20/06/2018");
                task.EndDate = Convert.ToDateTime("25/06/2018");
                task.TaskDesc = "This is test task Parent 1";
                task.Priority = 20;
                taskList.Add(task);


                task = new Task();
                task.TaskID = 3;
                task.ParentTaskID = 1;
                task.StartDate = Convert.ToDateTime("27/06/2018");
                task.EndDate = Convert.ToDateTime("29/06/2018");
                task.TaskDesc = "Test Task Parent 1";
                task.Priority = 5;
                taskList.Add(task);

                parentTask.Tasks = taskList;

                model.ParentTasks.Add(parentTask);

                parentTask = new ParentTask();
                parentTask.ParentTaskID = 2;
                parentTask.ParentTaskDesc = "Parent 2";

                taskList = new List<Task>();

                task = new Task();
                task.TaskID = 4;
                task.ParentTaskID = 2;
                task.StartDate = Convert.ToDateTime("27/04/2018");
                task.EndDate = Convert.ToDateTime("29/06/2018");
                task.TaskDesc = "Sample Task parent 2";
                task.Priority = 15;
                taskList.Add(task);


                task = new Task();
                task.TaskID = 5;
                task.ParentTaskID = 2;
                task.StartDate = Convert.ToDateTime("20/03/2018");
                task.EndDate = Convert.ToDateTime("25/05/2018");
                task.TaskDesc = "This is test task Parent 2";
                task.Priority = 21;
                taskList.Add(task);


                task = new Task();
                task.TaskID = 6;
                task.ParentTaskID = 2;
                task.StartDate = Convert.ToDateTime("27/06/2018");
                task.EndDate = Convert.ToDateTime("29/09/2018");
                task.TaskDesc = "Test Task Parent 2";
                task.Priority = 30;
                taskList.Add(task);

                parentTask.Tasks = taskList;

                model.ParentTasks.Add(parentTask);

                model.SaveChanges();
            }
            //TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            //List<Task> taskList = businessLayer.GetAllTasks();

            //Task task = businessLayer.GetTask(1);
            
            

        }
    }
}
