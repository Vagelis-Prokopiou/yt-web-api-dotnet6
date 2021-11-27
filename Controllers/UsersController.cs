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
            var list = new List<User>();
            for (int i = 1; i < 1001; i++) {
                var user = new User();
                user.Id = i;
                user.FirstName = "FirstName " + 1;
                user.LastName = "LastName " + 1;
                user.Framework = "dotnet 6";

                list.Add(user);
            }

            return list;
        }

        [HttpGet(Name = "Users")]
        public IEnumerable<User> Get() {
            return GetUsers();
        }
    }
}