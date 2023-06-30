using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserControler : ControllerBase
    {
        List<User> users = new List<User>();

        public UserControler()
        {
            users.Add(new User
            {
                firstName = "Max",
                lastName = "Elgaucho",
                age = 29,
                email = "m.elgaucho@gmail.com",
                phone = "0936653867"
            });

            users.Add(new User
            {
                firstName = "Yaroslav",
                lastName = "Kostenko",
                age = 16,
                email = "yaroslav@schoolboy.net",
                phone = "0977777777"
            });
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpGet]
        [Route("API/Users/{lastName}")]
        public IActionResult GetUser(string lastName)
        {

            var user = users.Find(u => u.lastName == lastName);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpPost]
        public IActionResult PostUsers(User updatedUser)
        {
            //создание юзера
            User newUser = new User
            {
                firstName = updatedUser.firstName,
                lastName = updatedUser.lastName,
                age = updatedUser.age,
                email = updatedUser.email,
                phone = updatedUser.phone
            };
            return Created(" ", newUser);
        }
        [HttpPut]
        public IActionResult UpdateUser(string LastName, User updatedUser)
        {
            var user = users.Find(u => u.lastName == LastName);
            if (user == null)
            {
                return NotFound();
            }

            user.firstName = updatedUser.firstName;
            user.lastName = updatedUser.lastName;
            user.age = updatedUser.age;
            user.email = updatedUser.email;
            user.phone = updatedUser.phone;

            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteUser(string LastName)
        {
            var user = users.Find(u => u.lastName == LastName);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);

            return NoContent();
        }
    }
}