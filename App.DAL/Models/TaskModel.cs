using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.DAL
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status {get; set;}
        /*public Status status{get;set;}

        public enum Status
        {
            Todo,
            Ongoing,
            Done
        }*/

    }
}
