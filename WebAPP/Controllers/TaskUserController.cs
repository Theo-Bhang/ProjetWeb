using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL;
using App.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPP
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskUserController : ControllerBase
    {

        private readonly BDDContext _BDDContext;

        public TaskUserController(BDDContext BDDContext)
        {
            _BDDContext = BDDContext;
        }

        // GET: api/<TaskUserController>
        [HttpGet]
        public IEnumerable<TaskUser> Get()
        {
            return _BDDContext.TaskUser;
        }

        // GET api/<TaskUserController>/5
        [HttpGet("{id}")]
        public TaskUser Get(int id)
        {
            return _BDDContext.TaskUser.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<TaskUserController>
        [HttpPost]
        public void Post([FromBody] TaskUser taskUser)
        {
            _BDDContext.TaskUser.Add(taskUser);
            _BDDContext.SaveChanges();
        }

        // PUT api/<TaskUserController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] TaskUser taskUser)
        {
            _BDDContext.TaskUser.Update(taskUser);
            _BDDContext.SaveChanges();
        }

        // DELETE api/<TaskUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _BDDContext.TaskUser.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                
                    _BDDContext.TaskUser.Remove(item);
                    _BDDContext.SaveChanges();
            }
        }
    }
}
