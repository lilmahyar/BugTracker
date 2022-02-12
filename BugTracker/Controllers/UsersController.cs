using BugTracker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
                
        }
    }
}
