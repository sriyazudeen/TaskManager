using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Entities;
using TaskManager.DataLayer;
using System.Data.Entity;
namespace TaskManager.BusinessLayer
{
    public class TaskManagerBusinessLayer
    {
        public List<Task> GetAllTasks()
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();            
            return dbContext.Tasks.Include(p=>p.ParentTask).ToList();
        }

        public Task GetTask(int id)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            return dbContext.Tasks.Include("ParentTask").Where(t => t.TaskID == id).FirstOrDefault();
        }

        public List<ParentTask> GetAllParentTasks()
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            return dbContext.ParentTasks.Distinct<ParentTask>().ToList();
        }

        public string AddTask(Task task)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            dbContext.Tasks.Add(task);                     

            if(dbContext.SaveChanges() > 0)
            {
                return "Record added Successfully";
            }
            else
            {
                return "Failed. Plese try again later";
            }
        }

        public string EditTask(Task task)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            Task taskData = dbContext.Tasks.Find(task.TaskID);
            taskData.TaskDesc = task.TaskDesc;
            taskData.StartDate = task.StartDate;
            taskData.EndDate = task.EndDate;
            taskData.Priority = task.Priority;
            taskData.ParentTaskID = task.ParentTaskID;
            taskData.TaskStatus = task.TaskStatus;

            if (dbContext.SaveChanges() > 0)
            {
                return "Record updated Successfully";
            }
            else
            {
                return "Failed. Plese try again later";
            }
        }

        public string  DeleteTask(int id)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            Task task = dbContext.Tasks.Find(id);
            dbContext.Tasks.Remove(task);

            if (dbContext.SaveChanges() > 0)
            {
                return "Record deleted Successfully";
            }
            else
            {
                return "Failed. Plese try again later";
            }
        }
    }
}
