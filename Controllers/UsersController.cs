using System;
using System.Collections.Generic;
using System.Linq;
using dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class UsersController : ControllerBase{
        public List<User> GetUsers() {
            var list = new List<User>(1000);
            for (int i = 1; i < 1001; i++) {
                list.Add(new User {
                    Id = i,
                    First_Name = "First_Name" + i,
                    Last_Name = "Last_Name" + i,
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