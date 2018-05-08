using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearning.Models;

namespace MVCLearning.Controllers
{
    public class TaskStatusController : Controller
    {
        // GET: TaskStatus
        public ActionResult Index()
        {
            //List<TaskStatusViewModel> lstTasks = new List<TaskStatusViewModel>();
            //using (var dbContext = new ApplicationDbContext())
            //{
            //    lstTasks = dbContext.TaskStatus.ToList();
            //}
            //ViewBag.Task = lstTasks;
            return View();
        }


        public ActionResult ListStatus(int id)
        {
            ListStatus lst = new ListStatus();
            using (var db = new ApplicationDbContext())
            {
                lst.lstTaskStatus = db.TaskStatus.Where(d => d.Id == id).ToList();
            }
            return View("Index", lst);
        }

    }
}
