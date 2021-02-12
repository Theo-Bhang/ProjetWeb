using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.DAL
{
    public class TaskUser
    {
        public int Id { get; set; }

        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string TaskName { get; set; }
        public string assignedUser { get; set; }
    }
}
