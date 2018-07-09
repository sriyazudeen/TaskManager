using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManager.Entities;
using TaskManager.BusinessLayer;

namespace TaskManagerAPI.Controllers
{
    public class TaskManagerController : ApiController
    {
        // GET: api/TaskManager
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.GetAllTasks();
        }

        // GET: api/TaskManager/5
        [HttpGet]
        public Task Get(int id)
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.GetTask(id);
        }

        // POST: api/TaskManager
        [HttpPost]
        public string AddTask(Task task)
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.AddTask(task);
            
        }

        // PUT: api/TaskManager/5
        [HttpPut]
        public string EditTask(Task task)
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.EditTask(task);
        }

        // DELETE: api/TaskManager/5
        [HttpDelete]
        public string DeleteTask(int id)
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.DeleteTask(id);
        }
    }
}
