using App.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.BL
{
    public interface ITaskService
    {
        public IEnumerable<TaskModel> Get();
        public TaskModel Get(int id);
        public void Post(TaskModel task);
        public void Put(TaskModel task);
        public void Delete(int id, TaskModel task);
    }
}