using BugTracker.Commands;
using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Mapper
{
    public static class CommandToModelMapper
    {
        public static Bug ToModel(this AddNewBugCommand command)
        {
            return new Bug(command.Email, command.BugTitle, command.BugDescription);

        }
    }
}
