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
    public class UsersController : ControllerBase
    {
        public readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public User Post([FromBody] User user )
        {
            _userService.Post(user);
            return user;
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public User Put([FromBody] User user)
        {
            _userService.Put(user);
            return user;
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            _userService.Delete(id);
            return null;
        }
    }
}
