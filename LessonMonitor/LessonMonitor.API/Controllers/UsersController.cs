using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("MyUser")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public User[] Gitst()
        {
            var rnd = new Random();
            var users = new User[10];
            for (int i = 0; i < users.Length; i++)
            {
                var user = new User()
                {
                    UserName = "User_" + i.ToString()+";",
                    Age=rnd.Next(18,75)
                };
                users[i] = user;
            }
            return users;
        }

        //[HttpGet]
        //public string Get2()
        //{
        //    return "Vova";
        //}
    }
}
