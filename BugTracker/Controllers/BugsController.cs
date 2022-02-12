using BugTracker.Commands;
using BugTracker.Models;
using BugTracker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : Controller
    {
        private readonly TrackerService _trackerService;
        public BugsController(TrackerService trackerService)
        {
            _trackerService = trackerService; 
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBug(AddNewBugCommand command)
        {
            await _trackerService.AddNewBugAsync(command);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBugsAsync()
        {
            var bugs = await _trackerService.GetAllAsync();
            return Ok(bugs);
        }
    }
}
