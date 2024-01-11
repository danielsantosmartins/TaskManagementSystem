using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagementSystem.Entities.Enums
{
    enum Status : int
    {
        Pending = 1,
        Running = 2,
        Completed = 3,
        Canceled = 4
    }
}
