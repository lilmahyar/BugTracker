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
        public async Task<IActionResult> AddNewBug(Bug bug)
        {
            await _trackerService.AddNewBugAsync(bug);
            return Ok();
        }
    }
}
