using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BL;
using App.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPP
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        public ITaskService _taskService;
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<TaskModel> Get()
        {
            return _taskService.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public TaskModel Get(int id)
        {
            return _taskService.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] TaskModel task)
        {
            _taskService.Post(task);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] TaskModel task )
        {
            _taskService.Put(task);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, TaskModel task)
        {
            _taskService.Delete(id, task);
        }
    }
}