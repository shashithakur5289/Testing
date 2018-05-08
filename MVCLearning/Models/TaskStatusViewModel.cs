using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLearning.Models
{
    public class TaskStatusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ListStatus {
        public List<TaskStatusViewModel> lstTaskStatus { get; set; }
    }
}