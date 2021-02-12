using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL;

namespace App.BL
{
    public class TaskService : ITaskService
    {
        private readonly BDDContext _BDDContext;

        public TaskService(BDDContext BDDContext)
        {
            _BDDContext = BDDContext;
        }

        public IEnumerable<TaskModel> Get()
        {
            return _BDDContext.Tasks;
        }

        public TaskModel Get(int id)
        {
            return _BDDContext.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public void Post(TaskModel Task)
        {
            _BDDContext.Tasks.Add(Task);
            _BDDContext.SaveChanges();
        }

        public void Put(TaskModel Task)
        {
            _BDDContext.Tasks.Update(Task);
            _BDDContext.SaveChanges();
        }

        public void Delete(int id, TaskModel task)
        {
            var item = _BDDContext.Tasks.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                if (task.Status != "Todo")
                {
                    _BDDContext.Tasks.Remove(item);
                    _BDDContext.SaveChanges();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

    }
}