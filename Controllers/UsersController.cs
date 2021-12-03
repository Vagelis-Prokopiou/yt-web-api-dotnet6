using System.Collections.Generic;
using dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class UsersController : ControllerBase{
        public List<User> GetUsers() {
            var list = new List<User>(1000);
            for (int index = 1; index < 1001; index++) {
                list.Add(new User {
                    Id = index,
                    First_Name = "First_Name" + index,
                    Last_Name = "Last_Name" + index,
                    Age = index,
                    Framework = "dotnet6"
                });
            }

            return list;
        }

        [HttpGet(Name = "Users")]
        public IEnumerable<User> Get() {
            return GetUsers();
        }
    }
}