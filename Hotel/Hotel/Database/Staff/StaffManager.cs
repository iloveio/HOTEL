using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Staff
{
    class StaffManager
    {
        List<Director> directorList;
        List<EmployeeStatus> employeeStatusList;
        List<Job> jobsList;
        List<Subordinate> subordinatesList;
        List<Supervisor> supervisorList;

        public void FillDataWithAllDirectors()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Directors
                            select b;
                directorList = query.ToList<Director>();
            }
        }
        public void FillDataWithAllEmployeeStatus()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.EmployeeStatuses
                            select b;
                employeeStatusList = query.ToList<EmployeeStatus>();
            }
        }
        public void FillDataWithAllJobs()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Jobs
                            select b;
                jobsList = query.ToList<Job>();
            }
        }
        public void FillDataWithAllSubordinates()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Subordinates
                            select b;

                subordinatesList = query.ToList<Subordinate>();

            }
        }
        public void FillDataWithAllSupervisor()
        {
            using (var db = new StaffContext())
            {
                var query = from b in db.Supervisors
                            select b;

                supervisorList = query.ToList<Supervisor>();

            }
        }
    }
}
