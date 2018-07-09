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
    public class ParentTaskManagerController : ApiController
    {
        public List<ParentTask> GetAllParentTasks()
        {
            TaskManagerBusinessLayer businessLayer = new TaskManagerBusinessLayer();
            return businessLayer.GetAllParentTasks();
        }
    }
}
