using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("MyUser")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Gitst()
        {
            var rnd = new Random();
            var users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                var user = new User()
                {
                    UserName = "User_" + i.ToString()+";",
                    Age=rnd.Next(18,75)
                };
                users.Add(user);
            }
            return users;
        }

    }
}
