using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public enum FixPriority
    {
        [Description("فوری ")] Immediate = 1,

        [Description("کم ")] Low = 2,
        [Description("متوسط  ")] Medium = 4,
        [Description("بالا  ")] High = 3

    }
}
