using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreSample.Doman
{
    public class Projects
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public DateTime Last_updated_time { get; set; }

        public DateTime Start_time { get; set; }

        public DateTime End_time { get; set; }


        public ICollection<EmployeeProjects> EmployeeProject { get; set; }
        // public ICollection<Employee> ProjectEmployees { get; set; }

        //public Employee Employee { get; set; }

    }
}
