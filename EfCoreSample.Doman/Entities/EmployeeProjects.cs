using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreSample.Doman
{
   public class EmployeeProjects
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long ProjectId { get; set; }
        public Projects Project { get; set; }
        public Employee Employees { get; set; }

    }
}
